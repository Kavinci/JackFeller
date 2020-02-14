using System;
using System.Collections.Generic;
using System.Text;

namespace JackFeller.Data
{
    [Serializable]
    public class Defaults
    {
        public static string FilePath = "./data.default";
        public string GameSavePath { get; private set; }
    }
}
