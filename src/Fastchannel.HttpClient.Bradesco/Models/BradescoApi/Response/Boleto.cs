using Fastchannel.HttpClient.Bradesco;
using System;
using System.Runtime.Serialization;

namespace Fastchannel.HttpClient.Bradesco.Models.BradescoApi.Response
{
    [DataContract]
    public class Boleto
    {
        [DataMember(Name = "valor_titulo")]
        public int ValorTitulo { get; set; }
        [DataMember(Name = "data_geracao")]
        internal string DataGeracaoOriginal { get; set; }
        [IgnoreDataMember]
        public DateTime? DataGeracao { get => DataGeracaoOriginal.FromBradescoDateTimeString(); }
        [DataMember(Name = "data_atualizacao")]
        internal string DataAtualizacaoOriginal { get; set; }
        [IgnoreDataMember]
        public DateTime? DataAtualizacao { get => DataAtualizacaoOriginal.FromBradescoDateTimeString(); }
        [DataMember(Name = "linha_digitavel")]
        public string LinhaDigitavel { get; set; }
        [DataMember(Name = "linha_digitavel_formatada")]
        public string LinhaDigitavelFormatada { get; set; }
        [DataMember(Name = "token")]
        public string Token { get; set; }
        [DataMember(Name = "url_acesso")]
        public string UrlAcesso { get; set; }
    }
}
