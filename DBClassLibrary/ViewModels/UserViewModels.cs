using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace DBClassLibrary.ViewModels
{
    public class UserViewModels
    {
        [Key]
        public string UserName { get; set; }
        [Required]
        public int UserTel { get; set; }
        [Required]
        public string UserEmail { get; set; }
        [Required]
        public string UserAddress { get; set; }
    }
}
