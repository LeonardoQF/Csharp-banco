using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.model.dao
{
    internal interface ITransactionDao
    {
        void Insert(Transaction transaction);
        void FindById(int id);
        void DeleteById(int id);
        List<Transaction> FindAll();


    }
}
