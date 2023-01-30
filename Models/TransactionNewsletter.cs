using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Restaurant.Models
{
    public partial class TransactionNewsletter
    {
        public int TransactionNewsletterId { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Transaction Newsletter Email")]
        [RegularExpression(@"^[\w-\.]+@([\w -]+\.)+[\w-]{2,4}$", ErrorMessage = "Not a valid Email Adress")]
        public string TransactionNewsletterEmail { get; set; }
        public int IsDelete { get; set; }
        public bool IsActive { get; set; }
        public string CreateId { get; set; }
        public string EditId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime EditDate { get; set; }
    }
}
