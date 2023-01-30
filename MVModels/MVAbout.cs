using Restaurant.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.MVModels
{
    public class MVAbout : MV_Front
    {
        public List<MasterServices> MasterServices { get; set; }

    }
}
