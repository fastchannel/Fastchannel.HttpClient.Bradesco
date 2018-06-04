using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Vertis.BradescoClient.Models
{
    [DataContract]
    internal class ResponseLog
    {
        [DataMember]
        public string RequestedUrl { get; set; }
        [DataMember]
        public int StatusCode { get; set; }
        [DataMember]
        public string StatusCodeText { get; set; }
        [DataMember]
        public string BodyContent { get; set; }
    }
}
