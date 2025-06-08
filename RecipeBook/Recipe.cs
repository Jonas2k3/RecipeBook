using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;

namespace RecipeBook
{
    public class Recipe
    {
        public string name { get; set; }
        public string instructions { get; set; }
        public string type { get; set; }
        public List<string> ingredients { get; set; } // Changed to property

        public Recipe(string name, string instructions, List<string> ingredients, string type)
        {
            this.name = name;
            this.instructions = instructions;
            this.ingredients = new List<string>(ingredients);
            this.type = type;
        }

        public void AddIngredient(string ingredient)
        {
            if (ingredients.Contains(ingredient))
            {
                throw new ArgumentException("Ingredient already exists!");
            }
            else
            {
                ingredients.Add(ingredient);
            }
        }

        public void RemoveIngredient(string ingredient)
        {
            if (!ingredients.Contains(ingredient))
            {
                throw new ArgumentException("This ingredient does not exist");
            }
            else
            {
                ingredients.Remove(ingredient);
            }
        }

        public void ChangeType(string type)
        {
            this.type = type;
        }

        public void ChangeName(string name)
        {
            this.name = name;
        }

        public void ChangeInstructions(string instructions)
        {
            this.instructions = instructions;
        }

        public override string ToString()
        {
            return name;
        }
    }

    public static class RecipeStorage
    {
        public static void SaveRecipes(string filePath, List<Recipe> recipes)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(recipes, options);
            File.WriteAllText(filePath, json);
        }

        public static List<Recipe> LoadRecipes(string filePath)
        {
            if (!File.Exists(filePath))
                return new List<Recipe>();

            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Recipe>>(json) ?? new List<Recipe>();
        }
    }
}
