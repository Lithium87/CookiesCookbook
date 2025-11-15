namespace CookiesCookbook;

public class CookiesRecipesApp
{
    private readonly IRecipesRepository _recipesRepository;
    private readonly IRecipesUserInteraction _recipesUserInteraction;

    public CookiesRecipesApp(IRecipesRepository recipesRepository, IRecipesUserInteraction recipesUserInteraction)
    {
        _recipesRepository = recipesRepository;
        _recipesUserInteraction = recipesUserInteraction;
    }
    public void Run()
    {
        var allRecipes = _recipesRepository.Read(filePath);
        _recipesConsoleUserInteraction.PrintExistingRecipes(allRecipes);

        _recipesConsoleUserInteraction.PromptToCreateRecipe();

        var ingredients = _recipesConsoleUserInteraction.ReadIngredientsFromUser();

        if (ingredients.Count() > 0)
        {
            var recipes = new Recipe(ingredients);
            allRecipes.Add(recipe);
            _recipesRepository.Write(filePath, allRecipes);

            _recipesConsoleUserInteraction.ShowMessage("Recipe added:");
            _recipesConsoleUserInteraction.ShowMessage(recipe.ToString());
        }
        else
        {
            _recipesConsoleUserInteraction.ShowMessage("No ingredients have been selected. " + 
                                                "Recipe will not be saved");
        }

        _recipesConsoleUserInteraction.Exit();
    }
}