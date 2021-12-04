using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CalorieCounter.models;


namespace CalorieCounter.lib
{
    class Data
    {
        string conString;
        SqlConnection con;
        SqlCommand com;

        public void init()
        {
            conString = Properties.Settings.Default.SDB;
            con = new SqlConnection(connectionString: conString);
            con.Open();
        }

        public void SaveMeal(Meal meal)
        {
            Guid mealid = Guid.NewGuid();
            com.CommandText = "insert into meal (mealid, name, ts) values (@mealid,@name,@dateconsumed)";
            com.Parameters.AddWithValue("@mealid", mealid);
            com.Parameters.AddWithValue("@name", meal.Name);
            com.Parameters.AddWithValue("@dateconsumed", meal.DateTimeConsumed);
            com.Connection = con;
            com.ExecuteNonQuery();

            foreach (Food food in meal.FoodInMeal)
            {
                Guid foodid = Guid.NewGuid();
                com.CommandText = "insert into meal (meal_id,food_entry_id,name,food_type,servingsconsumed,proteinperserving,carbsperserving,fatperserving) values (@mealid,@foodid,@name,@foodtype,@servingsconsumed,@proteinperserving,@carbsperserving,@fatperserving)";
                com.Parameters.AddWithValue("@foodid", foodid);
                com.Parameters.AddWithValue("@mealid", mealid);
                com.Parameters.AddWithValue("@name", food.Name);
                com.Parameters.AddWithValue("@foodtype", food.FoodType);
                com.Parameters.AddWithValue("@servingsconsumed", food.ServingsConsumed);
                com.Parameters.AddWithValue("@proteinperserving", food.ProteinPerServing);
                com.Parameters.AddWithValue("@carbsperserving", food.CarbsPerServing);
                com.Parameters.AddWithValue("@fatperserving", food.FatPerServing);
                com.Connection = con;
                com.ExecuteNonQuery();
            }
        }

        public List<Meal> SearchMeal(DateTime start,DateTime end)
        {

            List<Meal> meals = new List<Meal>;
            com.CommandText = "select name,ts,meal_id from meal where ts >= @start and ts <= @end";
            com.Parameters.AddWithValue("@start", start);
            com.Parameters.AddWithValue("@end", end);
            com.Connection = con;
            SqlDataReader meal_results = com.ExecuteReader();

            while (meal_results.Read())
            {
                Meal meal = new Meal();
                meal.Name = (string) meal_results["Name"];
                meal.DateTimeConsumed = (DateTime) meal_results["DateTimeConsumed"];


                com.CommandText = "select meal_id,food_entry_id,name,food_type,calories,servingsconsumed,proteinperserving,carbsperserving,fatperserving from meal where meal_id = @mealid";
                com.Parameters.AddWithValue("@mealid", (string)meal_results["MealID"]);

                SqlDataReader food_results = com.ExecuteReader();
                while (food_results.Read)){
                    Food food = new Food();
                    food.Name = (string) food_results["Name"];
                    food.FoodType = (FoodType) food_results["FoodType"];
                    food.ServingsConsumed = (double) food_results["ServingsConsumed"];
                    food.ProteinPerServing = (double) food_results["ProteinPerServing"];
                    food.CarbsPerServing = (double) food_results["CarbsPerServing"];
                    food.FatPerServing = (double) food_results["FatPerServing"];

                    meal.FoodInMeal.Add(food);

                }

                meals.Add(meal);

            }

            return meals;
        }
    }
}
