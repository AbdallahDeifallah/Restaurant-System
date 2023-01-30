using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Restaurant.Models
{
    public partial class MasterItemMenu
    {
        public int MasterItemMenuId { get; set; }
        public int MasterCategoryMenuId { get; set; }
        [Display(Name = "Category")]
        [Required(ErrorMessage = "Select CategoryMenu ")]
        public MasterCategoryMenu MasterCategoryMenu { get; set; }
        [Display(Name="Title")]
        [Required(ErrorMessage = "Select ItemMenuTitle ")]

        public string MasterItemMenuTitle { get; set; }
        [Display(Name ="Breef")]
        [Required(ErrorMessage = "Select ItemMenuBreef ")]

        public string MasterItemMenuBreef { get; set; }
        [Display(Name ="Descritopn")]
        [Required(ErrorMessage = "Select ItemMenuDescritopn ")]

        public string MasterItemMenuDesc { get; set; }
        [Display(Name ="Price")]
        [Required(ErrorMessage = "Select ItemMenuPrice ")]

        public double? MasterItemMenuPrice { get; set; }
        [Display(Name ="Image")]
        [Required(ErrorMessage = "Select temMenuImage ")]

        public string MasterItemMenuImageUrl { get; set; }
        [Display(Name ="Menu Date")]
        [Required(ErrorMessage = "Select ItemMenuDate ")]

        public DateTime MasterItemMenuDate { get; set; }

        public int IsDelete { get; set; }
        public bool IsActive { get; set; }
        public string CreateId { get; set; }
        public string EditId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime EditDate { get; set; }
    }
}
