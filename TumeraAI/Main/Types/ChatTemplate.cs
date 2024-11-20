using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TumeraAI.Main.Types
{
    public class ChatTemplate
    {
        public string Name { get; set; }
        public string SystemPrefix { get; set; }
        public string SystemSuffix { get; set; }
        public string AssistantPrefix  { get; set; }
        public string AssistantSuffix { get; set; }
        public string UserPrefix { get; set; }
        public string UserSuffix { get; set; }
    }
}
