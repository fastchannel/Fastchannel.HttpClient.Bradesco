using Vertis.BradescoClient.Operations;
using Vertis.BradescoClient.Models;
using System.Threading.Tasks;
using Vertis.BradescoClient.Models.BradescoApi.Response;
using Vertis.BradescoClient.Models.BradescoApi.Request;

namespace Vertis.BradescoClient
{
    public class BradescoClient
    {
        private readonly Settings _settings;

        private readonly OperationBase[] _knownOperations =
        {
            new BankBillet(),
            new BankBilletRegistration(),
            new BankBilletRegistrationStatus(),
            new Tef()
        };

        public BradescoClient(Settings settings)
        {
            _settings = settings;
        }

        public async Task<OperationExecutionResponse<ResponseBoleto>> ProcessBankBillet(RequestBoleto request) =>
            await ProcessPaymentAsync<ResponseBoleto>(request).ConfigureAwait(false);

        public async Task<OperationExecutionResponse<ResponseBoletoRegistrado>>
            RegisterBankBillet(RequestBoletoRegistrado request) =>
            await ProcessPaymentAsync<ResponseBoletoRegistrado>(request);

        public async Task<OperationExecutionResponse<ResponseBoletoRegistradoStatus>>
            GetRegisteredBankBilletStatus(RequestBoletoRegistroStatus request) =>
            await ProcessPaymentAsync<ResponseBoletoRegistradoStatus>(request);

        public async Task<OperationExecutionResponse<ResponseTef>> ProcessTef(RequestTef request) =>
            await ProcessPaymentAsync<ResponseTef>(request);

        private async Task<OperationExecutionResponse<TResponse>> ProcessPaymentAsync<TResponse>(RequestBase request)
            where TResponse : ResponseBase, new()
        {
            OperationBase operation = null;
            foreach (var op in _knownOperations)
            {
                if (op.IsProcessable(request))
                    operation = op;
            }

            if (operation == null)
                return new OperationExecutionResponse<TResponse>()
                    .CreateFailedResponse()
                    .AddMessage("Nenhuma operação encontrada para a request atual") as OperationExecutionResponse<TResponse>;

            operation.Settings = _settings;

            var response = await ((Operation<TResponse>)operation).ProcessAsync(request).ConfigureAwait(false);

            return (response ?? new OperationExecutionResponse<TResponse>()
                                        .CreateFailedResponse()) as OperationExecutionResponse<TResponse>;
        }
    }
}
