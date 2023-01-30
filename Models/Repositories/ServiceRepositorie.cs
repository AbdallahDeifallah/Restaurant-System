using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Models.Repositories
{
    public class ServiceRepositorie : IServiceRepositorie
    {
        AppDbContext db;
        public ServiceRepositorie(AppDbContext _db)
        {
            db = _db;
        }
        public void Add(MasterServices entity)
        {
            db.MasterServices.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int id, MasterServices entity)
        {
            var data = Find(id);
            data.IsDelete = 1;
            db.SaveChanges();
        }

        public MasterServices Find(int id)
        {
            var data = db.MasterServices.Find(id);
            return data;
        }

        public List<MasterServices> FrontEndView()
        {
            var data = db.MasterServices.Where(x => x.IsActive == true && x.IsDelete == 0).ToList();
            return data;
        }

        public void Update(int id, MasterServices entity)
        {
            var data = db.Update(entity);
            db.SaveChanges();
        }
        public void Update_Active(int id, MasterServices entity)
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

        public List<MasterServices> View()
        {
            return db.MasterServices.Where(x => x.IsDelete == 0).ToList();
        }
    }
}
