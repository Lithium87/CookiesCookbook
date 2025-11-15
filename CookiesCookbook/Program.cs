namespace CookiesCookbook;

class Program
{
    static void Main(string[] args)
    {
        var cookiesRecipesApp = new CookiesRecipesApp(
            new RecipesRepository(),
            new RecipesConsoleUserInteraction());
        cookiesRecipesApp.Run();
    }
}