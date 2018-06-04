using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vertis.BradescoClient.RestClient.Enumerators
{
    public enum ParameterType
    {
        Cookie = 1,
        RequestBody = 2,
        Header = 3,
        UrlSegment = 4,
        QueryString = 5
    }
}
