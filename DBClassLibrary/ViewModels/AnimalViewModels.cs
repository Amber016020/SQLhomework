using DBClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBClassLibrary.ViewModels
{
    public class AnimalViewModels
    {
        public Animal animal { get; set; }
        public AnimalDetal animaldetal { get; set; }
        public AnimalPlace animalPlace { get; set; }
        public AnimalHeathe animalHeathe { get; set; }
        public AnimalTime animalTime { get; set; }
        public Shelter shelter { get; set; }
        public Area area { get; set; }
    }
}
