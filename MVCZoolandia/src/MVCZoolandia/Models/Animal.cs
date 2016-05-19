using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCZoolandia.Models
{
    public class Animal
    {
        public int AnimalId { get; set; }
        public string Name { get; set; }
        public string Food { get; set; }
        public int HabitatId { get; set; }
    }
}
