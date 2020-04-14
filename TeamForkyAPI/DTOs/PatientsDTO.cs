using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamForkyAPI.Models;

namespace TeamForkyAPI.DTOs
{
    public class PatientsDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Birthday { get; set; }
        public string Status { get; set; }
        public DateTime CheckIn { get; set; }

        //Navigation Prop
        public List<PatientResources> PatientResources { get; set; }
    }

    public enum Status
    {
        stable = 0,
        unstable = 1,
        critical = 2,
        deceased = 3
    }
}
