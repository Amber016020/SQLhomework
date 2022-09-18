using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class Shelter
    {
        public int ShelterPkid { get; set; }
        public string ShelterPlace { get; set; }
        public string ShelterAddress { get; set; }
        public int AreaPkid { get; set; }
        public string ShelterTel { get; set; }
    }
}
