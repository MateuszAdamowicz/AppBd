using System.Collections.Generic;
using System.Linq;
using Shop.Domain.Model.Category;
using Shop.Domain.Model.Category.Repository;

namespace Shop.Infrastructure.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private IList<Category> _categories;

        public CategoryRepository()
        {
            _categories = new List<Category>();
        }

        public void Insert(Category category)
        {
            _categories.Add(category);
        }

        public void Delete(int id)
        {
            _categories.Remove(Find(id));
        }

        public Category Find(int id)
        {
            var result = _categories.Single(x => x.Id == id);
            return result;
        }

        public IEnumerable<Category> FindAll()
        {
            return _categories;
        }
    }   
}