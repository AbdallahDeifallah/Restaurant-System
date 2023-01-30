using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Models.Repositories
{
    public class WorkingHourRepositorie : IWorkingHourRepositorie
    {
        AppDbContext db;
        public WorkingHourRepositorie(AppDbContext _db)
        {
            db = _db;
        }
        public void Add(MasterWorkingHours entity)
        {
            db.MasterWorkingHours.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int id, MasterWorkingHours entity)
        {
            var data = Find(id);
            data.IsDelete = 1;
            db.SaveChanges();
        }

        public MasterWorkingHours Find(int id)
        {
            var data = db.MasterWorkingHours.Find(id);
            return data;
        }

        public List<MasterWorkingHours> FrontEndView()
        {
            var data = db.MasterWorkingHours.Where(x => x.IsActive == true && x.IsDelete == 0).ToList();
            return data;
        }

        public void Update(int id, MasterWorkingHours entity)
        {
            var data = db.Update(entity);
            db.SaveChanges();
        }
        public void Update_Active(int id, MasterWorkingHours entity)
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
        public List<MasterWorkingHours> View()
        {
            return db.MasterWorkingHours.Where(z => z.IsDelete == 0).ToList();
        }
    }
}
