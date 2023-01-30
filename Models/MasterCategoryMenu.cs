using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Restaurant.Models
{
    public partial class MasterCategoryMenu
    {
      
        public int MasterCategoryMenuId { get; set; }
        [Display(Name = "Category Name")]
        [Required(ErrorMessage = "Insert CategoryMenuName ")]

        public string MasterCategoryMenuName { get; set; }

     
        
        public int IsDelete { get; set; }
        public bool IsActive { get; set; }
        public string CreateId { get; set; }
        public string EditId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime EditDate { get; set; }
    }
}
