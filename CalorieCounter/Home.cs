using CalorieCounter.lib;
using CalorieCounter.models;
using System;
using System.Windows.Forms;

namespace CalorieCounter
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Open the meal entry dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMealEntry_Click(object sender, EventArgs e)
        {

            MealEntry mealEntry = new MealEntry
            {
                HomeForm = this
            };
            Hide();
            mealEntry.Show();
        }

        private void buttonRunReport_Click(object sender, EventArgs e)
        {
            (new Report()).Show();
        }

        /// <summary>
        /// Add a meal to the database and display last meal added
        /// </summary>
        /// <param name="meal"></param>
        public void AddMeal(Meal meal)
        {
            Data.SaveMeal(meal);
            labelLastMealAdded.Text = "Last meal added: " + meal.Name + " at " + meal.DateTimeConsumed.ToString();
        }
    }
}
