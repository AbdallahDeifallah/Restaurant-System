using Microsoft.AspNetCore.Http;
using Restaurant.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Areas.Admin.MVModels
{
    public class MVMasterCategoryMenu
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
        public List<MasterCategoryMenu> MasterCategorysMenu { get; set; }
        public MasterCategoryMenu MasterCategoryMenu { get; set; }
    }
}
