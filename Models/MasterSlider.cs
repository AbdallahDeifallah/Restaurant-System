using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Restaurant.Models
{
    public partial class MasterSlider
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
        [Required(ErrorMessage ="Select Image")]

   
        public string MasterSliderImageUrl { get; set; }
        public int IsDelete { get; set; }
        public bool IsActive { get; set; }
        public string CreateId { get; set; }
        public string EditId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime EditDate { get; set; }
    }
}
