using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteDBHandler.Models
{
    class Ship
    {
        public int TypeID;
        public float BasePrice;
        public float Capacity;
        public Dictionary<string, string> Description;
        public int FactionID;
        public int GraphicID;
        public int GroupID;
        public int MarketGroupID;
        public float Mass;
        public int MetaGroupID;
        public Dictionary<string, string> Name;
        public int PortionSize;
        public float Published;
        public int RaceID;
        public float Radius;
        public string SoftFactionName;
        public int SoundID;
        public int Volume;
    }
}
