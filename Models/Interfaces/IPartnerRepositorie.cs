using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Models.Repositories
{
    public interface IPartnerRepositorie
    {
        List<MasterPartner> View();
        List<MasterPartner> FrontEndView();
        void Add(MasterPartner entity);
        void Update(int id, MasterPartner entity);
        void Delete(int id, MasterPartner entity);
        void Update_Active(int id, MasterPartner entity);


        MasterPartner Find(int id);
    }
}
