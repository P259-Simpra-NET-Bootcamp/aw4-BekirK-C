using SimApi.Data.Context;

namespace SimApi.Data.Repository.CategoryDapper;

public class DapperCategoryRepository : DapperRepository<Category>, IDapperCategoryRepository
{
    public DapperCategoryRepository(SimDapperDbContext dbContext) : base(dbContext)
    {
    }
}
