using System.Runtime.Serialization;
using Vertis.BradescoClient.Attributes;

namespace Vertis.BradescoClient.Models.BradescoApi.Request
{
    [DataContract, KnownType(typeof(RequestBoleto))]
    public class RequestBoleto : RequestBase
    {
        /// <summary>
        /// Segundo a documentação do Bradesco este valor é fixo
        /// </summary>
        [DataMember(Name = "meio_pagamento"), BradescoString(MinLenght = 3, MaxLength = 3)]
        internal int MeioPagamento { get => 300; private set { } }

        [DataMember(Name = "pedido")]
        public Pedido DadosPedido { get; set; }

        [DataMember(Name = "comprador")]
        public Comprador DadosComprador { get; set; }

        [DataMember(Name = "boleto")]
        public Boleto DadosBoleto { get; set; }

        [DataMember(Name = "token_request_confirmacao_pagamento"), BradescoString(MaxLength = 256)]
        public string TokenRequestConfirmacaoPagamento { get; set; }
    }
}
