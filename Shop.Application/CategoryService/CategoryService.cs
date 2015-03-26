using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Shop.Domain.Model.Category;

namespace Shop.Application
{
    public class CategoryService : ICategoryService
    {
        private List<Category> _categories = new List<Category>();

        public IEnumerable<Category> GetAllCategories()
        {
            return _categories;
        }

        public void CreateNewCategory(Category category)
        {
            _categories.Add(category);
        }

        public Category FindCategoryById(int id)
        {
            var category = _categories.Single(x => x.Id == id);
            return category;
        }

        public void DeleteCategoryById(int id)
        {
            //todo Nie usuwać tylko oznaczać jako usunięte
            _categories.Remove(FindCategoryById(id));
        }
    }
}