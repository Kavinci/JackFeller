using System;
using System.Collections.Generic;
using System.Text;

namespace JackFeller.Data
{
    [Serializable]
    public class Slot
    {
        public Slot() { }
        public Item ItemTemplate { get; private set; }
        public int ItemCount { get; private set; }
        public int Capacity { get; private set; }
        public int MaxCapacity { get; private set; }
        public void IncreaseCapacity()
        {
            if(Capacity < MaxCapacity)
            {
                Capacity++;
            }
        }
        private bool IncrementItemCount()
        {
            if(ItemCount < Capacity)
            {
                ItemCount++;
                return true;
            }
            return false;
        }
        public void AddItem()
        {
            IncrementItemCount();
        }
        private bool DecrementItemCount()
        {
            if(ItemCount > 0)
            {
                ItemCount--;
                return true;
            }
            return false;
        }
        public void RemoveItem()
        {

        }
    }
}
