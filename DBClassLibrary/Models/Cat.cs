using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class Cat
    {
        public int CatId { get; set; }
        public string CatKind { get; set; }
        public string CatPersonality { get; set; }
        public string CatFeature { get; set; }
        public string CatFocus { get; set; }
        public string CatFocusIssues { get; set; }
        public string CatHair { get; set; }
        public string CatPicture { get; set; }
    }
}
