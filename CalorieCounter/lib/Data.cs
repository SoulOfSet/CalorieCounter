using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CalorieCounter.models;

namespace CalorieCounter.lib
{
    class Data
    {
        string conString;
        SqlConnection con;
        SqlCommand com;
        SqlDataAdapter adapter = new SqlDataAdapter();

        public Data()
        {
            conString = Properties.Settings.Default.SDB;
            con = new SqlConnection(connectionString: conString);
        }

        public void SaveMeal(Meal meal)
        {
            
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
            con.Close();
        }

        public List<Meal> SearchMeal(DateTime start,DateTime end)
        {
            con.Open();
            List<Meal> meals = new List<Meal>();
            com = new SqlCommand();
            com.CommandText = "select name,ts,mealid from meals where ts >= @start and ts <= @end";
            com.Parameters.AddWithValue("@start", start);
            com.Parameters.AddWithValue("@end", end);
            com.Connection = con;
            SqlDataReader mealResults = com.ExecuteReader();

            while (mealResults.Read())
            {

                SqlConnection subCon = new SqlConnection(connectionString: conString);
                subCon.Open();

                Meal meal = new Meal();
                meal.Name = (string) mealResults["name"];
                meal.DateTimeConsumed = (DateTime) mealResults["ts"];

                com = new SqlCommand();
                com.CommandText = "select mealid, name, foodtype, servingsconsumed, proteinperserving, carbsperserving, fatperserving from food where mealid = @mealid";
                com.Parameters.AddWithValue("@mealid", (int)mealResults["mealid"]);
                com.Connection = subCon;

                SqlDataReader food_results = com.ExecuteReader();
  
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

                subCon.Close();

                meals.Add(meal);

            }
            con.Close();
            return meals;
        }
    }
}
