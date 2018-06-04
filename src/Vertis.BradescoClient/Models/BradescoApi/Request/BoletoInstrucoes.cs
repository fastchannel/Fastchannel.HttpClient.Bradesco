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
    public class BoletoInstrucoes
    {
        [DataMember(Name = "instrucao_linha_1"), BradescoString(MaxLength = 60)]
        public string InstrucaoLinha1 { get; set; }

        [DataMember(Name = "instrucao_linha_2"), BradescoString(MaxLength = 60)]
        public string InstrucaoLinha2 { get; set; }

        [DataMember(Name = "instrucao_linha_3"), BradescoString(MaxLength = 60)]
        public string InstrucaoLinha3 { get; set; }

        [DataMember(Name = "instrucao_linha_4"), BradescoString(MaxLength = 60)]
        public string InstrucaoLinha4 { get; set; }

        [DataMember(Name = "instrucao_linha_5"), BradescoString(MaxLength = 60)]
        public string InstrucaoLinha5 { get; set; }

        [DataMember(Name = "instrucao_linha_6"), BradescoString(MaxLength = 60)]
        public string InstrucaoLinha6 { get; set; }

        [DataMember(Name = "instrucao_linha_7"), BradescoString(MaxLength = 60)]
        public string InstrucaoLinha7 { get; set; }

        [DataMember(Name = "instrucao_linha_8"), BradescoString(MaxLength = 60)]
        public string InstrucaoLinha8 { get; set; }

        [DataMember(Name = "instrucao_linha_9"), BradescoString(MaxLength = 60)]
        public string InstrucaoLinha9 { get; set; }

        [DataMember(Name = "instrucao_linha_10"), BradescoString(MaxLength = 60)]
        public string InstrucaoLinha10 { get; set; }

        [DataMember(Name = "instrucao_linha_11"), BradescoString(MaxLength = 60)]
        public string InstrucaoLinha11 { get; set; }

        [DataMember(Name = "instrucao_linha_12"), BradescoString(MaxLength = 60)]
        public string InstrucaoLinha12 { get; set; }
    }
}
