using Microsoft.AspNetCore.Http;
using Restaurant.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Areas.Admin.MVModels
{
    public class MVMasterSocialMedia
    {
        public int MasterSocialMediaId { get; set; }
        [Display(Name = "Media Image")]
        public string MasterSocialMediaImageUrl { get; set; }
        [Display(Name = "Media Url")]
        public string MasterSocialMediaUrl { get; set; }
        public int IsDelete { get; set; }
        public bool IsActive { get; set; }
        public string CreateId { get; set; }
        public string EditId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime EditDate { get; set; }
        public IFormFile File { get; set; }
        public List<MasterSocialMedia> MastersSocialMedia { get; set; }
        public MasterSocialMedia MasterSocialMedia { get; set; }
    }
}
