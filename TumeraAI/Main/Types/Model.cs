using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TumeraAI.Main.Types
{
    public class Model
    {
        public string Name { get; set; }
        public string Identifier { get; set; }
        public bool SupportVision { get; set; }
        public bool SupportFunctionCalling { get; set; }
    }
}
