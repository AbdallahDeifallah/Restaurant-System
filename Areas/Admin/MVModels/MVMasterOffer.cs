using Microsoft.AspNetCore.Http;
using Restaurant.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Areas.Admin.MVModels
{
    public class MVMasterOffer
    {
        public int MasterOfferId { get; set; }
        [Required]
        [Display(Name ="Title")]
        public string MasterOfferTitle { get; set; }
        [Required]
        [Display(Name = "Breef")]

        public string MasterOfferBreef { get; set; }
        [Required]
        [Display(Name = "Desc")]

        public string MasterOfferDesc { get; set; }
        [Required]

        [Display(Name = "Image")]
        public string MasterOfferImageUrl { get; set; }
        public int IsDelete { get; set; }
        public bool IsActive { get; set; }
        public string CreateId { get; set; }
        public string EditId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime EditDate { get; set; }
        public IFormFile File { get; set; }
        public List<MasterOffer> MasterOffers { get; set; }
        public MasterOffer MasterOffer { get; set; }
    }
}
