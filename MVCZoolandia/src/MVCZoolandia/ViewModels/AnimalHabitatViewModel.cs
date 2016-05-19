using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCZoolandia.ViewModels
{
    public class AnimalHabitatViewModel
    {
        public List<AnimalViewModel> Animals { get; set; }
        public string AnimalName { get; set; }
        public string AnimalFood { get; set; }

    }
}
