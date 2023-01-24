using AppControleFinanceiro.Models;

namespace AppControleFinanceiro.Interface
{
    public interface ITransactionRepository
    {
        void Add(Transaction transaction);
        void Delete(Transaction transaction);
        Transaction Get(int id);
        List<Transaction> GetAll();
        void Update(Transaction transaction);
    }
}