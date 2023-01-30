using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Models.Repositories
{
    public class CategoryMenuRepositorie : ICategoryMenuRepositorie
    {
        AppDbContext db;
        public CategoryMenuRepositorie(AppDbContext _db) {
            db = _db;
        }
        public void Add(MasterCategoryMenu entity)
        {
            db.MasterCategoryMenus.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int id, MasterCategoryMenu entity)
        {
            var data = Find(id);
            data.IsDelete = 1;
            db.SaveChanges();
        }

        public MasterCategoryMenu Find(int id)
        {
            var data = db.MasterCategoryMenus.Find(id);
            return data;
        }

        public List<MasterCategoryMenu> FrontEndView()
        {
            var data = db.MasterCategoryMenus.Where(x => x.IsActive == true && x.IsDelete == 0).ToList();
            return data;
        }

        public void Update(int id, MasterCategoryMenu entity)
        {
            var data = db.Update(entity);
            db.SaveChanges();
        }


        public void Update_Active(int id, MasterCategoryMenu entity)
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

        public List<MasterCategoryMenu> View()
        {
            return db.MasterCategoryMenus.Where(x => x.IsDelete == 0).ToList();
        }
    }
}
