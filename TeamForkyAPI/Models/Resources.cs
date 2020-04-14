using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamForkyAPI.Models
{
    public class Resources
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ResourcesType ResourcesType { get; set; }

        public List<PatientResources> PatientResources { get; set; }
    }

    public enum ResourcesType
    {
        staff = 0,
        equipment = 1,
        room = 2
    }
}
