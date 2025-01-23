using System.Runtime.Serialization;

namespace Fastchannel.HttpClient.Bradesco.Models.BradescoApi.Request
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
