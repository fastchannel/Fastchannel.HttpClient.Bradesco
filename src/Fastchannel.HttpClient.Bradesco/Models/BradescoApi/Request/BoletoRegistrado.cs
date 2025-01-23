using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Fastchannel.HttpClient.Bradesco.Models.BradescoApi.Request
{
    [DataContract]
    public class BoletoRegistrado : BoletoBase
    {
        [DataMember(Name = "numero_documento")]
        public string NumeroDocumento { get; set; }

        [DataMember(Name = "informacoes_opcionais")]
        public InfosOpcionais InformacoesOpcionais { get; set; }

        [DataMember(Name = "pagador")]
        public Pagador Pagador { get; set; }
    }
}
