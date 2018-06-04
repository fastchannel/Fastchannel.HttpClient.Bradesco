using System.Runtime.Serialization;

namespace Vertis.BradescoClient.Models.BradescoApi.Request
{
    [DataContract]
    public class RequestBoletoRegistroStatus : RequestBase
    {
        [DataMember]
        public string NossoNumero { get; set; }
        [DataMember]
        public string NumeroDocumento { get; set; }
    }
}
