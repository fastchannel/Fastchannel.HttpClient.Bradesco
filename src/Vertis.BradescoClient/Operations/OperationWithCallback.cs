using Vertis.BradescoClient.Models.BradescoApi.Response;

namespace Vertis.BradescoClient.Operations
{
    internal abstract class OperationWithCallback<TResponse> : Operation<TResponse>
        where TResponse : ResponseBase, new()
    {
    }
}
