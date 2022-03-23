using Business;
using UseCases.DataStoresPluginInterfaces;

namespace Plugins.DataStore.InMemory;

public class CategoryInMemoryRepository : ICategoryRepository
{
    private List<Category> categories;

    public CategoryInMemoryRepository()
    {
        categories = new List<Category>
        {
            new Category {CategoryId = 1, Name = "Shoes", Description = "Shoes"},
            new Category {CategoryId = 2, Name = "Shorts", Description = "Shorts"},
            new Category {CategoryId = 3, Name = "Jacket", Description = "Jacket"}
        };
    }
    public IEnumerable<Category> GetCategories()
    {
        return categories;
    }
}