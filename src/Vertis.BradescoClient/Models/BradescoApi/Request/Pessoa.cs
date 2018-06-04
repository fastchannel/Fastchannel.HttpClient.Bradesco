using System.Runtime.Serialization;
using Vertis.BradescoClient.Attributes;

namespace Vertis.BradescoClient.Models.BradescoApi.Request
{
    [DataContract]
    public class Pessoa
    {
        [DataMember(Name = "nome"), BradescoString(MaxLength = 40)]
        public virtual string Nome { get; set; }

        [DataMember(Name = "documento"), BradescoString(MinLenght = 11, MaxLength = 14)]
        public virtual string Documento { get; set; }

        [DataMember(Name = "endereco")]
        public virtual Endereco Endereco { get; set; }
    }
}
