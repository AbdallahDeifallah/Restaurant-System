using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Areas.Admin.MVModels
{
    public class MVLogin
    {
        [Required(ErrorMessage = "Email in Required")]
        [EmailAddress]
        public string email { get; set; }
        [Required(ErrorMessage ="Password in Required")]
        [DataType(DataType.Password)]

        public string PassWord { get; set; }
        public bool RememberMe { get; set; }
    }
}
