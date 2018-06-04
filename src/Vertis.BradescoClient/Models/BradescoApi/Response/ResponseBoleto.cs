﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Vertis.BradescoClient.Models.BradescoApi.Response
{
    [DataContract]
    public class ResponseBoleto : ResponseBase
    {
        [DataMember]
        public int MeioPagamento { get; set; }
        [DataMember(Name = "pedido")]
        public Pedido Pedido { get; set; }
        [DataMember(Name = "boleto")]
        public Boleto Boleto { get; set; }
    }
}
