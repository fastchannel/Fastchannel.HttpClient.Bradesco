using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Vertis.BradescoClient.Models.BradescoApi.Response
{
    [DataContract]
    public class ResponseStatus
    {
        [DataMember(Name = "codigo")]
        public int Codigo { get; set; }

        [DataMember(Name = "mensagem")]
        public string Mensagem { get; set; }
    }
}
