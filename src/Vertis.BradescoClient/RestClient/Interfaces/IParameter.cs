using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vertis.BradescoClient.RestClient.Enumerators;

namespace Vertis.BradescoClient.RestClient.Interfaces
{
    public interface IParameter
    {
        string Name { get; set; }
        string Value { get; set; }
        ParameterType Type { get; set; }
    }
}
