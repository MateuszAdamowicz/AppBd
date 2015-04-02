using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Security.Policy;
using Shop.Domain.Model.Category;
using Shop.Domain.Model.Category.Repository;

namespace Shop.Application.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _categoryRepository.FindAll();
        }

        public void CreateNewCategory(Category category)
        {
            _categoryRepository.Insert(category);
        }

        public Category FindCategoryById(int id)
        {
            return _categoryRepository.Find(id);
        }

        public void DeleteCategoryById(int id)
        {
            _categoryRepository.Delete(id);
        }
    }
}