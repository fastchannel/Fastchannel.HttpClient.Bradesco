using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Vertis.BradescoClient.Models.BradescoApi.Request
{
    [DataContract]
    public class Pagador : Pessoa
    {
        [IgnoreDataMember]
        public virtual Enumerators.TipoDocumento TipoDocumento { get; set; }
        [DataMember(Name = "tipo_documento")]
        public virtual string TipoDocumentoFormatado { get => Convert.ToString((int)TipoDocumento); protected set { } }
    }
}
