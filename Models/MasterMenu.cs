using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Restaurant.Models
{
    public partial class MasterMenu
    {
        public int MasterMenuId { get; set; }
        [Display(Name ="MenuName")]
        [Required(ErrorMessage = "insert MenuName")]
        public string MasterMenuName { get; set; }
        [Display(Name = "Url")]
        [Required(ErrorMessage = "insert MenuUrl")]

        public string MasterMenuUrl { get; set; }
        public int IsDelete { get; set; }
        public bool IsActive { get; set; }
        public string CreateId { get; set; }
        public string EditId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime EditDate { get; set; }
    }
}
