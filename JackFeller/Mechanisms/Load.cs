using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using JackFeller.Data;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace JackFeller.Mechanisms
{
    public class Load
    {
        public async Task<GameState> Game(string filePath)
        {
            if (File.Exists(filePath))
            {
                return (GameState)Deserialize(filePath);
            }
            return null;
        }
        public async Task<Defaults> Defaults()
        {
            if (File.Exists(Data.Defaults.FilePath))
            {
                return (Defaults)Deserialize(Data.Defaults.FilePath);
            }
            return null;
        }
        private static object Deserialize(string filePath)
        {
            using (StreamReader streamReader = new StreamReader(filePath))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                object obj;
                try
                {
                    obj = binaryFormatter.Deserialize(streamReader.BaseStream);
                }
                catch (SerializationException ex)
                {
                    // Log this
                    // new SerializationException((ex).ToString() + "\n" + ex.Source);
                    return null;
                }
                return obj;
            }
        }
    }
}
