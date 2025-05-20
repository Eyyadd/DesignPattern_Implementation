using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class ThirdPartyPrintNewFeature
    {
        public void PrintTextNew(string Message)
        {
            Console.WriteLine($"Third Party Print {Message}");
        }
    }
}
