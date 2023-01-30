using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Models.Repositories
{
    public interface IServiceRepositorie
    {
        List<MasterServices> View();
        List<MasterServices> FrontEndView();
        void Add(MasterServices entity);
        void Update(int id, MasterServices entity);
        void Delete(int id, MasterServices entity);
        void Update_Active(int id, MasterServices entity);
        MasterServices Find(int id);
    }
}
