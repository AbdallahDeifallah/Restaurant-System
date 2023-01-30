using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Models.Repositories
{
    public class TransactionNewsletterRepositorie : ITransactionNewsletterRepositorie
    {
        AppDbContext db;
        public TransactionNewsletterRepositorie(AppDbContext _db)
        {
            db = _db;
        }
        public void Add(TransactionNewsletter entity)
        {
            db.TransactionNewsletters.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int id, TransactionNewsletter entity)
        {
            var data = Find(id);
            data.IsDelete = 1;
            db.SaveChanges();
        }

        public TransactionNewsletter Find(int id)
        {
            var data = db.TransactionNewsletters.Find(id);
            return data;
        }

        public List<TransactionNewsletter> FrontEndView()
        {
            var data = db.TransactionNewsletters.Where(x => x.IsActive == false && x.IsDelete == 0).ToList();
            return data;
        }

        public void Update(int id, TransactionNewsletter entity)
        {
            var data = db.Update(entity);
            db.SaveChanges();
        }
        public void Update_Active(int id, TransactionNewsletter entity)
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
        public List<TransactionNewsletter> View()
        {
            return db.TransactionNewsletters.Where(x => x.IsDelete == 0).ToList();
        }
    }
}
