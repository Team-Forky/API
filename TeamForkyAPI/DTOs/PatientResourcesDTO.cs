using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamForkyAPI.DTOs
{
    public class PatientResourcesDTO
    {
        //public int ID { get; set; }
        public int PatientID { get; set; }
        public int ResourcesID { get; set; }

        //Navigation Prop
        public ResourcesDTO Resources { get; set; }
        public PatientsDTO Patients { get; set; }
    }
}
