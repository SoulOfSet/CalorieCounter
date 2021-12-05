using System;
using System.Collections.Generic;
using System.Linq;

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
        /// Sum of calories for the meal
        /// </summary>
        public double GetTotalCalories()
        {
            return FoodInMeal.Sum(food => food.Calories);
        }

        /// <summary>
        /// Sum of protein for the meal
        /// </summary>
        public double GetTotalProtein()
        {
            return FoodInMeal.Sum(food => food.ProteinPerServing * food.ServingsConsumed);
        }

        /// <summary>
        /// Sum of carbs for the meal
        /// </summary>
        public double GetTotalCarbs()
        {
            return FoodInMeal.Sum(food => food.CarbsPerServing * food.ServingsConsumed);
        }

        /// <summary>
        /// Sum of fat for the meal
        /// </summary>
        public double GetTotalFat()
        {
            return FoodInMeal.Sum(food => food.FatPerServing * food.ServingsConsumed);
        }


        public double GetServingCountForFoodType(FoodType foodType)
        {
            return FoodInMeal.Where(food => food.FoodType == foodType).Sum(food => food.ServingsConsumed);
        }

    }
}
