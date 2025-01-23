using Fastchannel.HttpClient.Bradesco.Models.BradescoApi.Response;

namespace Fastchannel.HttpClient.Bradesco.Operations
{
    internal abstract class OperationWithCallback<TResponse> : Operation<TResponse>
        where TResponse : ResponseBase, new()
    {
    }
}
