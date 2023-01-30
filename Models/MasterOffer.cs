using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Restaurant.Models
{
    public partial class MasterOffer
    {
        public int MasterOfferId { get; set; }
        [Required(ErrorMessage = "insert OfferTitle")]
        [Display(Name = "Title")]
        public string MasterOfferTitle { get; set; }
        [Required(ErrorMessage = "insert OfferBreef")]
        [Display(Name = "Breef")]

        public string MasterOfferBreef { get; set; }
        [Required(ErrorMessage = "insert OfferDesc")]
        [Display(Name = "Desc")]

        public string MasterOfferDesc { get; set; }
        [Required(ErrorMessage = "insert OfferImage")]

        [Display(Name = "Image")]
        public string MasterOfferImageUrl { get; set; }
        public int IsDelete { get; set; }
        public bool IsActive { get; set; }
        public string CreateId { get; set; }
        public string EditId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime EditDate { get; set; }
    }
}
