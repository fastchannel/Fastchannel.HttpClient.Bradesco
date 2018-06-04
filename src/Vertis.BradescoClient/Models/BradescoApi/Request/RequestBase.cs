using System.Runtime.Serialization;
using Vertis.BradescoClient.Attributes;

namespace Vertis.BradescoClient.Models.BradescoApi.Request
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
