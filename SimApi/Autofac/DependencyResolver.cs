using Autofac;
using SimApi.Data.Repository.CategoryDapper;
using SimApi.Data.Repository.Transaction;
using SimApi.Data.Repository;
using SimApi.Operation.Dapper.Category;
using SimApi.Operation;

namespace SimApi.Service.Autofac;

public class DependencyResolver : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<CategoryRepository>().As<ICategoryRepository>().SingleInstance();
        builder.RegisterType<ProductRepository>().As<IProductRepository>().SingleInstance();
        builder.RegisterType<UserRepository>().As<IUserRepository>().SingleInstance();
        builder.RegisterType<DapperCategoryRepository>().As<IDapperCategoryRepository>().SingleInstance();
        builder.RegisterType<EfTransactionRepository>().As<IEfTransactionRepository>().SingleInstance();
        builder.RegisterType<UserLogService>().As<IUserLogService>().SingleInstance();
        builder.RegisterType<TokenService>().As<ITokenService>().SingleInstance();
        builder.RegisterType<UserService>().As<IUserService>().SingleInstance();
        builder.RegisterType<CustomerService>().As<ICustomerService>().SingleInstance();
        builder.RegisterType<AccountService>().As<IAccountService>().SingleInstance();
        builder.RegisterType<TransactionService>().As<ITransactionService>().SingleInstance();
        builder.RegisterType<DapperCategoryService>().As<IDapperCategoryService>().SingleInstance();
        builder.RegisterType<TransactionReportService>().As<ITransactionReportService>().SingleInstance();
        builder.RegisterType<DapperAccountService>().As<IDapperAccountService>().SingleInstance();
    }
}
