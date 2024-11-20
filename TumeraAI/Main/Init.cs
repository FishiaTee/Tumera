using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TumeraAI.Main.Types;
using TumeraAI.Main.Utils;

namespace TumeraAI.Main
{
    internal class Init
    {
        public static void SetupChatTemplates()
        {
            RuntimeConfig.ChatTemplates.Add("ChatML", new ChatTemplate
            {
                Name = "chatml",
                SystemPrefix = "<|im_start|>system\n",
                SystemSuffix = "<|im_end|>\n",
                AssistantPrefix = "<|im_start|>assistant\n",
                AssistantSuffix = "<|im_end|>\n",
                UserPrefix = "<|im_start|>user\n",
                UserSuffix = "<|im_end|>\n",
            });
            RuntimeConfig.ChatTemplates.Add("Llama 3", new ChatTemplate
            {
                Name = "llama3-instruct",
                SystemPrefix = "<|start_header_id|>system<|end_header_id|>\n\n",
                SystemSuffix = "<|eot_id|>",
                AssistantPrefix = "<|start_header_id|>assistant<|end_header_id|>\n\n",
                AssistantSuffix = "<|eot_id|>",
                UserPrefix = "<|start_header_id|>user<|end_header_id|>\n\n",
                UserSuffix = "<|eot_id|>",
            });
            RuntimeConfig.ChatTemplates.Add("Alpaca", new ChatTemplate
            {
                Name = "alpaca",
                SystemPrefix = "",
                SystemSuffix = "\n\n",
                AssistantPrefix = "### Instruction:\n",
                AssistantSuffix = "\n\n",
                UserPrefix = "### Response:\n",
                UserSuffix = "\n\n",
            });
            RuntimeConfig.ChatTemplates.Add("Gemma", new ChatTemplate
            {
                Name = "gemma",
                SystemPrefix = "",
                SystemSuffix = "",
                AssistantPrefix = "<start_of_turn>model\n",
                AssistantSuffix = "<end_of_turn>",
                UserPrefix = "<start_of_turn>user\n",
                UserSuffix = "<end_of_turn>",
            });
            foreach (var i in RuntimeConfig.ChatTemplates)
            {
                RuntimeConfig.ChatTemplatesList.Add(i.Key);
            }
        }
    }
}
