namespace SimApi.Data.Repository.Transaction;

public interface IEfTransactionRepository : IGenericRepository<TransactionView>
{
    List<TransactionView> GetByReferenceNumber(string referenceNumber);
    List<TransactionView> GetByCustomerId(int customerId);
    List<TransactionView> GetByAccountId(int accountId);
}
