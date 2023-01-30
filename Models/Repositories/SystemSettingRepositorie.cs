using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Models.Repositories
{
    public class SystemSettingRepositorie : ISystemSettingRepositorie
    {
        AppDbContext db;
        public SystemSettingRepositorie(AppDbContext _db)
        {
            db = _db;
        }
        public void Add(SystemSetting entity)
        {
            db.SystemSettings.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int id, SystemSetting entity)
        {
            var data = Find(id);
            data.IsDelete = 1;
            db.SaveChanges();
        }

        public SystemSetting Find(int id)
        {
            var data = db.SystemSettings.Find(id);
            return data;
        }

        public List<SystemSetting> FrontEndView()
        {
            var data = db.SystemSettings.Where(x => x.IsActive == true && x.IsDelete == 0).ToList();
            return data;
        }

        public void Update(int id, SystemSetting entity)
        {
            var data = db.Update(entity);
            db.SaveChanges();
        }
        public void Update_Active(int id, SystemSetting entity)
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

        public List<SystemSetting> View()
        {
            return db.SystemSettings.Where(x => x.IsDelete == 0).ToList();
        }
    }
}
