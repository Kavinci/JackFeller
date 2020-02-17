using System;
using System.Collections.Generic;
using System.Text;

namespace JackFeller.Data
{
    [Serializable]
    public class Slot
    {
        public Slot(Item item, int capacity, int maxCapacity) 
        {
            ItemTemplate = item;
            Count = 0;
            Capacity = capacity;
            MaxCapacity = maxCapacity;
        }
        public Item ItemTemplate { get; private set; }
        public int Count { get; private set; }
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
            if(Count < Capacity)
            {
                Count++;
                return true;
            }
            return false;
        }
        public bool AddItem()
        {
            return IncrementItemCount();
        }
        private bool DecrementItemCount()
        {
            if(Count > 0)
            {
                Count--;
                return true;
            }
            return false;
        }
        public bool RemoveItem()
        {
            return DecrementItemCount();
        }
    }
}
