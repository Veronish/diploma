using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HightApp
{
    [Serializable]
    class JobAssignment
    {
        public int JobId { get; set; }
        public string Plase { get; set; }
        public int TechnicId { get; set; }
        public string DateAppointment { get; set; }        
        public int MasterId { get; set; }
        public int ExecutorId { get; set; }
    }
    
        
}
