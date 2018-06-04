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
