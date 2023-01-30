using Microsoft.AspNetCore.Http;
using Restaurant.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Areas.Admin.MVModels
{
    public class MVMasterItemMenu
    {
        public int MasterItemMenuId { get; set; }
        public int MasterCategoryMenuId { get; set; }
        [Display(Name = "Category")]
        [Required(ErrorMessage = "Field is Required")]
        public MasterCategoryMenu MasterCategoryMenu { get; set; }
        [Display(Name = "Title")]
        [Required(ErrorMessage = "Field is Required")]
        public string MasterItemMenuTitle { get; set; }
        [Display(Name = "Breef")]
        [Required(ErrorMessage = "Field is Required")]
        public string MasterItemMenuBreef { get; set; }
        [Display(Name = "Descritopn")]
        [Required(ErrorMessage = "Field is Required")]
        public string MasterItemMenuDesc { get; set; }
        [Display(Name = "Price")]
        [Required(ErrorMessage = "Field is Required")]
        public double? MasterItemMenuPrice { get; set; }
        [Display(Name = "Image")]
        [Required(ErrorMessage = "Field is Required")]
        public string MasterItemMenuImageUrl { get; set; }
        [Display(Name = "Menu Date")]
        [Required(ErrorMessage = "Field is Required")]
        public DateTime MasterItemMenuDate { get; set; }
        public List<MasterCategoryMenu> Categorys { get; set; }
        [Required(ErrorMessage = "Field is Required")]
        public MasterCategoryMenu Category { get; set; }
        public IFormFile File { get; set; }
        public int IsDelete { get; set; }
        public bool IsActive { get; set; }
        public string CreateId { get; set; }
        public string EditId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime EditDate { get; set; }
    }
}
