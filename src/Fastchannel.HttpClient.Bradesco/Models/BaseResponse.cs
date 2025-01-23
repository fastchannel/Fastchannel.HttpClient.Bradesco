using Fastchannel.HttpClient.Bradesco.Enumerators;
using Fastchannel.HttpClient.Bradesco.RestClient.Models;
using System.Collections.Generic;

namespace Fastchannel.HttpClient.Bradesco.Models
{
    public class BaseResponse
    {
        public BaseResponse()
        {
            Messages = new List<string>();
        }

        public ExecutionStatus Status { get; set; }
        public List<string> Messages { get; set; }
        internal Request RequestMessage { get; set; }
        public OperationExecutionInfo ExecutionInfo { get; set; }

        public BaseResponse CreateFailedResponse()
        {
            Status = ExecutionStatus.Failed;

            return this;
        }
        public BaseResponse AddMessage(string message)
        {
            Messages.Add(message);
            return this;
        }
    }
}
