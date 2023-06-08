using AutoMapper;
using Serilog;
using SimApi.Base;
using SimApi.Data;
using SimApi.Data.Repository.Transaction;
using SimApi.Data.Uow;
using SimApi.Schema;
using static Dapper.SqlMapper;

namespace SimApi.Operation;

public class TransactionReportService : ITransactionReportService
{

    private readonly IUnitOfWork unitOfWork;
    private readonly IEfTransactionRepository _repository;
    private readonly IMapper mapper;

    public TransactionReportService(IUnitOfWork unitOfWork, IMapper mapper, IEfTransactionRepository repository)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
        _repository = repository;
    }

    public ApiResponse<List<TransactionViewResponse>> GetAll()
    {
        try
        {
            //var entityList = unitOfWork.DapperTransactionRepository.GetAll(); Dapper
            var entityList = unitOfWork.EfTransactionRepository.GetAll(); // EfCore
            var mapped = mapper.Map<List<TransactionView>, List<TransactionViewResponse>>(entityList);
            return new ApiResponse<List<TransactionViewResponse>>(mapped);
        }
        catch (Exception ex)
        {
            Log.Error(ex, "GetAll Exception");
            return new ApiResponse<List<TransactionViewResponse>>(ex.Message);
        }
    }

    public ApiResponse<List<TransactionViewResponse>> GetByAccountId(int accountId)
    {
        try
        {
            var entityList = unitOfWork.DapperTransactionRepository.GetByAccountId(accountId);
            var mapped = mapper.Map<List<TransactionView>, List<TransactionViewResponse>>(entityList);
            return new ApiResponse<List<TransactionViewResponse>>(mapped);
        }
        catch (Exception ex)
        {
            Log.Error(ex, "GetAll Exception");
            return new ApiResponse<List<TransactionViewResponse>>(ex.Message);
        }
    }

    public ApiResponse<List<TransactionViewResponse>> GetByCustomerId(int customerId)
    {
        try
        {
            //var entityList = unitOfWork.DapperTransactionRepository.GetByCustomerId(customerId); //Dapper
            var entityList = _repository.GetByCustomerId(customerId); // Efcore
            var mapped = mapper.Map<List<TransactionView>, List<TransactionViewResponse>>(entityList);
            return new ApiResponse<List<TransactionViewResponse>>(mapped);
        }
        catch (Exception ex)
        {
            Log.Error(ex, "GetAll Exception");
            return new ApiResponse<List<TransactionViewResponse>>(ex.Message);
        }
    }

    public ApiResponse<TransactionViewResponse> GetById(int id)
    {
        try
        {
            //var entity = unitOfWork.DapperTransactionRepository.GetById(id); Dapper
            var entity = unitOfWork.EfTransactionRepository.GetById(id); // Efcore
            var mapped = mapper.Map<TransactionView, TransactionViewResponse>(entity);
            return new ApiResponse<TransactionViewResponse>(mapped);
        }
        catch (Exception ex)
        {
            Log.Error(ex, "GetAll Exception");
            return new ApiResponse<TransactionViewResponse>(ex.Message);
        }
    }

    public ApiResponse<List<TransactionViewResponse>> GetByReferenceNumber(string referenceNumber)
    {

        try
        {
            //var entityList = unitOfWork.DapperTransactionRepository.GetByReferenceNumber(referenceNumber); //Dapper
            var entityList = _repository.GetByReferenceNumber(referenceNumber); // EfCore
            var mapped = mapper.Map<List<TransactionView>, List<TransactionViewResponse>>(entityList);
            return new ApiResponse<List<TransactionViewResponse>>(mapped);
        }
        catch (Exception ex)
        {
            Log.Error(ex, "GetAll Exception");
            return new ApiResponse<List<TransactionViewResponse>>(ex.Message);
        }
    }
}
