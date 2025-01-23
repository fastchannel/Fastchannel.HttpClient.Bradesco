using Fastchannel.HttpClient.Bradesco.Models.Enumerators;
using System;
using System.Runtime.Serialization;
using Fastchannel.HttpClient.Bradesco.Attributes;

namespace Fastchannel.HttpClient.Bradesco.Models.BradescoApi.Request
{
    [DataContract]
    public class Boleto : BoletoBase
    {
        [DataMember(Name = "beneficiario"), BradescoString(MaxLength = 150)]
        public string Beneficiario { get; set; }

        [DataMember(Name = "url_logotipo"), BradescoString(MaxLength = 255)]
        public string UrlLogotipo { get; set; }

        [DataMember(Name = "mensagem_cabecalho"), BradescoString(MaxLength = 200)]
        public string MensagemCabecalho { get; set; }

        [IgnoreDataMember]
        public TipoRenderizacao TipoRenderizacao { get; set; }

        [DataMember(Name = "tipo_renderizacao")]
        internal string TipoRenderizacaoFormatado { get => Convert.ToString((int)TipoRenderizacao); private set { } }

        [DataMember(Name = "instrucoes")]
        public BoletoInstrucoes Instrucoes { get; set; }
    }
}
