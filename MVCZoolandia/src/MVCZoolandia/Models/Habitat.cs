using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCZoolandia.Models
{
    public class Habitat
    {
        public int HabitatId { get; set; }
        public string Size { get; set; }
        public double Temperature { get; set; }
        public string Type { get; set; }
    }
}
