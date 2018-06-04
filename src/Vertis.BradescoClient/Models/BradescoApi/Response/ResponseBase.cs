using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Vertis.BradescoClient.Models.BradescoApi.Response
{
    [DataContract]
    public class ResponseBase
    {
        [DataMember(Name = "merchant_id")]
        internal string MerchantId { get; set; }

        [DataMember(Name = "status")]
        internal ResponseStatus Status { get; set; }
    }
}
