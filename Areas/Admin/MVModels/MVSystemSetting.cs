using Microsoft.AspNetCore.Http;
using Restaurant.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Areas.Admin.MVModels
{
    public class MVSystemSetting
    {
        public int SystemSettingId { get; set; }
        [Display(Name = "White Logo")]
        [Required(ErrorMessage ="Field is Required")]
        public string SystemSettingLogoImageUrl { get; set; }
        [Display(Name = "Black Logo")]
        [Required(ErrorMessage = "Field is Required")]
        public string SystemSettingLogoImageUrl2 { get; set; }
        [Display(Name = "Copyright")]
        [Required(ErrorMessage = "Field is Required")]
        public string SystemSettingCopyright { get; set; }
        [Display(Name = "NoteTitle")]
        [Required(ErrorMessage = "Field is Required")]

        public string SystemSettingWelcomeNoteTitle { get; set; }
        [Display(Name = "NoteBreef")]
        [Required(ErrorMessage = "Field is Required")]

        public string SystemSettingWelcomeNoteBreef { get; set; }
        [Display(Name = "Descption")]
        [Required(ErrorMessage = "Field is Required")]

        public string SystemSettingWelcomeNoteDesc { get; set; }
        [Display(Name = "Welcome Url")]
        [Required(ErrorMessage = "Field is Required")]

        public string SystemSettingWelcomeNoteUrl { get; set; }
        [Display(Name = "WelcomeNote")]
        [Required(ErrorMessage = "Field is Required")]

        public string SystemSettingWelcomeNoteImageUrl { get; set; }
        [Display(Name = "Location")]
        [Required(ErrorMessage = "Field is Required")]

        public string SystemSettingMapLocation { get; set; }
        public int IsDelete { get; set; }
        public bool IsActive { get; set; }
        public string CreateId { get; set; }
        public string EditId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime EditDate { get; set; }
        [Display(Name = "White Logo")]

        public IFormFile File_logo1{ get; set; }
        [Display(Name = "Black Logo")]

        public IFormFile File_logo2{ get; set; }
        [Display(Name = "Welcome Image")]

        public IFormFile File_Welcome{ get; set; }
        public List<SystemSetting> SystemSettings{ get; set; }
        public SystemSetting SystemSessing{ get; set; }
    }
}
