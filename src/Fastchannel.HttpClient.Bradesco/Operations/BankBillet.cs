using Fastchannel.HttpClient.Bradesco.Models.BradescoApi.Request;
using Fastchannel.HttpClient.Bradesco.Models.BradescoApi.Response;
using Fastchannel.HttpClient.Bradesco.RestClient.Models;
using System.Collections.Generic;
using System.Net.Http;

namespace Fastchannel.HttpClient.Bradesco.Operations
{
    internal class BankBillet : OperationWithCallback<ResponseBoleto>
    {
        protected override string Resource => "apiboleto/transacao";

        public override bool IsProcessable<T>(T request) => request is RequestBoleto;

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
                93005119
            }.Contains(responseCode);
        }
    }
}
