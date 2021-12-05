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

        /// <summary>
        /// Add a food item to the list of food in the meal
        /// </summary>
        /// <param name="newFood"></param>
        public void AddFoodEntry(Food newFood)
        {
            meal.FoodInMeal.Add(newFood);
        }

        /// <summary>
        /// If the user cancels we need to go back to the home form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click(object sender, System.EventArgs e)
        {
            HomeForm.Show();
            Close();
        }

        /// <summary>
        /// On save, validate the meal name is populated, and that there is any food. If valid
        /// update the global meal object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSave_Click(object sender, System.EventArgs e)
        {
            //Validate the meal name
            if (string.IsNullOrEmpty(textBoxMealName.Text))
            {
                MessageBox.Show("Please enter a name for your meal");
                return;
            }

            //Validate that there is food in the meal
            if(meal.FoodInMeal.Count == 0)
            {
                MessageBox.Show("You haven't added any food to your meal!");
                return;
            }

            //Create our date using our date and time pickers
            meal.DateTimeConsumed = datePickerNewMeal.Value.AddMilliseconds(datePickerNewMeal.Value.Millisecond);
            meal.Name = textBoxMealName.Text;

            //Let the user know something actually happened
            MessageBox.Show("Added your meal!");

            //Go back to the homescreen and update the display
            HomeForm.Show();
            HomeForm.AddMeal(meal);
            Close();
        }

        //Make sure we re-open the home page if this gets closed
        private void MealEntry_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomeForm.Show();
        }
    }
}
