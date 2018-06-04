using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Vertis.BradescoClient.RestClient.Enumerators;
using Vertis.BradescoClient.RestClient.Models;

namespace Vertis.BradescoClient.RestClient
{
    internal class RestClient : IDisposable
    {
        private HttpClient _httpClient;
        private readonly string _baseEndpoint;
        private readonly int? _defaultTimeoutInSeconds;

        public static string AcceptsContentType { get; set; } = "application/json";

        private HttpClient HttpClient => _httpClient ?? (_httpClient = BuildHttpClient());

        public RestClient(string baseEndpoint, int? defaultTimeoutInSeconds)
        {
            if (string.IsNullOrWhiteSpace(baseEndpoint))
                throw new ArgumentException($"{ nameof(baseEndpoint) } is null or invalid");

            _baseEndpoint = baseEndpoint;
            _defaultTimeoutInSeconds = defaultTimeoutInSeconds;
        }

        public async Task<HttpResponseMessage> ExecuteAsync<T>(T request)
            where T : Request
        {
            return await HttpClient.SendAsync(CreateRequestMessage(request), CreateRequestTimeout(request))
                .ConfigureAwait(false);
        }

        public void Dispose()
        {
            _httpClient.Dispose();
        }

        private HttpClient BuildHttpClient()
        {
            var webHandler = new HttpClientHandler { UseCookies = false };
            _httpClient = new HttpClient(webHandler)
            {
                BaseAddress = new Uri(_baseEndpoint)
            };
            
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(AcceptsContentType));

            return _httpClient;
        }

        private HttpRequestMessage CreateRequestMessage(Request request)
        {
            var message = new HttpRequestMessage(request.Method, CreateResourceUri(request));

            foreach (var c in request.Parameters.Where(cookies => cookies.Type == ParameterType.Header))
                message.Headers.TryAddWithoutValidation(c.Name, Convert.ToString(c.Value));

            message.Content = CreateMessageContent(request);

            return message;
        }

        private StringContent CreateMessageContent(Request request)
        {
            var body = request
                        .Parameters
                        .ToList()
                        .Find(b => b.Type == ParameterType.RequestBody);

            return body != null ? new StringContent(Convert.ToString(body.Value), Encoding.UTF8, AcceptsContentType) : null;
        }

        private string CreateResourceUri(Request request)
        {
            var url = _baseEndpoint + request.Resource;

            if (request.Parameters.Any(x => x.Type.Equals(ParameterType.QueryString)))
                url = url + "?" + string.Join("&", request.Parameters.Where(p => p.Type.Equals(ParameterType.QueryString)).Select(p => $"{p.Name}={p.Value}"));

            return url;
        }

        private CancellationToken CreateRequestTimeout(Request request)
        {
            if (!_defaultTimeoutInSeconds.HasValue && request?.TimeoutInSeconds == null)
                return CancellationToken.None;

            var defaultTimeout = _defaultTimeoutInSeconds ?? default(int);
            var requestTimeout = request?.TimeoutInSeconds ?? default(int);
            var lowestTimeoutInSeconds = Math.Min(defaultTimeout, requestTimeout);
            return lowestTimeoutInSeconds > default(int)
                ? new CancellationTokenSource(TimeSpan.FromSeconds(lowestTimeoutInSeconds)).Token
                : CancellationToken.None;
        }
    }
}
