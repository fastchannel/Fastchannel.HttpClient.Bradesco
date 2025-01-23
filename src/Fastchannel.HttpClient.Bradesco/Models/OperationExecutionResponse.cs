using Fastchannel.HttpClient.Bradesco.Models.BradescoApi.Response;
using System.Net.Http;

namespace Fastchannel.HttpClient.Bradesco.Models
{
    public class OperationExecutionResponse<TResponse> : BaseResponse
        where TResponse : ResponseBase
    {
        public OperationExecutionResponse()
        {

        }

        internal HttpResponseMessage HttpResponseMessage { get; set; }
        public TResponse SuccessData { get; set; }
    }
}
