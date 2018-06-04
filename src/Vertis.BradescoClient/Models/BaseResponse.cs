using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Vertis.BradescoClient.Enumerators;
using Vertis.BradescoClient.Models.BradescoApi.Response;
using Vertis.BradescoClient.RestClient.Models;

namespace Vertis.BradescoClient.Models
{
    public class BaseResponse
    {
        public BaseResponse()
        {
            this.Messages = new List<string>();
        }

        public ExecutionStatus Status { get; set; }
        public List<string> Messages { get; set; }
        internal Request RequestMessage { get; set; }
        public OperationExecutionInfo ExecutionInfo { get; set; }

        public BaseResponse CreateFailedResponse()
        {
            this.Status = ExecutionStatus.Failed;

            return this;
        }
        public BaseResponse AddMessage(string message)
        {
            this.Messages.Add(message);
            return this;
        }
    }
}
