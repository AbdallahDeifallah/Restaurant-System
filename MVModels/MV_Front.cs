using Restaurant.Areas.Admin.Controllers;
using Restaurant.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.MVModels
{
    public class MV_Front
    {
        public List<MasterMenu> MasterMenu { get; set; }
        public SystemSetting SystemSetting { get; set; }
        public List<MasterSlider> MasterSliders{ get; set; }

        public List<MasterPartner> MasterPartner { get; set; }
        public List<MasterSocialMedia> MasterSocialMedia { get; set; }
        public List<MasterItemMenu> MasterItemMenu { get; set; }
        public List<MasterCategoryMenu> MasterCategoryMenu { get; set; }
        public List<MasterOffer> MasterOffer { get; set; }
        public string MasterOffer_img { get; set; }

        public List<MasterWorkingHours> MasterWorkingHours { get; set; }


        public int IsDelete { get; set; }
        public bool IsActive { get; set; }
        public string CreateId { get; set; }
        public string EditId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime EditDate { get; set; }
    }
}
