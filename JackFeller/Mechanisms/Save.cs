using JackFeller.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using Xenko.Core.Diagnostics;

namespace JackFeller.Mechanisms
{
    public class Save
    {
        public Save(){}
        public bool Game(string filePath, GameState state)
        {
            if (File.Exists(filePath))
            {
                return Serialize(filePath, state);
            }
            return false;
        }
        public bool Defaults(Defaults defaults)
        {
            if (File.Exists(Data.Defaults.FilePath))
            {
                return Serialize(Data.Defaults.FilePath, defaults);
            }
            return false;
        }
        private static bool Serialize(string filePath, object state)
        {
            using (StreamWriter streamWriter = new StreamWriter(filePath))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                try
                {
                    binaryFormatter.Serialize(streamWriter.BaseStream, state);
                }
                catch (SerializationException ex)
                {
                    // Log this
                    // new SerializationException(ex.ToString() + "\n" + ex.Source));
                    return false;
                }
                return true;
            }
        }
    }
}
