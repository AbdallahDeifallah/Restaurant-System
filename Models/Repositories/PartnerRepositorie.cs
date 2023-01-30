using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Models.Repositories
{
    public class PartnerRepositorie : IPartnerRepositorie
    {
        AppDbContext db;
        public PartnerRepositorie(AppDbContext _db)
        {
            db = _db;
        }
        public void Add(MasterPartner entity)
        {
            db.MasterPartners.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int id, MasterPartner entity)
        {
            var data = Find(id);
            data.IsDelete = 1;
            db.SaveChanges();
        }

        public MasterPartner Find(int id)
        {
            var data = db.MasterPartners.Find(id);
            return data;
        }

        public List<MasterPartner> FrontEndView()
        {
            var data = db.MasterPartners.Where(x => x.IsActive == true && x.IsDelete == 0).ToList();
            return data;
        }

        public void Update(int id, MasterPartner entity)
        {
            var data = db.Update(entity);
            db.SaveChanges();
        }
        public void Update_Active(int id, MasterPartner entity)
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
        public List<MasterPartner> View()
        {
            return db.MasterPartners.Where(x => x.IsDelete == 0).ToList();
        }
    }
}
