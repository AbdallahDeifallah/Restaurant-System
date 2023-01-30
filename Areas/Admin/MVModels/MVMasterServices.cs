using Microsoft.AspNetCore.Http;
using Restaurant.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Areas.Admin.MVModels
{
    public class MVMasterServices
    {
        public int MasterServicesId { get; set; }
        [Display(Name = "Title")]
        [Required(ErrorMessage = "Insert Title")]

        public string MasterServicesTitle { get; set; }
        [Display(Name = "Desription")]
        [Required(ErrorMessage = "Insert IDescritopn")]
        public string MasterServicesDesc { get; set; }
        [Display(Name = "Image")]
        [Required(ErrorMessage = "Insert Image")]
        public string MasterServicesImage { get; set; }
        [Display(Name = "Icon")]
        [Required(ErrorMessage = "Insert Icon")]
        public string MasterServicesIcon { get; set; }
        public int IsDelete { get; set; }
        public bool IsActive { get; set; }
        public string CreateId { get; set; }
        public string EditId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime EditDate { get; set; }
        public IFormFile File { get; set; }

        public List<MasterServices> MasterServices { get; set; }
        public MasterServices MasterService { get; set; }
    }
}
