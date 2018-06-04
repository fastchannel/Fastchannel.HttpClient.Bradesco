using System.Runtime.Serialization;
using Vertis.BradescoClient.RestClient.Enumerators;
using Vertis.BradescoClient.RestClient.Interfaces;

namespace Vertis.BradescoClient.RestClient.Models
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
