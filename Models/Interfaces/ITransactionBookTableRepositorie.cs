using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Models.Repositories
{
    public interface ITransactionBookTableRepositorie
    {
        List<TransactionBookTable> View();
        List<TransactionBookTable> FrontEndView();
        void Add(TransactionBookTable entity);
        void Update(int id, TransactionBookTable entity);
        void Delete(int id, TransactionBookTable entity);
        void Update_Active(int id, TransactionBookTable entity);
        TransactionBookTable Find(int id);
    }
}
