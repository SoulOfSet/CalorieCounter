using System;
using System.Collections.Generic;

namespace CalorieCounter.models
{
    /// <summary>
    /// A list of food and when it was consumed
    /// </summary>
    public class Meal
    {
        public Meal()
        {
            FoodInMeal = new List<Food>();
        }

        public string Name { get; set; }
        public List<Food> FoodInMeal { get; set; }
        public DateTime DateTimeConsumed { get; set; }

        /// <summary>
        /// Property that sums the calories of all the food in the meal
        /// </summary>
        public double GetTotalCalories()
        {
            double totalCalories = 0;
            foreach (Food food in FoodInMeal)
            {
                totalCalories += food.Calories;
            }
            return totalCalories;
        }
    }
}
