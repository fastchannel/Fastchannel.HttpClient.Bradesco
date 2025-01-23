using Fastchannel.HttpClient.Bradesco.Attributes;
using Fastchannel.HttpClient.Bradesco.Models.Enumerators;
using System;
using System.Runtime.Serialization;

namespace Fastchannel.HttpClient.Bradesco.Models.BradescoApi.Request
{
    [DataContract]
    public class InfosOpcionais
    {
        public InfosOpcionais()
        {
            ControleParcicipante = string.Empty;
            Aceite = "S";
            TipoProtestoNegociacao = "1";
            QtdDiasProtesto = 0;
            TipoDecursoPrazo = "1";
            QtdDiasDecurso = 0;
            TipoEmissaoPapeleta = TipoEmissaoPapeleta.ClienteEmite;
            QtdParcelas = 0;
            PercentualJuros = 0;
            ValorJuros = 0;
            QtdDiasJuros = 0;
            PercentualMultaAtraso = 0;
            ValorMultaAtraso = 0;
            QtdDiasMultaAtraso = 0;
            PercentualDesconto1 = 0;
            ValorDesconto1 = 0;
            DataLimiteDesconto1 = null;
            PercentualDesconto2 = 0;
            ValorDesconto2 = 0;
            DataLimiteDesconto2 = null;
            PercentualDesconto3 = 0;
            ValorDesconto3 = 0;
            DataLimiteDesconto3 = null;
            TipoBonificacao = TipoBonificacao.Nenhum;
            PercentuaDescontolBonificacao = 0;
            ValorDescontoBonificacao = 0;
            DataLimiteDescontoBonificacao = null;
            SacadorAvalista = null;
        }

        private string _aceite = "S";
        private TipoEmissaoPapeleta _tipoPapeleta = TipoEmissaoPapeleta.ClienteEmite;

        /// <summary>
        /// Campo não utilizado no Comércio Eletrônico, o mesmo será desconsiderado. Utilizar: “00000”
        /// </summary>
        [DataMember(Name = "agencia_pagador")]
        public virtual string AgenciaPagador { get => "00000"; protected set { } }

        /// <summary>
        /// Campo não utilizado no Comércio Eletrônico, o mesmo será desconsiderado. Utilizar: “00000”
        /// </summary>
        [DataMember(Name = "razao_conta_pagador")]
        public virtual string RazaoContaPagador { get => "00000"; protected set { } }

        /// <summary>
        /// Campo não utilizado no Comércio Eletrônico, o mesmo será desconsiderado. Utilizar: “00000000”
        /// </summary>
        [DataMember(Name = "conta_pagador")]
        public virtual string ContaPagador { get => "00000000"; protected set { } }

        /// <summary>
        /// Nº Controle do Participante.  A informação que constar do Arquivo Remessa será confirmada no Arquivo Retorno, Não será impresso nos boletos de cobrança.
        /// Exemplo: Segurança arquivo remessa. Utilizar apenas letras/números sem acentuação ou caracteres especiais
        /// </summary>
        [DataMember(Name = "controle_participante"), BradescoString(MaxLength = 25)]
        public virtual string ControleParcicipante { get; set; }

        /// <summary>
        /// Espécie de Título.
        /// Utilizar: 99=Outros.
        /// </summary>
        [DataMember(Name = "especie")]
        public virtual string Especie { get => "99"; protected set { } }

        /// <summary>
        /// TODO: Entender melhor
        /// Valor padrão "S"
        /// </summary>
        [DataMember(Name = "aceite")]
        public virtual string Aceite { get => _aceite; set => _aceite = value; }

        /// <summary>
        /// Indicador de Instrução de Protesto
        /// </summary>
        [DataMember(Name = "tipo_protesto_negociacao"), BradescoString(MinLenght = 1, MaxLength = 1)]
        public virtual string TipoProtestoNegociacao { get; set; }

        /// <summary>
        /// Quantidade de dias para protesto
        /// </summary>
        [DataMember(Name = "qtde_dias_protesto"), BradescoInt(MinValue = 1, MaxValue = 99)]
        public virtual int QtdDiasProtesto { get; set; }

        /// <summary>
        /// TODO: Endender melhor
        /// </summary>
        [DataMember(Name = "tipo_decurso_prazo"), BradescoString(MinLenght = 1, MaxLength = 1)]
        public virtual string TipoDecursoPrazo { get; set; }

        /// <summary>
        /// Quantidade de dias para decurso de prazo
        /// </summary>
        [DataMember(Name = "qtde_dias_decurso"), BradescoInt(MinValue = 1, MaxValue = 99)]
        public virtual int QtdDiasDecurso { get; set; }

        /// <summary>
        /// Forma de emissão da papeleta.
        /// </summary>
        [IgnoreDataMember]
        public virtual TipoEmissaoPapeleta TipoEmissaoPapeleta { get => _tipoPapeleta; set => _tipoPapeleta = value; }

        /// <summary>
        /// Vide descrição da propriedade TipoEmissaoPapeleta
        /// </summary>
        [DataMember(Name = "tipo_emissao_papeleta")]
        internal virtual string TipoEmissaoPapeletaFormatado { get => Convert.ToString((int)TipoEmissaoPapeleta); private set { } }

        /// <summary>
        /// Quantidade de parcelas
        /// </summary>
        [DataMember(Name = "qtde_parcelas"), BradescoInt(MinValue = 0, MaxValue = 99)]
        public virtual int QtdParcelas { get; set; }

        /// <summary>
        /// Percentual de juros.
        /// Exemplo: 200, refere-se ao valor de 2,00%
        /// </summary>
        [DataMember(Name = "perc_juros"), BradescoInt(MinValue = 1, MaxValue = int.MaxValue)]
        public virtual int PercentualJuros { get; set; }

        /// <summary>
        /// Valor dos juros %
        /// </summary>
        [IgnoreDataMember]
        public virtual decimal ValorJuros { get; set; }

        [DataMember(Name = "valor_juros")]
        internal virtual string ValorJurosFormatado { get => ValorJuros.ToBradescoPercentFormat(); private set { } }

        /// <summary>
        /// Quantidade de dias para cobrança de juros 
        /// </summary>
        [DataMember(Name = "qtde_dias_juros"), BradescoInt(MinValue = 0, MaxValue = 99)]
        public virtual int QtdDiasJuros { get; set; }

        /// <summary>
        /// Percentual de juros.
        /// Exemplo: 200, refere-se ao valor de 2,00%
        /// </summary>
        [DataMember(Name = "perc_multa_atraso"), BradescoInt(MinValue = 1, MaxValue = int.MaxValue)]
        public virtual int PercentualMultaAtraso { get; set; }

        /// <summary>
        /// Valor da multa
        /// Exemplo: 200, refere-se ao valor de 2,00%.
        /// </summary>
        [DataMember(Name = "valor_multa_atraso")]
        public virtual int ValorMultaAtraso { get; set; }

        /// <summary>
        /// Quantidade de dias para cobrança de multa.
        /// </summary>
        [DataMember(Name = "qtde_dias_multa_atraso")]
        public virtual int QtdDiasMultaAtraso { get; set; }

        #region Desconto 1

        /// <summary>
        /// Percentual do primeiro desconto
        /// </summary>
        [IgnoreDataMember]
        public virtual decimal PercentualDesconto1 { get; set; }

        [DataMember(Name = "perc_desconto_1")]
        public virtual string Desconto1 { get => PercentualDesconto1.ToBradescoPercentFormat(); protected set { } }

        /// <summary>
        /// Valor do primeiro desconto
        /// Exemplo: 200, refere-se ao valor de 2,00%.
        /// </summary>
        [DataMember(Name = "valor_desconto_1")]
        public virtual int ValorDesconto1 { get; set; }

        /// <summary>
        /// Data limite para aplicação do primeiro desconto.
        /// </summary>
        public virtual DateTime? DataLimiteDesconto1 { get; set; }

        [DataMember(Name = "data_limite_desconto_1")]
        public virtual string DataLimiteDesconto1Formatada { get => DataLimiteDesconto1?.ToString(Constants.DATE_FORMAT); protected set { } }

        #endregion

        #region Desconto 2

        /// <summary>
        /// Percentual do segundo desconto
        /// </summary>
        [IgnoreDataMember]
        public virtual decimal PercentualDesconto2 { get; set; }

        [DataMember(Name = "perc_desconto_2")]
        public virtual string Desconto2 { get => PercentualDesconto2.ToBradescoPercentFormat(); protected set { } }

        /// <summary>
        /// Valor do segundo desconto
        /// Exemplo: 200, refere-se ao valor de 2,00%.
        /// </summary>
        [DataMember(Name = "valor_desconto_2")]
        public virtual int ValorDesconto2 { get; set; }

        /// <summary>
        /// Data limite para aplicação do segundo desconto.
        /// </summary>
        public virtual DateTime? DataLimiteDesconto2 { get; set; }

        [DataMember(Name = "data_limite_desconto_2")]
        public virtual string DataLimiteDesconto2Formatada { get => DataLimiteDesconto2?.ToString(Constants.DATE_FORMAT); protected set { } }

        #endregion

        #region Desconto 3

        /// <summary>
        /// Percentual do segundo desconto
        /// </summary>
        [IgnoreDataMember]
        public virtual decimal PercentualDesconto3 { get; set; }

        [DataMember(Name = "perc_desconto_3")]
        public virtual string Desconto3 { get => PercentualDesconto3.ToBradescoPercentFormat(); protected set { } }

        /// <summary>
        /// Valor do terceiro desconto
        /// Exemplo: 200, refere-se ao valor de 2,00%.
        /// </summary>
        [DataMember(Name = "valor_desconto_3")]
        public virtual int ValorDesconto3 { get; set; }

        /// <summary>
        /// Data limite para aplicação do terceiro desconto.
        /// </summary>
        public virtual DateTime? DataLimiteDesconto3 { get; set; }

        [DataMember(Name = "data_limite_desconto_3")]
        public virtual string DataLimiteDesconto3Formatada { get => DataLimiteDesconto3?.ToString(Constants.DATE_FORMAT); protected set { } }

        #endregion

        /// <summary>
        /// Bonificação concedido por antecipação de pagamento do título. 
        /// </summary>
        [IgnoreDataMember]
        public virtual TipoBonificacao TipoBonificacao { get; set; }

        #region Bonificacao

        /// <summary>
        /// Percentual do segundo desconto
        /// </summary>
        [IgnoreDataMember]
        public virtual decimal PercentuaDescontolBonificacao { get; set; }

        [DataMember(Name = "perc_desc_bonificacao")]
        public virtual string DescontoBonificacao { get => PercentuaDescontolBonificacao.ToBradescoPercentFormat(); protected set { } }

        /// <summary>
        /// Valor do terceiro desconto
        /// Exemplo: 200, refere-se ao valor de 2,00%.
        /// </summary>
        [DataMember(Name = "valor_desc_bonificacao")]
        public virtual int ValorDescontoBonificacao { get; set; }

        /// <summary>
        /// Data limite para aplicação do terceiro desconto.
        /// </summary>
        public virtual DateTime? DataLimiteDescontoBonificacao { get; set; }

        [DataMember(Name = "data_limite_desc_bonificacao")]
        public virtual string DataLimiteDescontoBonificacaoFormatada { get => DataLimiteDescontoBonificacao?.ToString(Constants.DATE_FORMAT); protected set { } }

        #endregion

        /// <summary>
        /// Campo não utilizado no Comércio Eletrônico, o mesmo será desconsiderado. Utilizar: "00". 
        /// </summary>
        [DataMember(Name = "valor_abatimento")]
        public virtual string ValorAbatimento { get => "00"; protected set { } }

        /// <summary>
        /// Campo não utilizado no Comércio Eletrônico, o mesmo será desconsiderado. Utilizar: "00". 
        /// </summary>
        [DataMember(Name = "valor_iof")]
        public virtual string ValorIof { get => "0"; protected set { } }

        /// <summary>
        /// Campo não utilizado no Comércio
        /// </summary>
        [DataMember(Name = "sequencia_registro")]
        public virtual string SequenciaRegistro { get; set; }

        [DataMember(Name = "sacador_avalista")]
        public virtual Pagador SacadorAvalista { get; set; }
    }
}
