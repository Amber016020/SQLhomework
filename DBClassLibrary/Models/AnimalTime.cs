using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class AnimalTime
    {
        public int AnimalId { get; set; }
        public string AnimalOpendate { get; set; }
        public DateTime? AnimalCloseddate { get; set; }
        public DateTime? AnimalUpdate { get; set; }
        public DateTime? AnimalCreatetime { get; set; }
    }
}
