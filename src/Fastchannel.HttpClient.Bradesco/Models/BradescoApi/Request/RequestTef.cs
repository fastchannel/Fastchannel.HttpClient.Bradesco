using Fastchannel.HttpClient.Bradesco.Attributes;
using System.Runtime.Serialization;

namespace Fastchannel.HttpClient.Bradesco.Models.BradescoApi.Request
{
    [DataContract]
    public class RequestTef : RequestBase
    {
        /// <summary>
        /// Valor fixo 800
        /// </summary>
        [DataMember(Name = "meio_pagamento")]
        internal int MeioPagamento { get => 800; private set { } }

        [DataMember(Name = "pedido")]
        public Pedido DadosPedido { get; set; }

        [DataMember(Name = "comprador")]
        public Comprador DadosComprador { get; set; }

        [DataMember(Name = "token_request_confirmacao_pagamento"), BradescoString(MaxLength = 256)]
        public string TokenRequestConfirmacaoPagamento { get; set; }
    }
}
