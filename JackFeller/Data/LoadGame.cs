using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace JackFeller.Data
{
    public class LoadGame
    {
        public LoadGame(string Path, string DefaultPath)
        {
            FilePath = Path;
        }
        private string FilePath { get; set; }
        private string DefaultFilePath { get; set; }
        public GameState Load(Guid Id)
        {
            var path = string.IsNullOrEmpty(FilePath) ? DefaultFilePath : FilePath;
            path = path + Id.ToString();

            try
            {
                Stream stream = File.Open(path, FileMode.Open);
                var binaryFormatter = new BinaryFormatter();
                return (GameState)binaryFormatter.Deserialize(stream);
            }
            catch
            {
                return null;
            }
        }
        //public GameState GetMostRecent() 
        //{
        //    // Get most recent save binary or return null
        //}
        //public List<GameState> GetAll() 
        //{
        //    // Get all the binary saves at that file path or retun empty list.
        //}
    }

    public enum LoadResponse
    {
        Success,
        LoadFailed,
        FileNotFound
    }
}
