using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Models.Repositories
{
    public class MasterSliderRepositorie : ISliderRepositorie
    {
        AppDbContext db;
        public MasterSliderRepositorie(AppDbContext _db)
        {
            db = _db;
        }
        public void Add(MasterSlider entity)
        {
            db.MasterSliders.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int id, MasterSlider entity)
        {
            var data = Find(id);
            data.IsDelete = 1;
            db.SaveChanges();
        }

        public MasterSlider Find(int id)
        {
            var data = db.MasterSliders.Find(id);
            return data;
        }

        public List<MasterSlider> FrontEndView()
        {
            var data = db.MasterSliders.Where(x => x.IsActive == true && x.IsDelete == 0).ToList();
            return data;
        }

        public void Update(int id, MasterSlider entity)
        {
            var data = db.Update(entity);
            db.SaveChanges();
        }
        public void Update_Active(int id, MasterSlider entity)
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

        public List<MasterSlider> View()
        {
            return db.MasterSliders.Where(x => x.IsDelete == 0).ToList();
        }
    }
}
