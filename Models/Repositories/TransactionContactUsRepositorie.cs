using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Models.Repositories
{
    public class TransactionContactUsRepositorie : ITransactionContactUsRepositorie
    {
        AppDbContext db;
        public TransactionContactUsRepositorie(AppDbContext _db)
        {
            db = _db;
        }
        public void Add(TransactionContactUs entity)
        {
            db.TransactionContactUs.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int id, TransactionContactUs entity)
        {
            var data = Find(id);
            data.IsDelete = 1;
            db.SaveChanges();
        }

        public TransactionContactUs Find(int id)
        {
            var data = db.TransactionContactUs.Find(id);
            return data;
        }

        public List<TransactionContactUs> FrontEndView()
        {
            var data = db.TransactionContactUs.Where(x => x.IsActive == true && x.IsDelete == 0).ToList();
            return data;
        }

        public void Update(int id, TransactionContactUs entity)
        {
            var data = db.Update(entity);
            db.SaveChanges();
        }
        public void Update_Active(int id, TransactionContactUs entity)
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

        public List<TransactionContactUs> View()
        {
            return db.TransactionContactUs.Where(x => x.IsDelete == 0).ToList();
        }
    }
}
