using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Restaurant.Models
{
    public partial class MasterSocialMedia
    {
        public int MasterSocialMediaId { get; set; }
        [Display(Name = "Media Image")]
        [Required(ErrorMessage = "Insert SocialMediaImageUrl")]
        public string MasterSocialMediaImageUrl { get; set; }
        [Display(Name = "Media Url")]
        [Required(ErrorMessage = "Insert SocialMediaUrl")]
        public string MasterSocialMediaUrl { get; set; }
        public int IsDelete { get; set; }
        public bool IsActive { get; set; }
        public string CreateId { get; set; }
        public string EditId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime EditDate { get; set; }
    }
}
