using System;
using System.Runtime.Serialization;

namespace Vertis.BradescoClient.Models.BradescoApi.Response
{
    [DataContract]
    public class BoletoRegistrado
    {
        [DataMember(Name = "nosso_numero")]
        public string NossoNumero { get; set; }
        [DataMember(Name = "numero_documento")]
        public string NumeroDocumento { get; set; }
        [DataMember(Name = "data_requisicao")]
        internal string DataRequisicaoOriginal { get; set; }
        [IgnoreDataMember]
        public DateTime? DataRequisicao { get => DataRequisicaoOriginal.FromBradescoDateTimeString(); }
        [DataMember(Name = "data_registro")]
        internal string DataRegistroOriginal { get; set; }
        [IgnoreDataMember]
        public DateTime? DataRegistro { get => DataRegistroOriginal.FromBradescoDateTimeString(); }
    }
}
