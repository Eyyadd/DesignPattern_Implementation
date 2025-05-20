using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class PrintAdapter : IPrint
    {
        private readonly ThirdPartyPrintNewFeature _ThirdPartyPrintNewFeature;
        public PrintAdapter(ThirdPartyPrintNewFeature feature)
        {
            _ThirdPartyPrintNewFeature = feature;
        }
        public void Print(string Message)
        {
            _ThirdPartyPrintNewFeature.PrintTextNew(Message);
        }
    }
}
