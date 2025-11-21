namespace CookiesCookbook;

class Program
{
    static void Main(string[] args)
    {
        var ingredientsRegister = new IngredientsRegister();
        var cookiesRecipesApp = new CookiesRecipesApp(
            new RecipesRepository(new StringsTextualRepository(), ingredientsRegister),
            new RecipesConsoleUserInteraction(ingredientsRegister));
        cookiesRecipesApp.Run("recipes.txt");
    }
}