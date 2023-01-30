using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Models.Repositories
{
    public class MenuRepositorie : IMenuRepositorie
    {
        AppDbContext db;
        public MenuRepositorie(AppDbContext _db)
        {
            db = _db;
        }
        public void Add(MasterMenu entity)
        {
            db.MasterMenus.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int id, MasterMenu entity)
        {
            var data = Find(id);
            data.IsDelete = 1;
            db.SaveChanges();
        }

        public MasterMenu Find(int id)
        {
            var data = db.MasterMenus.Find(id);
            return data;
        }

        public List<MasterMenu> FrontEndView()
        {
            var data = db.MasterMenus.Where(x => x.IsActive == true && x.IsDelete == 0).ToList();
            return data;
        }

        public void Update(int id, MasterMenu entity)
        {
            var data = db.Update(entity);
            db.SaveChanges();
        }
        public void Update_Active(int id, MasterMenu entity)
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

        public List<MasterMenu> View()
        {
            return db.MasterMenus.Where(x => x.IsDelete == 0).ToList();
        }
    }
}
