using Fastchannel.HttpClient.Bradesco;
using Fastchannel.HttpClient.Bradesco.Models.BradescoApi.Request;

namespace Fastchannel.HttpClient.Bradesco.Operations
{
    internal abstract class OperationBase
    {
        internal Settings Settings { get; set; }

        public abstract bool IsProcessable<T>(T request) where T : RequestBase;
    }
}