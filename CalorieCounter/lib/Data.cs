using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CalorieCounter.models;

namespace CalorieCounter.lib
{
    /// <summary>
    /// Data access layer for meals and food
    /// </summary>
    class Data
    {
        private static readonly string conString = Properties.Settings.Default.SDB;

        public static void SaveMeal(Meal meal)
        {
            SqlConnection con = new SqlConnection(conString);
            SqlCommand com;
   
            //Open the connection
            con.Open();

            //Insert new meal
            com = new SqlCommand();
            com.CommandText = "insert into meals (name, ts) values (@name,@dateconsumed)";
            com.Parameters.AddWithValue("@name", meal.Name);
            com.Parameters.AddWithValue("@dateconsumed", meal.DateTimeConsumed);
            com.Connection = con;
            com.ExecuteNonQuery();

            //Get the ID for the new meal that was auto incremented
            com = new SqlCommand();
            com.CommandText = "select MAX(mealid) from meals;";
            com.Parameters.AddWithValue("@name", meal.Name);
            com.Parameters.AddWithValue("@dateconsumed", meal.DateTimeConsumed);
            com.Connection = con;
            int maxMealId = (int) com.ExecuteScalar();

            //For each food item, insert it with the meal id
            foreach (Food food in meal.FoodInMeal)
            {
                com = new SqlCommand();
                com.CommandText = "insert into food (mealid,name,foodtype,servingsconsumed,proteinperserving,carbsperserving,fatperserving) values (@mealid,@name,@foodtype,@servingsconsumed,@proteinperserving,@carbsperserving,@fatperserving)";
                com.Parameters.AddWithValue("@mealid", maxMealId);
                com.Parameters.AddWithValue("@name", food.Name);
                com.Parameters.AddWithValue("@foodtype", food.FoodType);
                com.Parameters.AddWithValue("@servingsconsumed", food.ServingsConsumed);
                com.Parameters.AddWithValue("@proteinperserving", food.ProteinPerServing);
                com.Parameters.AddWithValue("@carbsperserving", food.CarbsPerServing);
                com.Parameters.AddWithValue("@fatperserving", food.FatPerServing);
                com.Connection = con;
                com.ExecuteNonQuery();
            }

            //Close the connection
            con.Close();
        }

        public static List<Meal> SearchMeal(DateTime start,DateTime end)
        {
            SqlConnection con = new SqlConnection(conString);
            SqlCommand com;

            //Open the connection
            con.Open();

            //Prep the meal list
            List<Meal> meals = new List<Meal>();

            //Create the sql command
            com = new SqlCommand();
            com.CommandText = "select name,ts,mealid from meals where ts >= @start and ts <= @end";
            com.Parameters.AddWithValue("@start", start);
            com.Parameters.AddWithValue("@end", end);
            com.Connection = con;

            //Execute the select
            SqlDataReader mealResults = com.ExecuteReader();

            while (mealResults.Read())
            {
                //Create the sub connection
                SqlConnection subCon = new SqlConnection(connectionString: conString);
                subCon.Open();

                //Prep the meal
                Meal meal = new Meal();
                meal.Name = (string) mealResults["name"];
                meal.DateTimeConsumed = (DateTime) mealResults["ts"];

                //Create sql for getting the food in the meal
                com = new SqlCommand();
                com.CommandText = "select mealid, name, foodtype, servingsconsumed, proteinperserving, carbsperserving, fatperserving from food where mealid = @mealid";
                com.Parameters.AddWithValue("@mealid", (int)mealResults["mealid"]);
                com.Connection = subCon;

                //Execute the select
                SqlDataReader food_results = com.ExecuteReader();
  
                //Loop over the food rows and add them to your meal
                while (food_results.Read()){
                    Food food = new Food();
                    food.Name = (string) food_results["name"];
                    food.FoodType = (FoodType) food_results["foodtype"];
                    food.ServingsConsumed = (double)(decimal) food_results["servingsconsumed"];
                    food.ProteinPerServing = (double)(decimal) food_results["proteinperserving"];
                    food.CarbsPerServing = (double)(decimal) food_results["carbsperserving"];
                    food.FatPerServing = (double)(decimal) food_results["fatperserving"];
                    meal.FoodInMeal.Add(food);
                }

                //Close the sub connection
                subCon.Close();

                //Add to list of meals
                meals.Add(meal);

            }

            //Close the parent connection
            con.Close();

            return meals;
        }
    }
}
