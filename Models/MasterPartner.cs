using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Restaurant.Models
{
    public partial class MasterPartner
    {
        public int MasterPartnerId { get; set; }
        [Display(Name ="Name")]
        [Required(ErrorMessage = "insert PartnerName")]
        public string MasterPartnerName { get; set; }
        [Display(Name = "Logo")]
        [Required(ErrorMessage = "insert LogoImageUrl")]

        public string MasterPartnerLogoImageUrl { get; set; }
        [Display(Name = "WebSite")]
        [Url]
        [Required(ErrorMessage = "insert PartnerWebsiteUrl")]
        public string MasterPartnerWebsiteUrl { get; set; }
        public int IsDelete { get; set; }
        public bool IsActive { get; set; }
        public string CreateId { get; set; }
        public string EditId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime EditDate { get; set; }
    }
}
