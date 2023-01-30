using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Models.Repositories
{
    public interface ITransactionNewsletterRepositorie
    {
        List<TransactionNewsletter> View();
        List<TransactionNewsletter> FrontEndView();
        void Add(TransactionNewsletter entity);
        void Update(int id, TransactionNewsletter entity);
        void Delete(int id, TransactionNewsletter entity);
        void Update_Active(int id, TransactionNewsletter entity);
        TransactionNewsletter Find(int id);
    }
}
