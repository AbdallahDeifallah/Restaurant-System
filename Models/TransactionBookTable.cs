using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Restaurant.Models
{
    public partial class TransactionBookTable
    {
        public int TransactionBookTableId { get; set; }
        [Display(Name = "Name")]
        [Required(ErrorMessage = "insert Transaction BookTable FullName")]
        public string TransactionBookTableFullName { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage = "insert Transaction BookTable Email")]
        [RegularExpression(@"^[\w-\.]+@([\w -]+\.)+[\w-]{2,4}$", ErrorMessage = "Not a valid Email Adress")]


    public string TransactionBookTableEmail { get; set; }
        [Display(Name = "MobileNumber")]
        [Required(ErrorMessage = "insert Transaction BookTable PhoneNumber")]
        [RegularExpression(@"^((079)|(078)|(077)){1}[0-9]{7}", ErrorMessage = "Not a valid phone number")]
        public string TransactionBookTableMobileNumber { get; set; }
        [Display(Name = "Date ")]
        [Required(ErrorMessage = "insert Transaction BookTable Date")]
        public DateTime? TransactionBookTableDate { get; set; }
        public int IsDelete { get; set; }
        public bool IsActive { get; set; }
        public string CreateId { get; set; }
        public string EditId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime EditDate { get; set; }
    }
}
