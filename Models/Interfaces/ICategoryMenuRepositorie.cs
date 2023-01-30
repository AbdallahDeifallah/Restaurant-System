using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Models.Repositories
{
     public  interface ICategoryMenuRepositorie
    {
        List<MasterCategoryMenu> View();
        List<MasterCategoryMenu> FrontEndView();
        void Add(MasterCategoryMenu entity);
        void Update(int id, MasterCategoryMenu entity);
        void Update_Active(int id, MasterCategoryMenu entity);
        void Delete(int id, MasterCategoryMenu entity);


        MasterCategoryMenu Find(int id);
    }
}
