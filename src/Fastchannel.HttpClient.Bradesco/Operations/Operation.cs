using Fastchannel.HttpClient.Bradesco.Enumerators;
using Fastchannel.HttpClient.Bradesco.Models;
using Fastchannel.HttpClient.Bradesco.Models.BradescoApi.Request;
using Fastchannel.HttpClient.Bradesco.Models.BradescoApi.Response;
using Fastchannel.HttpClient.Bradesco.RestClient.Models;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Fastchannel.HttpClient.Bradesco.Operations
{
    internal abstract class Operation<TResponse> : OperationBase
        where TResponse : ResponseBase, new()
    {
        protected abstract string Resource { get; }

        protected abstract Request CreateRequest<TRequest>(TRequest request)
            where TRequest : RequestBase;

        protected abstract bool IsSuccessfullResponseCode(int responseCode);

        protected async Task<OperationExecutionResponse<TResponse>> ExecuteOperation<T>(T request)
            where T : RequestBase
        {
            OperationExecutionResponse<TResponse> response = new OperationExecutionResponse<TResponse>();

            try
            {
                request.MerchantId = Settings.MerchantId;
                var restRq = CreateRequest(request);
                restRq.TimeoutInSeconds = request.TimeoutInSeconds;

                using (var restClient = new RestClient.RestClient(Settings.BaseEndpoint, Settings.DefaultTimeoutInSeconds))
                {
                    response.RequestMessage = restRq;
                    response.HttpResponseMessage = await restClient.ExecuteAsync(restRq);
                }

                response.Status = ExecutionStatus.Success;
            }
            catch (Exception ex)
            {
                response.Status = ExecutionStatus.Failed;
                response.Messages.Add(ex.Message);
            }

            response.ExecutionInfo = await GetExecutionInfo(response);

            return response;
        }

        protected async Task<OperationExecutionResponse<TResponse>> ValidateResponse(OperationExecutionResponse<TResponse> executionContext, TResponse serviceResponse)
        {
            return await Task.Run(() =>
            {
                if (executionContext == null)
                {
                    executionContext = new OperationExecutionResponse<TResponse>();

                    executionContext.Messages.Add(Constants.INVALID_OPERATION_CONTEXT);
                    executionContext.Status = ExecutionStatus.Failed;

                    return executionContext;
                }

                switch (executionContext.HttpResponseMessage.StatusCode)
                {
                    case HttpStatusCode.Unauthorized:
                        executionContext = ProcessUnauthorizedStatus(executionContext, serviceResponse);
                        break;
                    case HttpStatusCode.Created:
                        executionContext = ProcessCreatedStatus(executionContext, serviceResponse);
                        break;
                    case HttpStatusCode.OK:
                        executionContext = ProcessOkStatus(executionContext, serviceResponse);
                        break;
                    case HttpStatusCode.UnsupportedMediaType:
                        executionContext = ProcessUnsupportedMediaTypeStatus(executionContext, serviceResponse);
                        break;
                    case HttpStatusCode.BadRequest:
                        executionContext = ProcessBadRequestStatus(executionContext, serviceResponse);
                        break;
                    case HttpStatusCode.ServiceUnavailable:
                        executionContext = ProcessServiceUnavailableStatus(executionContext, serviceResponse);
                        break;
                    default:
                        executionContext.Status = ExecutionStatus.Failed;
                        executionContext.Messages.Add(Constants.INVALID_RESPONSE);
                        break;
                }

                return executionContext;
            });
        }

        protected virtual OperationExecutionResponse<TResponse> ProcessServiceUnavailableStatus(OperationExecutionResponse<TResponse> executionContext, TResponse serviceResponse)
        {
            executionContext.Status = ExecutionStatus.Failed;
            executionContext.Messages.Add(Constants.SERVICE_UNAVAILABLE);

            return executionContext;
        }

        protected virtual OperationExecutionResponse<TResponse> ProcessBadRequestStatus(OperationExecutionResponse<TResponse> executionContext, TResponse serviceResponse)
        {
            executionContext.Status = ExecutionStatus.Failed;
            executionContext.Messages.Add(Constants.INVALID_REQUEST);

            return executionContext;
        }

        protected virtual OperationExecutionResponse<TResponse> ProcessUnsupportedMediaTypeStatus(OperationExecutionResponse<TResponse> executionContext, TResponse serviceResponse)
        {
            executionContext.Status = ExecutionStatus.Failed;
            executionContext.Messages.Add(Constants.UNSUPPORTED_MEDIA_TYPE);

            return executionContext;
        }

        protected virtual OperationExecutionResponse<TResponse> ProcessOkStatus(OperationExecutionResponse<TResponse> executionContext, TResponse serviceResponse)
        {
            var responseCode = serviceResponse?.Status?.Codigo ?? Constants.DEFAULT_ERROR_CODE;

            if (serviceResponse == null)
            {
                executionContext.Status = ExecutionStatus.Failed;
                executionContext.Messages.Add(Constants.INVALID_RESPONSE);
            }

            executionContext.Status = !IsSuccessfullResponseCode(responseCode) ? ExecutionStatus.Failed : ExecutionStatus.Success;

            if (executionContext.Status.Equals(ExecutionStatus.Failed))
                executionContext.Messages.Add(ErrorCodes.GetErrorMessage(responseCode));
            else
                executionContext.SuccessData = serviceResponse;

            return executionContext;
        }

        protected virtual OperationExecutionResponse<TResponse> ProcessCreatedStatus(OperationExecutionResponse<TResponse> executionContext, TResponse serviceResponse)
        {
            if (serviceResponse == null)
            {
                executionContext.Status = ExecutionStatus.Failed;
                executionContext.Messages.Add(Constants.INVALID_RESPONSE);
            }

            executionContext.SuccessData = serviceResponse;
            executionContext.Status = ExecutionStatus.Success;
            executionContext.Messages.Add(Constants.SUCCESSFULLY_OPERATION);

            return executionContext;
        }

        protected virtual OperationExecutionResponse<TResponse> ProcessUnauthorizedStatus(OperationExecutionResponse<TResponse> executionContext, TResponse serviceResponse)
        {
            executionContext.Status = ExecutionStatus.Failed;
            executionContext.Messages.Add(Constants.UNAUTHORIZED_OPERATION);

            return executionContext;
        }

        protected async Task<TResponse> ParseResponse(OperationExecutionResponse<TResponse> executionContext)
        {
            var content = await executionContext.HttpResponseMessage.Content.ReadAsStringAsync();
            return string.IsNullOrWhiteSpace(content) ? null : content.FromJson<TResponse>();
        }

        protected async Task<string> GetResponseJson(HttpResponseMessage httpResponseMessage)
        {
            return new ResponseLog
            {
                RequestedUrl = httpResponseMessage.RequestMessage?.RequestUri?.AbsoluteUri ?? "Url Indisponível",
                StatusCode = (int)httpResponseMessage.StatusCode,
                StatusCodeText = httpResponseMessage.StatusCode.ToString(),
                BodyContent = await httpResponseMessage.Content.ReadAsStringAsync(),
            }.ToJson();
        }

        protected async Task<OperationExecutionInfo> GetExecutionInfo(OperationExecutionResponse<TResponse> executionContext)
        {
            return new OperationExecutionInfo
            {
                SerilizedRequest = executionContext.RequestMessage.ToJson(),
                SerializedResponse = await GetResponseJson(executionContext.HttpResponseMessage)
            };
        }

        public async Task<BaseResponse> ProcessAsync<TRequest>(TRequest request)
            where TRequest : RequestBase
        {
            var executionResult = new OperationExecutionResponse<TResponse>();

            if (!IsProcessable(request))
                executionResult = new OperationExecutionResponse<TResponse> { Status = ExecutionStatus.NotAccepted };

            if (executionResult.Status.Equals(ExecutionStatus.NotAccepted))
                return null;

            executionResult = await ExecuteOperation(request);

            if (executionResult.Status.Equals(ExecutionStatus.Failed))
                return executionResult;

            return await ValidateResponse(executionResult, await ParseResponse(executionResult));
        }
    }
}
