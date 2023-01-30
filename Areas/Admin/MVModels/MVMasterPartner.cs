using Microsoft.AspNetCore.Http;
using Restaurant.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Areas.Admin.MVModels
{
    public class MVMasterPartner
    {
        public int MasterPartnerId { get; set; }
        [Display(Name = "Name")]
        public string MasterPartnerName { get; set; }
        [Display(Name = "Logo")]

        public string MasterPartnerLogoImageUrl { get; set; }
        public IFormFile File { get; set; }
        [Display(Name = "WebSite")]
        [Url]

        public string MasterPartnerWebsiteUrl { get; set; }
        public int IsDelete { get; set; }
        public bool IsActive { get; set; }
        public string CreateId { get; set; }
        public string EditId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime EditDate { get; set; }
        public List<MasterPartner>Parnters{ get; set; }
        public MasterPartner Parnter{ get; set; }
    }
}
