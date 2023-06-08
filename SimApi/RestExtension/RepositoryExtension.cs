using SimApi.Data.Repository;
using SimApi.Data.Repository.CategoryDapper;
using SimApi.Data.Repository.Transaction;

namespace SimApi.Service.RestExtension;

public static class RepositoryExtension
{
    public static void AddRepositoryExtension(this IServiceCollection services)
    {
        //services.AddScoped<ICategoryRepository,CategoryRepository>();
        //services.AddScoped<IProductRepository,ProductRepository>();
        //services.AddScoped<IUserRepository, UserRepository>();
        //services.AddScoped<IDapperCategoryRepository, DapperCategoryRepository>();
        //services.AddScoped<IEfTransactionRepository, EfTransactionRepository>();
    }
}
