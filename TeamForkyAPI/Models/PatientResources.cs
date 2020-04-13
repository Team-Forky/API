using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamForkyAPI.Models
{
    public class PatientResources
    {
        public int ID { get; set; }
        public int PatientID { get; set; }
        public int ResourcesID { get; set; }

        //Navigation Prop
        public Patient Patient  { get; set; }
        public Resources Resources { get; set; }

    }
}
