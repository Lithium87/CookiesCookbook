namespace CookiesCookbook;

class Program
{
    static void Main(string[] args)
    {
        var cookiesRecipesApp = new CookiesRecipesApp(
            new RecipesRepository(),
            new RecipesConsoleUserInteraction(new IngredientsRegister()));
        cookiesRecipesApp.Run("recipes.txt");
    }
}