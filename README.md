# RecipeBook2

# Recipe App

## Description
This C# program is a simple recipe book application that allows users to enter recipe details, display individual recipes, display all recipes, and exit the application. Users can input the name of a recipe along with its ingredients, including their names, calories, and food groups.

## Usage
1. Run the program.
2. Upon launch, you will see a menu with the following options:
   - Enter recipe details: Allows you to input the name of a recipe and its ingredients.
   - Display a recipe: Lets you view the details of a specific recipe.
   - Display all the recipes: Shows a list of all recipes currently stored.
   - Exit: Terminates the application.
3. Choose an option by entering the corresponding number.
4. If you choose to enter recipe details, follow the prompts to input the name of the recipe, the number of ingredients, and details for each ingredient.
5. If you choose to display a recipe, enter the name of the recipe you want to view.
6. If you choose to display all recipes, a list of all entered recipes will be shown.
7. To exit the application, select the "Exit" option.

## Structure
- `Program.cs`: Contains the main logic of the recipe book application, including the menu system and user input handling.
- `RecipeBook.cs`: Defines the `RecipeBook` class responsible for managing recipes, including adding, displaying, and listing recipes.
- `Recipe.cs`: Defines the `Recipe` class representing a single recipe, along with methods for adding ingredients.
- `Ingredient.cs`: Defines the `Ingredient` class representing an ingredient, with properties for name, calories, and food group.

## Notes
- The program employs a simple console interface for interaction.
- Error handling for invalid inputs is minimal.
- Recipes and ingredients are stored in memory during runtime and are not persisted beyond the program's execution.

Feel free to extend or modify the code to suit your needs!
