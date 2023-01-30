using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Restaurant.Models
{
    public partial class MasterWorkingHours
    {
        public int MasterWorkingHoursId { get; set; }
        [Display(Name ="HourName")]
        [Required(ErrorMessage = "insert WorkingHoursName")]
        public string MasterWorkingHoursName { get; set; }
        [Display(Name = "HourTime")]
        [Required(ErrorMessage = "insert WorkingHoursTimeFormTo")]

        public string MasterWorkingHoursTimeFormTo { get; set; }
        public int IsDelete { get; set; }
        public bool IsActive { get; set; }
        public string CreateId { get; set; }
        public string EditId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime EditDate { get; set; }
    }
}
