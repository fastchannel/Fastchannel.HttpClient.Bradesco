using System.Collections.Generic;
using System.Net.Http;
using Vertis.BradescoClient.Models.BradescoApi.Request;
using Vertis.BradescoClient.Models.BradescoApi.Response;
using Vertis.BradescoClient.RestClient.Models;

namespace Vertis.BradescoClient.Operations
{
    internal class Tef : OperationWithCallback<ResponseTef>
    {
        protected override string Resource => "transf/transacao";

        public override bool IsProcessable<T>(T request) => request is RequestTef;

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
                0
            }.Contains(responseCode);
        }
    }
}
