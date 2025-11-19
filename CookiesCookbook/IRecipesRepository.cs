using CookiesCookbook.Recipes;

namespace CookiesCookbook;

public interface IRecipesRepository
{
    List<Recipe> Read(string filePath);
}