using System.Collections;
using System.Collections.Generic;

namespace Shop.Domain.Model.Category.Repository
{
    public interface ICategoryRepository
    {
        void Insert(Category category);
        void Delete(int id);
        Category Find(int id);
        IEnumerable<Category> FindAll();
    }
}