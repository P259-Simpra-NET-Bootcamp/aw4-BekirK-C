using AutoMapper;
using SimApi.Base;
using SimApi.Data;
using SimApi.Data.Uow;
using SimApi.Schema;
using SimApi.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimApi.Operation.Dapper.Category;

public class DapperCategoryService : IDapperCategoryService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public DapperCategoryService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public void Delete(int Id)
    {
        _unitOfWork.DapperCategoryRepository.DeleteById(Id);
    }

    public List<CategoryResponse> GetAll()
    {
        var entityList = _unitOfWork.DapperCategoryRepository.GetAll();
        var mapped = _mapper.Map<List<Data.Category>, List<CategoryResponse>>(entityList);
        return new List<CategoryResponse>(mapped);
    }

    public CategoryResponse GetById(int id)
    {
        var entity = _unitOfWork.DapperCategoryRepository.GetById(id);
        var mapped = _mapper.Map<Data.Category, CategoryResponse>(entity);
        return mapped;
    }

    public void Insert(CategoryRequest category)
    {
        var entity = _mapper.Map<CategoryRequest, Data.Category>(category);
        _unitOfWork.DapperCategoryRepository.Insert(entity);
    }

    public void Update(CategoryRequest category)
    {
        var entity = _mapper.Map<CategoryRequest, Data.Category>(category);
        _unitOfWork.DapperCategoryRepository.Update(entity);
    }
}
