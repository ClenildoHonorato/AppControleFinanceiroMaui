using AppControleFinanceiro.Enuns;
using LiteDB;

namespace AppControleFinanceiro.Models;

public class Transaction
{
    [BsonId]
    public int Id { get; set; }
    public string Name { get; set; }
    public TransactionType TransactionType { get; set; }
    public DateTimeOffset Date { get; set; }
    public decimal Value { get; set; }

}
