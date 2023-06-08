using SimApi.Schema;

namespace SimApi.Operation.Dapper.Category;

public interface IDapperCategoryService
{
    List<CategoryResponse> GetAll();
    CategoryResponse GetById(int id);
    void Insert(CategoryRequest category);
    void Update(CategoryRequest category);
    void Delete(int Id);
}
