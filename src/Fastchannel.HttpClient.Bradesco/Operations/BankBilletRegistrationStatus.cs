using Fastchannel.HttpClient.Bradesco.Models.BradescoApi.Request;
using Fastchannel.HttpClient.Bradesco.Models.BradescoApi.Response;
using Fastchannel.HttpClient.Bradesco.RestClient.Models;
using System.Collections.Generic;
using System.Net.Http;

namespace Fastchannel.HttpClient.Bradesco.Operations
{
    internal class BankBilletRegistrationStatus : Operation<ResponseBoletoRegistradoStatus>
    {
        protected override string Resource => "apiregistro/api";

        public override bool IsProcessable<T>(T request) => request is RequestBoletoRegistroStatus;

        protected override Request CreateRequest<TRequest>(TRequest request)
        {
            var rq = request as RequestBoletoRegistroStatus;

            return new Request(HttpMethod.Get, Resource)
                .AddAuthorization(Settings.MerchantId, Settings.SecureKey)
                .AddQueryStringParameter("nosso_numero", rq?.NossoNumero)
                .AddQueryStringParameter("numero_documento", rq?.NumeroDocumento);
        }

        protected override bool IsSuccessfullResponseCode(int responseCode)
        {
            return new List<int>
            {
                0
            }.Contains(responseCode);
        }
    }
}
