using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Vertis.BradescoClient.Attributes;

namespace Vertis.BradescoClient.Models.BradescoApi.Request
{
    [DataContract]
    public class Pedido
    {
        [DataMember(Name = "numero"), BradescoString(MaxLength = 27)]
        public virtual string Numero { get; set; }
        [DataMember(Name = "valor"), BradescoString(MaxLength = 13)]
        public virtual int Valor { get; set; }
        [DataMember(Name = "descricao"), BradescoString(MaxLength = 255)]
        public virtual string Descricao { get; set; }
    }
}
