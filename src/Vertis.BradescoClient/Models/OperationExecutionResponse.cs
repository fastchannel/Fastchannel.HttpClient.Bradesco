using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Vertis.BradescoClient.Enumerators;
using Vertis.BradescoClient.Models.BradescoApi.Response;

namespace Vertis.BradescoClient.Models
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
