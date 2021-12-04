using CalorieCounter.models;
using System.Windows.Forms;

namespace CalorieCounter
{
    public partial class MealEntry : Form
    {
        public Home HomeForm;
        private Meal meal;

        public MealEntry()
        {
            InitializeComponent();
        }

        /// <summary>
        /// On show, re-initialize the current meal object so we can build out a new one
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MealEntry_Shown(object sender, System.EventArgs e)
        {
            meal = new Meal();
        }


        /// <summary>
        /// When clicking the add food button, show the food entry form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFoodEntry_Click(object sender, System.EventArgs e)
        {
            FoodEntry foodEntry = new FoodEntry
            {
                MealEntryForm = this
            };

            //Disable this form so they cant keep clicking stuff
            Enabled = false;

            //Show food entry form
            foodEntry.Show();
        }

        public void AddFoodEntry(Food newFood)
        {
            meal.FoodInMeal.Add(newFood);
        }

        private void buttonCancel_Click(object sender, System.EventArgs e)
        {
            HomeForm.Show();
            Close();
        }

        private void buttonSave_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxMealName.Text))
            {
                MessageBox.Show("Please enter a name for your meal");
                return;
            }

            if(meal.FoodInMeal.Count == 0)
            {
                MessageBox.Show("You haven't added any food your meal!");
                return;
            }

            meal.DateTimeConsumed = datePickerNewMeal.Value.AddMilliseconds(datePickerNewMeal.Value.Millisecond);
            meal.Name = textBoxMealName.Text;
            MessageBox.Show("Added your meal!");

            HomeForm.Show();
            Close();
        }
    }
}
