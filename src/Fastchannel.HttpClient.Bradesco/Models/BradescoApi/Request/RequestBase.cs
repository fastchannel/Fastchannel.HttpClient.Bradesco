using Fastchannel.HttpClient.Bradesco.Attributes;
using System.Runtime.Serialization;

namespace Fastchannel.HttpClient.Bradesco.Models.BradescoApi.Request
{
    [DataContract]
    public class RequestBase
    {
        [DataMember(Name = "merchant_id"), BradescoString(MinLenght = 9, MaxLength = 9)]
        internal virtual string MerchantId { get; set; }

        [IgnoreDataMember]
        public int? TimeoutInSeconds { get; set; }
    }
}
