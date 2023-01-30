using Restaurant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Areas.Admin.MVModels
{
    public class MVHome
    {
        public MasterItemMenu Item{ get; set; }
        public MasterSlider Slider{ get; set; }
        public TransactionBookTable bookTable{ get; set; }
        public MasterPartner Partner{ get; set; }
        public MasterServices Service{ get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public int Items { get; set; }
        public int Sliders { get; set; }
        public int bookTables { get; set; }
        public int Partners { get; set; }
        public int Services { get; set; }
        public int ContactUs { get; set; }

    }
}
