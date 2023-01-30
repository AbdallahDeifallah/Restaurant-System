using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Models.Repositories
{
    public interface ITransactionContactUsRepositorie
    {
        List<TransactionContactUs> View();
        List<TransactionContactUs> FrontEndView();
        void Add(TransactionContactUs entity);
        void Update(int id, TransactionContactUs entity);
        void Delete(int id, TransactionContactUs entity);
        void Update_Active(int id, TransactionContactUs entity);
        TransactionContactUs Find(int id);
    }
}
