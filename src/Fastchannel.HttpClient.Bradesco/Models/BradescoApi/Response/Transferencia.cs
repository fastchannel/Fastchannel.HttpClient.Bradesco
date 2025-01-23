using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Fastchannel.HttpClient.Bradesco.Models.BradescoApi.Response
{
    [DataContract]
    public class Transferencia
    {
        [DataMember(Name = "token")]
        public string Token { get; set; }
        [DataMember(Name = "url_acesso")]
        public string UrlAcesso { get; set; }
    }
}
