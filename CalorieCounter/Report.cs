using CalorieCounter.lib;
using CalorieCounter.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
namespace CalorieCounter
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
            FloorDateToSunday();
            UpdateDataGridView();
        }

        /// <summary>
        /// Close form on cancel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// On value changed, floor the date to a Sunday and update the report grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimePickerReport_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerReport.ValueChanged -= dateTimePickerReport_ValueChanged;
            FloorDateToSunday();
            UpdateDataGridView();
            dateTimePickerReport.ValueChanged += dateTimePickerReport_ValueChanged;
        }

        /// <summary>
        /// Floor the date in the date time picker to the closest Sunday, moving back in time
        /// </summary>
        private void FloorDateToSunday()
        {
            while (dateTimePickerReport.Value.DayOfWeek != DayOfWeek.Sunday)
            {
                dateTimePickerReport.Value = dateTimePickerReport.Value.AddDays(-1);
            }
        }

        /// <summary>
        /// For each meal, determine the day and sum values into a ReportData object. Bind that to the data grid for viewing
        /// </summary>
        private void UpdateDataGridView()
        {
            //Dictionary of data
            Dictionary<DateTime, ReportData> reportDataListByDate = new Dictionary<DateTime, ReportData>();

            //Get the end of the week to use for selecting data
            DateTime endOfWeek = dateTimePickerReport.Value.Date.AddDays(6).AddHours(23).AddMinutes(59).AddSeconds(59);

            //Get the meals from the database
            List<Meal> mealList = Data.SearchMeal(dateTimePickerReport.Value.Date, endOfWeek);
            
            //Add all possible dates
            for(int i = 0; i < 7; i++)
            {
                reportDataListByDate.Add(dateTimePickerReport.Value.Date.AddDays(i), new ReportData());
                reportDataListByDate[dateTimePickerReport.Value.Date.AddDays(i)].DateTime = dateTimePickerReport.Value.Date.AddDays(i);
            }

            //Loop through meals and get totals for reports
            foreach(Meal meal in mealList)
            {

                //Calories, carbs, fat, and protein
                reportDataListByDate[meal.DateTimeConsumed.Date].TotalCalories += meal.GetTotalCalories();
                reportDataListByDate[meal.DateTimeConsumed.Date].TotalCarbs += meal.GetTotalCarbs();
                reportDataListByDate[meal.DateTimeConsumed.Date].TotalFat += meal.GetTotalFat();
                reportDataListByDate[meal.DateTimeConsumed.Date].TotalProtein += meal.GetTotalProtein();

                reportDataListByDate[meal.DateTimeConsumed.Date].VegetableServings += meal.GetServingCountForFoodType(FoodType.Vegetable); 
                reportDataListByDate[meal.DateTimeConsumed.Date].FruitServings += meal.GetServingCountForFoodType(FoodType.Fruit); 
                reportDataListByDate[meal.DateTimeConsumed.Date].GrainsServings += meal.GetServingCountForFoodType(FoodType.Grains); 
                reportDataListByDate[meal.DateTimeConsumed.Date].NutsServings += meal.GetServingCountForFoodType(FoodType.Nuts); 
                reportDataListByDate[meal.DateTimeConsumed.Date].MeatServings += meal.GetServingCountForFoodType(FoodType.Meat); 
                reportDataListByDate[meal.DateTimeConsumed.Date].FishServings += meal.GetServingCountForFoodType(FoodType.Fish); 
                reportDataListByDate[meal.DateTimeConsumed.Date].DairyServings += meal.GetServingCountForFoodType(FoodType.Dairy); 
                reportDataListByDate[meal.DateTimeConsumed.Date].EggsServings += meal.GetServingCountForFoodType(FoodType.Eggs); 
                reportDataListByDate[meal.DateTimeConsumed.Date].JunkServings += meal.GetServingCountForFoodType(FoodType.Junk);
                reportDataListByDate[meal.DateTimeConsumed.Date].OtherServings += meal.GetServingCountForFoodType(FoodType.Other);
            }

            List<ReportData> reportDataList = reportDataListByDate.Values.ToList();
            reportDataList = reportDataList.OrderBy(reportData => reportData.DateTime).ToList();
            dataGridViewReport.DataSource = new BindingList<ReportData>(reportDataList);
        }

    }
}
