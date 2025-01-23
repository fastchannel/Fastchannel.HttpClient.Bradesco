using Fastchannel.HttpClient.Bradesco.RestClient.Enumerators;
using Fastchannel.HttpClient.Bradesco.RestClient.Interfaces;
using System.Runtime.Serialization;

namespace Fastchannel.HttpClient.Bradesco.RestClient.Models
{
    [DataContract]
    internal class Parameter : IParameter
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Value { get; set; }
        [IgnoreDataMember]
        public ParameterType Type { get; set; }
        [DataMember(Name = "ParameterType")]
        internal string TypeAsString { get => Type.ToString(); private set { } }
    }
}
