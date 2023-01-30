using Microsoft.AspNetCore.Http;
using Restaurant.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Areas.Admin.MVModels
{
    public class MVMasterSlider 
    {
        public int MasterSliderId { get; set; }
        [Display(Name = "Title")]
        [Required(ErrorMessage = "insert SliderTitle")]

        public string MasterSliderTitle { get; set; }
        [Display(Name = "Breef")]
        [Required(ErrorMessage = "insert SliderBreef")]

        public string MasterSliderBreef { get; set; }
        [Display(Name = "Desccription")]
        [Required(ErrorMessage = "insert SliderDesc")]

        public string MasterSliderDesc { get; set; }
        [Display(Name = "Image")]

        public string MasterSliderImageUrl { get; set; }
        [Required(ErrorMessage = "Select Image")]

        public int IsDelete { get; set; }
        public bool IsActive { get; set; }
        public string CreateId { get; set; }
        public string EditId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime EditDate { get; set; }
        public IFormFile File{ get; set; }
        public List<MasterSlider> MasterSliders{ get; set; }
        public MasterSlider MasterSlider{ get; set; }
    }
}
