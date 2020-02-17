using System;
using System.Collections.Generic;
using System.Text;

namespace JackFeller.Data
{
    [Serializable]
    public class Inventory
    {
        public Inventory(Item HealthPotion) 
        {
            HealthPotions = new Slot(HealthPotion, StartingCapacity, MaxCapacity);
        }
        public int StartingCapacity = 3;
        public int MaxCapacity = 5;
        public Slot HealthPotions { get; private set; }
    }
}
