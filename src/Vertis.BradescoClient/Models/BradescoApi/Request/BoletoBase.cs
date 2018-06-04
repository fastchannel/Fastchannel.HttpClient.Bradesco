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
    public class BoletoBase
    {
        /// <summary>
        /// Segundo a documentação do Bradesco é possível enviar apenas 25 ou 26
        /// </summary>
        [DataMember(Name = "carteira"), BradescoString(MinLenght = 1, MaxLength = 2)]
        public virtual string Carteira { get; set; }
        [DataMember(Name = "nosso_numero"), BradescoString(MinLenght = 11, MaxLength = 11, OnlyNumbers = true)]
        public virtual string NossoNumero { get; set; }
        [IgnoreDataMember]
        public virtual DateTime DataEmissao { get; set; }
        [DataMember(Name = "data_emissao")]
        internal virtual string DataEmissaoFormatada { get => DataEmissao.ToString(Constants.DATE_FORMAT); private set { } }
        [IgnoreDataMember]
        public virtual DateTime DataVencimento { get; set; }
        [DataMember(Name = "data_vencimento")]
        internal virtual string DataVencimentoFormatada { get => DataVencimento.ToString(Constants.DATE_FORMAT); private set { } }
        [DataMember(Name = "valor_titulo"), BradescoString(MinLenght = 1, MaxLength = 17)]
        public virtual int ValorTitulo { get; set; }
    }
}
