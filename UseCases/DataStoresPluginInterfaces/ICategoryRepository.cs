using Business;

namespace UseCases.DataStoresPluginInterfaces;

public interface ICategoryRepository
{ 
    public IEnumerable<Category> GetCategories();
}