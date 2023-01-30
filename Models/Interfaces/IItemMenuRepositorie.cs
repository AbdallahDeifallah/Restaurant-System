using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Models.Repositories
{
    interface IItemMenuRepositorie
    {
        List<MasterItemMenu> View();
        List<MasterItemMenu> FrontEndView();
        void Add(MasterItemMenu entity);
        void Update(int id, MasterItemMenu entity);
        void Delete(int id, MasterItemMenu entity);
        void Update_Active(int id, MasterItemMenu entity);

        MasterItemMenu Find(int id);
    }
}
