using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Models.Repositories
{
    public class ItemMenuRepositorie : IItemMenuRepositorie
    {
        AppDbContext db;
        public ItemMenuRepositorie(AppDbContext _db)
        {
            db = _db;
        }
        public void Add(MasterItemMenu entity)
        {
            db.MasterItemMenus.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int id, MasterItemMenu entity)
        {
            var data = Find(id);
            data.IsDelete = 1;
            db.SaveChanges();
        }

        public MasterItemMenu Find(int id)
        {
            var data = db.MasterItemMenus.Include(category => category.MasterCategoryMenu).SingleOrDefault(x => x.MasterItemMenuId == id);
            return data;
        }

        public List<MasterItemMenu> FrontEndView()
        {
            var data = db.MasterItemMenus.Where(x => x.IsActive == true && x.IsDelete == 0).ToList();
            return data;
        }

        public void Update(int id, MasterItemMenu entity)
        {
            var data = db.Update(entity);
            db.SaveChanges();
        }
        public void Update_Active(int id, MasterItemMenu entity)
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

        public List<MasterItemMenu> View()
        {
            return db.MasterItemMenus.Include(category => category.MasterCategoryMenu).Where(x => x.IsDelete == 0).ToList();
        }
    }
}
