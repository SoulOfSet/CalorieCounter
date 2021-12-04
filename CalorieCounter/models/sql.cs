using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace CalorieCounter.models
{

    class sql
    {

        private string _dataSource = @"c:\temp\cc.db";
        private SQLiteConnection _connection;
        private SQLiteCommand _command;

        public models.sql init()
        {


            if (File.Exists(_dataSource))
            {
                _connection = new SQLiteConnection("Data source =" + _dataSource);
                _connection.Open();
                _command = new SQLiteCommand();
            } else
            {
                SQLiteConnection.CreateFile(_dataSource);
                _connection = new SQLiteConnection("Data source =" + _dataSource);
                _connection.Open();
                _command = new SQLiteCommand();
                createTables();
            };


            return this;
            }


        private void createTables()
        {
            _command.Connection = _connection;
            _command.CommandText = "create table meal(meal_id varchar2(36) not null ,name VARCHAR(250) NOT NULL,ts INTEGER);create table foodentry(meal_id integer,food_entry_id INTEGER NOT NULL PRIMARY KEY,name varchar(250) not null,food_type integer not null,calories real,servingsconsumed real,proteinperserving real,carbsperserving real,fatperserving real); ";

            try
            {
                _command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
        }


        public void SaveMeal(Meal meal)
        {

            Guid mealid = Guid.NewGuid();
            _command.CommandText = "insert into meal (meal_id, name, ts) values ('" + mealid + "','" + meal.Name + "','" + meal.DateTimeConsumed.Ticks + "')";
            _command.ExecuteNonQuery();

            foreach (Food food in meal.FoodInMeal)
            {
                Guid food_entry_id = Guid.NewGuid();
                _command.CommandText = "insert into meal (meal_id,food_entry_id,name,food_type,calories,servingsconsumed,proteinperserving,carbsperserving,fatperserving) values ('" + mealid + "','" + food_entry_id + "','" + food.Name + "','" + food.FoodType + "','" + food.Calories + "','" + food.UnitsConsumed + "','" + food.ProteinPerUnit + "','" + food.CarbsPerUnit + "','" + food.FatPerUnit + "')";
                _command.ExecuteNonQuery();
            }
        }
        public Meal[]  SearchMeal(DateTime start, DateTime end)
        {
            Meal[] meals;
            _command.CommandText = "select name,ts,meal_id from meal where ts >= " + start.Ticks + " and ts <= " + end.Ticks;
            SQLiteDataReader meal_results = _command.ExecuteReader();

            while (meal_results.Read())
            {
                Meal meal = new Meal();
                meal.Name = meal_results.GetString(0);
                meal.DateTimeConsumed = new DateTime(meal_results.GetInt32(1));
                _command.CommandText = "select meal_id,food_entry_id,name,food_type,calories,servingsconsumed,proteinperserving,carbsperserving,fatperserving from meal where meal_id = " + meal_results.GetString(3);
                SQLiteDataReader food_results = _command.ExecuteReader();
                while (food_results.Read)){
                    Food food = new Food();
                    food.Name = food_results.GetString(3);

                }

            }

            return meals;
        }
    }
}
