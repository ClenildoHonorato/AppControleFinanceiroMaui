using AppControleFinanceiro.Interface;
using AppControleFinanceiro.Models;
using LiteDB;

namespace AppControleFinanceiro.Repositores;

public class TransactionRepository : ITransactionRepository
{
    private readonly LiteDatabase _database;
    private readonly string collectionName = "transactions";
    public TransactionRepository(LiteDatabase liteDatabase)
    {
        _database = liteDatabase;
    }

    public List<Transaction> GetAll()
    {
        var list = _database.GetCollection<Transaction>(collectionName).Query().OrderByDescending( o => o.Date).ToList();
        return list;
    }

    public Transaction Get(int id)
    {
        var transaction = _database.GetCollection<Transaction>(collectionName).Query().Where( t => t.Id == id).FirstOrDefault();
        return transaction;
    }

    public void Add(Transaction transaction)
    {
        var col = _database.GetCollection<Transaction>(collectionName);
        col.Insert(transaction);
        col.EnsureIndex(a => a.Date);
    }

    public void Update(Transaction transaction)
    {
        var col = _database.GetCollection<Transaction>(collectionName);
        col.Update(transaction);
    }

    public void Delete(Transaction transaction)
    {
        var col = _database.GetCollection<Transaction>(collectionName);
        col.Delete(transaction.Id);
    }
}
