using Business;
using UseCases.DataStoresPluginInterfaces;
using UseCases.UseCaseInterfaces;

namespace UseCases;

public class ViewCategoriesUseCases : IViewCategoriesUseCases
{
    private readonly ICategoryRepository _categoryRepository;

    public ViewCategoriesUseCases (ICategoryRepository categoryRepository)
    {
        this._categoryRepository = categoryRepository;
    }
    
    public IEnumerable<Category> Execute()
    {
        return _categoryRepository.GetCategories();
    }
}