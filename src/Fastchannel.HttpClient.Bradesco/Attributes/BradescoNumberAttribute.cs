using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fastchannel.HttpClient.Bradesco.Attributes
{
    public class BradescoIntAttribute : BradescoAttribute
    {
        public int MinValue { get; set; }
        public int MaxValue { get; set; }
    }
}
