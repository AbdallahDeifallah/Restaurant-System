using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Restaurant.Models
{
    public partial class SystemSetting
    {
        public int SystemSettingId { get; set; }
        [Display(Name ="White Logo")]
        [Required(ErrorMessage = "insert SystemSetting White Logo Image")]
        public string SystemSettingLogoImageUrl { get; set; }
        [Display(Name = "Black Logo")]
        [Required(ErrorMessage = "insert SystemSetting Black Logo Image")]
        public string SystemSettingLogoImageUrl2 { get; set; }
        [Required(ErrorMessage = "insert SystemSetting Copyright")]
        public string SystemSettingCopyright { get; set; }
        [Display(Name = "WelcomTitle")]
        [Required(ErrorMessage = "insert SystemSettin gWelcomeNoteTitle")]

        public string SystemSettingWelcomeNoteTitle { get; set; }
        [Display(Name = "WelcomeBreef")]
        [Required(ErrorMessage = "insert SystemSetting WelcomeNoteBreef")]

        public string SystemSettingWelcomeNoteBreef { get; set; }
        [Display(Name = "WelcomeDesc")]
        [Required(ErrorMessage = "insert SystemSetting WelcomeNoteDesc")]

        public string SystemSettingWelcomeNoteDesc { get; set; }
        [Display(Name = "NoteImage")]
        [Required(ErrorMessage = "insert SystemSetting WelcomeNoteUrl")]

        public string SystemSettingWelcomeNoteUrl { get; set; }
        [Display(Name = "WelcomeImg")]
        [Required(ErrorMessage = "insert SystemSetting WelcomeNoteImageUrl")]

        public string SystemSettingWelcomeNoteImageUrl { get; set; }
        [Display(Name = "Location")]
        [Required(ErrorMessage = "insert SystemSetting MapLocation")]

        public string SystemSettingMapLocation { get; set; }
        public int IsDelete { get; set; }
        public bool IsActive { get; set; }
        public string CreateId { get; set; }
        public string EditId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime EditDate { get; set; }
    }
}
