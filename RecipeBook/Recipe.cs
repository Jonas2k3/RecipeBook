using System;
using System.Collections.Generic;

namespace RecipeBook
{
    public class Recipe
    {
        public string name
        {
            get; set;
        }
        public string instructions
        {
            get; set;
        }

        public string type
        {
            get; set;
        }

        public List<string> ingredients;

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
    }
}
