using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamForkyAPI.Models;

namespace TeamForkyAPI.DTOs
{
    public class ResourcesDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ResourcesType { get; set; }
    }
}
