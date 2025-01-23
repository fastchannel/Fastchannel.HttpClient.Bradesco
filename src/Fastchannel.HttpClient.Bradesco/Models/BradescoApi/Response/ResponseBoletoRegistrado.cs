using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Fastchannel.HttpClient.Bradesco.Models.BradescoApi.Response
{
    [DataContract]
    public class ResponseBoletoRegistrado : ResponseBase
    {
        [DataMember(Name = "boleto")]
        public BoletoRegistrado Boleto { get; set; }
    }
}
