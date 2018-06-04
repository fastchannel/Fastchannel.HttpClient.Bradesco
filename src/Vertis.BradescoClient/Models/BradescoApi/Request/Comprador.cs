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
    public class Comprador : Pessoa
    {
        [DataMember(Name = "ip"), BradescoString(MinLenght = 16, MaxLength = 50)]
        public virtual string Ip { get; set; }

        [DataMember(Name = "user_agent"), BradescoString(MaxLength = 255)]
        public virtual string UserAgent { get; set; }
    }
}
