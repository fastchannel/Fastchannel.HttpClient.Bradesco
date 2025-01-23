using Fastchannel.HttpClient.Bradesco.Attributes;
using System.Runtime.Serialization;

namespace Fastchannel.HttpClient.Bradesco.Models.BradescoApi.Request
{
    [DataContract]
    public class Comprador : Pessoa
    {
        [DataMember(Name = "ip"), BradescoString(MinLenght = 16, MaxLength = 50)]
        public virtual string Ip { get; set; }

        [DataMember(Name = "user_agent"), BradescoString(MaxLength = 255)]
        public virtual string UserAgent { get; set; }
    }
}
