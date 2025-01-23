using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Fastchannel.HttpClient.Bradesco.Models.BradescoApi.Response
{
    [DataContract]
    public class Pedido
    {
        [DataMember(Name = "numero")]
        public string Numero { get; set; }
        [DataMember(Name = "valor")]
        public int Valor { get; set; }
        [DataMember(Name = "descricao")]
        public string Descricao { get; set; }
    }
}
