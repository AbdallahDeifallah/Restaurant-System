using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Models.Repositories
{
    public class SocialMediuauRepositorie : ISocialMediuauRepositorie
    {
        AppDbContext db;
        public SocialMediuauRepositorie(AppDbContext _db)
        {
            db = _db;
        }
        public void Add(MasterSocialMedia entity)
        {
            db.MasterSocialMedia.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int id, MasterSocialMedia entity)
        {
            var data = Find(id);
            data.IsDelete = 1; ;
            db.SaveChanges();
        }

        public MasterSocialMedia Find(int id)
        {
            var data = db.MasterSocialMedia.Find(id);
            return data;
        }

        public List<MasterSocialMedia> FrontEndView()
        {
            var data = db.MasterSocialMedia.Where(x => x.IsActive == true && x.IsDelete == 0).ToList();
            return data;
        }

        public void Update(int id, MasterSocialMedia entity)
        {
            var data = db.Update(entity);
            db.SaveChanges();
        }
        public void Update_Active(int id, MasterSocialMedia entity)
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

        public List<MasterSocialMedia> View()
        {
            return db.MasterSocialMedia.Where(x => x.IsDelete == 0).ToList();
        }
    }
}
