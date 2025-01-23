using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Fastchannel.HttpClient.Bradesco.Models.BradescoApi.Response
{
    [DataContract]
    public class ResponseTef : ResponseBase
    {
        [DataMember(Name = "meio_pagamento")]
        public int MeioPagamento { get; set; }
        [DataMember(Name = "pedido")]
        public Pedido Pedido { get; set; }
        [DataMember(Name = "transferencia")]
        public Transferencia Transferencia { get; set; }
    }
}
