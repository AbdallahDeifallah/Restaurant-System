using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Models.Repositories
{
    public class TransactionBookTableRepositorie : ITransactionBookTableRepositorie
    {
        AppDbContext db;
        public TransactionBookTableRepositorie(AppDbContext _db)
        {
            db = _db;
        }
        public void Add(TransactionBookTable entity)
        {
            db.TransactionBookTables.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int id, TransactionBookTable entity)
        {
            var data = Find(id);
            data.IsDelete = 1;
            db.SaveChanges();
        }

        public TransactionBookTable Find(int id)
        {
            var data = db.TransactionBookTables.Find(id);
            return data;
        }

        public List<TransactionBookTable> FrontEndView()
        {
            var data = db.TransactionBookTables.Where(x => x.IsActive == true&& x.IsDelete == 0).ToList();
            return data;
        }

        public void Update(int id, TransactionBookTable entity)
        {
            var data = db.Update(entity);
            db.SaveChanges();
        }
        public void Update_Active(int id, TransactionBookTable entity)
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

        public List<TransactionBookTable> View()
        {
            return db.TransactionBookTables.Where(x => x.IsDelete ==0).ToList();
        }
    }
}
