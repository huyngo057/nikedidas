using Business;

namespace UseCases.UseCaseInterfaces;

public interface IViewCategoriesUseCases
{
     IEnumerable<Category> Execute ();
}