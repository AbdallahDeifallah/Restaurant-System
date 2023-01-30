using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Models.Repositories
{
   public  interface IMenuRepositorie
    {
        List<MasterMenu> View();
        List<MasterMenu> FrontEndView();
        void Add(MasterMenu entity);
        void Update(int id, MasterMenu entity);
        void Delete(int id, MasterMenu entity);
        void Update_Active(int id, MasterMenu entity);

        MasterMenu Find(int id);
    }
}
