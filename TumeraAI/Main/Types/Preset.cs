using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TumeraAI.Main.Types
{
    class Preset
    {
        public string Name { get; set; }
        public ChatTemplate Template { get; set; }
        public string SystemPrompt { get; set; }
        public bool Jailbreak { get; set; }
        public bool ContextOptimization { get; set; }
    }
}
