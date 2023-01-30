using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Models.Repositories
{
    public interface IOfferRepositorie
    {
        List<MasterOffer> View();
        List<MasterOffer> FrontEndView();
        void Add(MasterOffer entity);
        void Update(int id, MasterOffer entity);
        void Delete(int id, MasterOffer entity);
        void Update_Active(int id, MasterOffer entity);

        MasterOffer Find(int id);
    }
}
