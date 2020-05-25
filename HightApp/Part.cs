using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HightApp
{
    [Serializable]
    public class Part
    {
        public int PartId { get; set; }
        public string Mark { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public int Remains { get; set; }
        public float Prise { get; set; }
    }
}
