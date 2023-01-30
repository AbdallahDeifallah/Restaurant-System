using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Models
{
    public class ApplicationUser: IdentityUser
    {
        [Display(Name ="NickName")]
        [Required]
        public string Dis_Name { get; set; }
        [Display(Name = "UserImage")]
        [Required]
        public string User_image{ get; set; }
    }
}
