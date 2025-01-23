using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Fastchannel.HttpClient.Bradesco.Models.Enumerators;

namespace Fastchannel.HttpClient.Bradesco.Models.BradescoApi.Request
{
    [DataContract]
    public class Pagador : Pessoa
    {
        [IgnoreDataMember]
        public virtual TipoDocumento TipoDocumento { get; set; }
        [DataMember(Name = "tipo_documento")]
        public virtual string TipoDocumentoFormatado { get => Convert.ToString((int)TipoDocumento); protected set { } }
    }
}
