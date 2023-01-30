using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Models.Repositories
{
    public interface IWorkingHourRepositorie
    {
        List<MasterWorkingHours> View();
        List<MasterWorkingHours> FrontEndView();
        void Add(MasterWorkingHours entity);
        void Update(int id, MasterWorkingHours entity);
        void Delete(int id, MasterWorkingHours entity);
        void Update_Active(int id, MasterWorkingHours entity);
        MasterWorkingHours Find(int id);
    }
}
