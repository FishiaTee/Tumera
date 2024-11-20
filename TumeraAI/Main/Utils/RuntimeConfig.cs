using System.Collections.Generic;
using TumeraAI.Main.Types;

namespace TumeraAI.Main.Utils
{
    class RuntimeConfig
    {
        public static string EndpointURL = "";
        public static string EndpointAPIKey = "";
        public static bool IsConnected = true;
        public static bool IsInferencing = false;
        public static Dictionary<string, ChatTemplate> ChatTemplates = new Dictionary<string, ChatTemplate>();
        public static List<string> ChatTemplatesList = new List<string>();
        public static int SelectedChatTemplate = 0;
        public static int InferenceAPI = 0;
        public static bool AutoGenerateTitles = true;
        public static bool StreamResponses = true;
    }
}
