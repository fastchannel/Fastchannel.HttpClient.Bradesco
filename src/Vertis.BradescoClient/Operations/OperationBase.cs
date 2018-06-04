using Vertis.BradescoClient.Models.BradescoApi.Request;

namespace Vertis.BradescoClient.Operations
{
    internal abstract class OperationBase
    {
        internal Settings Settings { get; set; }

        public abstract bool IsProcessable<T>(T request) where T : RequestBase;
    }
}