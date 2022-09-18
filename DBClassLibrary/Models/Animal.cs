using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class Animal
    {
        public int AnimalId { get; set; }
        public string AnimalSubid { get; set; }
        public int AnimalShelterPkid { get; set; }
        public string AnimalKind { get; set; }
        public string AnimalStatus { get; set; }
        public DateTime? AnimalUpdate { get; set; }
        public string AlbumFile { get; set; }
        public string AnimalFoundplace { get; set; }
    }
}
