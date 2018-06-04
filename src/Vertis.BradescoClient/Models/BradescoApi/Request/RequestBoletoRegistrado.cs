using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Vertis.BradescoClient.Models.BradescoApi.Request
{
    [DataContract]
    public class RequestBoletoRegistrado : RequestBase
    {
        [DataMember(Name = "boleto")]
        public BoletoRegistrado DadosBoleto { get; set; }
    }
}
