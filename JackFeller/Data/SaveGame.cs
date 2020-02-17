using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace JackFeller.Data
{
    public class SaveGame
    {
        public SaveGame(string Path, string DefaultPath)
        {
            FilePath = Path;
            DefaultFilePath = DefaultPath;
        }
        private string FilePath { get; set; }
        private string DefaultFilePath { get; set; }
        public SaveResponse Save(GameState state) 
        {
            if (state == null) return SaveResponse.SaveFailed;

            var path = string.IsNullOrEmpty(FilePath) ? DefaultFilePath : FilePath;
            path = path + state.Id.ToString();

            try
            {
                Stream stream = File.Open(path, FileMode.OpenOrCreate);
                var binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(stream, state);
            }
            catch
            {
                return SaveResponse.SaveFailed;
            }
            return SaveResponse.Success;
        }
    }

    public enum SaveResponse
    {
        Success,
        SaveFailed
    }
}
