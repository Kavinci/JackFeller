using System;
using System.Collections.Generic;
using System.Text;

namespace JackFeller.Data
{
    [Serializable]
    public class Player
    {
        public Player(string gender) 
        {
            switch (gender)
            {
                case "male":
                    Gender = Gender.Male;
                    break;
                case "female":
                    Gender = Gender.Female;
                    break;
            }
        }
        public Gender Gender { get; private set; }
        public Inventory Inventory { get; private set; }
    }

    public enum Gender
    {
        Male,
        Female
    }
}
