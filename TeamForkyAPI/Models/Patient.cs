using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamForkyAPI.Models
{
    public class Patient
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Birthday { get; set; }
        public int Status { get; set; }
        public DateTime CheckIn { get; set; }

        //Navigation Property; links to resources object
        public List<Resources> Resources { get; set; }
    }

    public enum Status
    {
        stable = 0,
        unstable = 1,
        critical = 2,
        deceased = 3
    }
}
