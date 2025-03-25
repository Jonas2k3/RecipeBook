using System;
using System.Collections.Generic;

namespace RecipeBook
{
    public class Recipe
    {
        public string Name
        {
            get; set;
        }
        public string Description
        {
            get; set;
        }

        public string Type
        {
            get; set;
        }

        private List<string> ingredients;

        public Recipe(string name, string description, List<string> ingredients, string type)
        {
            Name = name;
            Description = description;
            this.ingredients = new List<string>(ingredients);
            Type = type;
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
    }
}
