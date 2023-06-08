using Microsoft.AspNetCore.Mvc;
using SimApi.Base;
using SimApi.Operation;
using SimApi.Operation.Dapper.Category;
using SimApi.Schema;

namespace SimApi.Service;

[Route("api/[controller]")]
[ApiController]
public class DapperCategoriesController : ControllerBase
{
    private readonly IDapperCategoryService _categoryService;

    public DapperCategoriesController(IDapperCategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    [HttpGet]
    public List<CategoryResponse> GetAll()
    {
        var categoryList = _categoryService.GetAll();
        return categoryList;
    }

    [HttpGet("{id}")]
    public CategoryResponse GetById(int id)
    {
        var category = _categoryService.GetById(id);
        return category;
    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {
        _categoryService.Delete(id);
    }

    [HttpPost]
    public void Add([FromBody] CategoryRequest request)
    {
        _categoryService.Insert(request);
    }

    [HttpPut]
    public void Update([FromBody] CategoryRequest request)
    {
        _categoryService.Update(request);
    }
}
