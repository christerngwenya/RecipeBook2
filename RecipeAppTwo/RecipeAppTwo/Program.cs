using System;
using System.Collections.Generic;
using System.Linq;


namespace RecipeApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            RecipeBook recipeBook = new RecipeBook();

            while (true)
            {
                Console.WriteLine("WELCOME TO RECIPE BOOK!!");
                Console.WriteLine("Choose an option");
                Console.WriteLine("1. Enter recipe details");
                Console.WriteLine("2. Display a recipe");
                Console.WriteLine("3. Display all the recipes");
                Console.WriteLine("4. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        recipeBook.EnterDetails();
                        break;
                    case 2:
                        recipeBook.DisplayRecipe();
                        break;
                    case 3:
                        recipeBook.AllRecipes();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }

    class RecipeBook
    {
        private List<Recipe> recipes = new List<Recipe>();

        public void EnterDetails()
        {
            Console.Write("Enter the name of the recipe: ");
            string recipeName = Console.ReadLine();
            Recipe recipe = new Recipe(recipeName);

            Console.Write("Enter the number of ingredients: ");
            int numIngre = int.Parse(Console.ReadLine());

            for (int i = 0; i < numIngre; i++)
            {
                Console.WriteLine($"Enter the details of ingredient #{i + 1}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Calories: ");
                int calories = int.Parse(Console.ReadLine());
                Console.Write("Food group: ");
                string foodGroup = Console.ReadLine();

                Ingredient ingredient = new Ingredient(name, calories, foodGroup);
                recipe.AddIngredient(ingredient);
            }

            recipes.Add(recipe);
            Console.WriteLine("You entered the details of the Recipe sucessfully:)");
        }

  
        public void DisplayRecipe()
        {
            Console.Write("Enter the recipe name: ");
            string nameRecipe = Console.ReadLine();
            Recipe recipe = recipes.FirstOrDefault(r => r.Name.Equals(nameRecipe, StringComparison.OrdinalIgnoreCase));

            if (recipe != null)
            {
                Console.WriteLine($"Recipe: {recipe.Name}");
                Console.WriteLine("Ingredients:");
                foreach (var ingredient in recipe.Ingredients)
                {
                    Console.WriteLine($"{ingredient.Name} ({ingredient.Calories} calories, {ingredient.FoodGroup})");
                }
            }
            else
            {
                Console.WriteLine($"Recipe '{nameRecipe}' not found.");
            }
        }

        public void AllRecipes()
        {
            if (recipes.Count == 0)
            {
                Console.WriteLine("There are no recipes T-T.");
                return;
            }

            Console.WriteLine("All Recipes:");
            foreach (var recipe in recipes)
            {
                Console.WriteLine(recipe.Name);
            }
        }

    }
    class Ingredient
    {
        public string Name { get; private set; }
        public int Calories { get; private set; }
        public string FoodGroup { get; private set; }

        public Ingredient(string name, int calories, string foodGroup)
        {
           Name = name;
            Calories = calories;
            FoodGroup = foodGroup;
        }
    }
    class Recipe
    {
        public string Name { get; private set; }
        public List<Ingredient> Ingredients { get; private set; } = new List<Ingredient>();

        public Recipe(string name)
        {
            Name = name;
        }

        public void AddIngredient(Ingredient ingredient)
        {
            Ingredients.Add(ingredient);
        }
    }

  
}