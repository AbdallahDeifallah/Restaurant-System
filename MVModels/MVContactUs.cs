using Restaurant.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.MVModels
{
    public class MVContactUs : MV_Front
    {
        public int TransactionContactUsId { get; set; }
        [Display(Name = "FullName ")]
        [Required(ErrorMessage = "Insert FullName")]

        public string TransactionContactUsFullName { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Insert Transaction ContactUs Email")]
        [RegularExpression(@"^[\w-\.]+@([\w -]+\.)+[\w-]{2,4}$", ErrorMessage = "Not a valid Email Adress")]
        public string TransactionContactUsEmail { get; set; }
        [Display(Name = "Subject")]
        [Required(ErrorMessage = "Insert Subject")]

        public string TransactionContactUsSubject { get; set; }
        [Display(Name = "Message ")]
        [Required(ErrorMessage = "Insert Message")]

        public string TransactionContactUsMessage { get; set; }

        public int IsDelete { get; set; }
        public bool IsActive { get; set; }
        public string CreateId { get; set; }
        public string EditId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime EditDate { get; set; }
    }
}
