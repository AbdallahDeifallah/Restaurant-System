using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Restaurant.Models
{
    public partial class MasterServices
    {
        public int MasterServicesId { get; set; }
        [Display(Name ="Title")]
        [Required(ErrorMessage = "insert ServicesTitle")]
        public string MasterServicesTitle { get; set; }
        [Display(Name = "Desription")]
        [Required(ErrorMessage = "insert ServicesDesc")]
        public string MasterServicesDesc { get; set; }
        [Display(Name = "Image")]
        [Required(ErrorMessage = "insert ServicesImage")]
        public string MasterServicesImage { get; set; }
        [Display(Name = "Icon")]
        [Required(ErrorMessage = "insert ServicesIcon")]
        public string MasterServicesIcon { get; set; }
        public int IsDelete { get; set; }
        public bool IsActive { get; set; }
        public string CreateId { get; set; }
        public string EditId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime EditDate { get; set; }
    }
}
