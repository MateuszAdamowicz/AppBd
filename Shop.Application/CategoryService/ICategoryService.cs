using System.Collections.Generic;
using Shop.Domain.Model.Category;

namespace Shop.Application.CategoryService
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetAllCategories();
        void CreateNewCategory(Category category);
        Category FindCategoryById(int id);
        void DeleteCategoryById(int id);
    }
}