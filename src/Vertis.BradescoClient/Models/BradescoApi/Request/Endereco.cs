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
    public class Endereco
    {
        [DataMember(Name = "cep"), BradescoString(MinLenght = 8, MaxLength = 8)]
        public virtual string Cep { get; set; }
        [DataMember(Name = "logradouro"), BradescoString(MaxLength = 70)]
        public virtual string Logradouro { get; set; }
        [DataMember(Name = "numero"), BradescoString(MaxLength = 10)]
        public virtual string Numero { get; set; }
        [DataMember(Name = "complemento"), BradescoString(MaxLength = 20)]
        public virtual string Complemento { get; set; }
        [DataMember(Name = "bairro"), BradescoString(MaxLength = 50)]
        public virtual string Bairro { get; set; }
        [DataMember(Name = "cidade"), BradescoString(MaxLength = 50)]
        public virtual string Cidade { get; set; }
        [DataMember(Name = "uf"), BradescoString(MinLenght = 2, MaxLength = 2)]
        public virtual string UF { get; set; }
    }
}
