using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Models.Repositories
{
    public class OfferRepositorie : IOfferRepositorie
    {
        AppDbContext db;
        public OfferRepositorie(AppDbContext _db)
        {
            db = _db;
        }
        public void Add(MasterOffer entity)
        {
            db.MasterOffers.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int id, MasterOffer entity)
        {
            var data = Find(id);
            data.IsDelete = 1;
            db.SaveChanges();
        }

        public MasterOffer Find(int id)
        {
            var data = db.MasterOffers.Find(id);
            return data;
        }

        public List<MasterOffer> FrontEndView()
        {
            var data = db.MasterOffers.Where(x => x.IsActive == true && x.IsDelete == 0).ToList();
            return data;
        }

        public void Update(int id, MasterOffer entity)
        {
            var data = db.Update(entity);
            db.SaveChanges();
        }
        public void Update_Active(int id, MasterOffer entity)
        {
            var data = Find(id);
            if (data.IsActive == true)
            {
                data.IsActive = false;
            }
            else if (data.IsActive == false)

            {
                data.IsActive = true;
            }
            db.SaveChanges();
        }
        public List<MasterOffer> View()
        {
            return db.MasterOffers.Where(x => x.IsDelete==0).ToList();
        }
    }
}
