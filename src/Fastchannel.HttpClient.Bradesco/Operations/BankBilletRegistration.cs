using Fastchannel.HttpClient.Bradesco.Models.BradescoApi.Request;
using Fastchannel.HttpClient.Bradesco.Models.BradescoApi.Response;
using Fastchannel.HttpClient.Bradesco.RestClient.Models;
using System.Collections.Generic;
using System.Net.Http;

namespace Fastchannel.HttpClient.Bradesco.Operations
{
    internal class BankBilletRegistration : Operation<ResponseBoletoRegistrado>
    {
        protected override string Resource => "apiregistro/api";

        public override bool IsProcessable<T>(T request) => request is RequestBoletoRegistrado;

        protected override Request CreateRequest<TRequest>(TRequest request)
        {
            return new Request(HttpMethod.Post, Resource)
                .AddAuthorization(Settings.MerchantId, Settings.SecureKey)
                .AddBody(request);
        }

        protected override bool IsSuccessfullResponseCode(int responseCode)
        {
            return new List<int>
            {
                0,
                930051,
                930053,
                93005119
            }.Contains(responseCode);
        }
    }
}
