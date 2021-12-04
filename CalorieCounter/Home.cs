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

        public void AddMeal(Meal meal)
        {
            //Add logic for doing SQL to add meal with database
            labelLastMealAdded.Text = "Last meal added: " + meal.Name + " at " + meal.DateTimeConsumed.ToString();
        }
    }
}
