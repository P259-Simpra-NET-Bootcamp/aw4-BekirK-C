using SimApi.Data.Context;
using System.Xml.Linq;

namespace SimApi.Data.Repository.Transaction;

public class EfTransactionRepository : GenericRepository<TransactionView>, IEfTransactionRepository
{
    public EfTransactionRepository(SimEfDbContext dbContext) : base(dbContext)
    {
    }

    public List<TransactionView> GetByAccountId(int accountId)
    {
        var list = dbContext.Set<TransactionView>().Where(c => c.AccountId == accountId).ToList();
        return list;
    }

    public List<TransactionView> GetByCustomerId(int customerId)
    {
        var list = dbContext.Set<TransactionView>().Where(c => c.CustomerId == customerId).ToList();
        return list;
    }

    public List<TransactionView> GetByReferenceNumber(string referenceNumber)
    {
        var list = dbContext.Set<TransactionView>().Where(c => c.ReferenceNumber == referenceNumber).ToList();
        return list;
    }
}
