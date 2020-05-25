using System;

namespace HightApp
{
    [Serializable]
    class Technic
    {
        public int TechnicId { get; set; }
        public string Mark { get; set; }
        public string Model { get; set; }
        public string Availability { get; set; }
        public string DateLastRepair { get; set; }
        public string Defect { get; set; }

        override
            public string ToString()
        {
            return TechnicId.ToString() + Mark + Model + Availability + DateLastRepair + Defect;
        }

    }
}
