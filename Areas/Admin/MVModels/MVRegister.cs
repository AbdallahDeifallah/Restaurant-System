using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Areas.Admin.MVModels
{
    public class MVRegister : IdentityUser
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string PassWord { get; set; }
        [Required]
        [Compare("PassWord", ErrorMessage = "Password Not Confirm")]
        public String ComfirmPassword { get; set; }
        public string UserName { get; set; }
        public string User_image { get; set; }
        public IFormFile File { get; set; }


    }
}
