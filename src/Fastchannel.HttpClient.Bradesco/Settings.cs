namespace Fastchannel.HttpClient.Bradesco
{
    public class Settings
    {
        public string BaseEndpoint { get; set; }

        public string MerchantId { get; set; }

        public string SecureKey { get; set; }

        public int? DefaultTimeoutInSeconds { get; set; }
    }
}
