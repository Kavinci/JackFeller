using System;
using System.Collections.Generic;
using System.Text;

namespace JackFeller.Data
{
    [Serializable]
    public class Item
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public float DPH { get; private set; }
        public float DPS { get; private set; }
        public float Duration { get; private set; }
        public float Radius { get; private set; }
    }
}
