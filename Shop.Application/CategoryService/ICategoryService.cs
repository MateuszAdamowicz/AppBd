using System.Collections;
using System.Collections.Generic;
using Shop.Domain.Model.Category;

namespace Shop.Application
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetAllCategories();
        void CreateNewCategory(Category category);
    }
}