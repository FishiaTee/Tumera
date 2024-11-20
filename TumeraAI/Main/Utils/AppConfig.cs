using System;
using System.IO;

namespace TumeraAI.Main.Utils
{
    internal class AppConfig
    {
        public static string AppName = "Tumera";
        public static string AppVersion = "0.2.0a1";
        public static string DefaultDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), $"{AppName}");
        public static string ChatPath = Path.Combine(DefaultDataPath, "chats");
        public static string PresetsPath = Path.Combine(DefaultDataPath, "presets");
        public static string ConfigFile = "config.json";
    }
}
