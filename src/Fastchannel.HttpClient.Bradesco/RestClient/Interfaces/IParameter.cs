using Fastchannel.HttpClient.Bradesco.RestClient.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fastchannel.HttpClient.Bradesco.RestClient.Interfaces
{
    public interface IParameter
    {
        string Name { get; set; }
        string Value { get; set; }
        ParameterType Type { get; set; }
    }
}
