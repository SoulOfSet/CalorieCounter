using System;
using System.Windows.Forms;

namespace CalorieCounter
{
    public partial class FoodEntry : Form
    {

        public MealEntry MealEntryForm; 

        public FoodEntry()
        {
            InitializeComponent();
            comboBoxFoodTypes.Items.AddRange(typeof(FoodType).GetEnumNames());
        }

        /// <summary>
        /// Close the window on cancel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// On save, validate and build the food object. Send the object back to the meal for storage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void save_Click(object sender, EventArgs e)
        {
            Food newFoodObject = BuildFoodObjectFromInput();
            if(newFoodObject != null)
            {
                MealEntryForm.AddFoodEntry(newFoodObject);
                Close();
            }
        }

        /// <summary>
        /// Validate text input and build food object
        /// </summary>
        /// <returns>New food object</returns>
        private Food BuildFoodObjectFromInput()
        {
            double servingsConsumed;
            double proteinPerServing;
            double fatPerServing;
            double carbsPerServing;

            //Validate name is not empty
            if(string.IsNullOrEmpty(textBoxName.Text))
            {
                MessageBox.Show("Please name your food");
                return null;
            }

            //Validate Type
            if(comboBoxFoodTypes.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a food type");
                return null;
            }

            //Validate servings consumed
            if(!double.TryParse(textBoxServings.Text, out servingsConsumed))
            {
                MessageBox.Show("Please enter a valid value for servings");
                return null;
            }

            //Validate protein per serving
            if (!double.TryParse(textBoxProtein.Text, out proteinPerServing))
            {
                MessageBox.Show("Please enter a valid value for protein");
                return null;
            }

            //Validate Units consumed
            if (!double.TryParse(textBoxFat.Text, out fatPerServing))
            {
                MessageBox.Show("Please enter a valid value for fat");
                return null;
            }

            //Validate Units consumed
            if (!double.TryParse(textBoxCarbs.Text, out carbsPerServing))
            {
                MessageBox.Show("Please enter a valid value for carbs");
                return null;
            }

            //Create the food object
            Food food = new Food
            {
                Name = textBoxName.Text,
                FoodType = (FoodType)comboBoxFoodTypes.SelectedIndex,
                ServingsConsumed = servingsConsumed,
                ProteinPerServing = proteinPerServing,
                FatPerServing = fatPerServing,
                CarbsPerServing = carbsPerServing
            };

            return food;
        }

        /// <summary>
        /// When the form is closed we can re-enable the MealEntryForm so the user can continue to work
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FoodEntry_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(MealEntryForm != null)
            {
                MealEntryForm.Enabled = true;
            }
        }
    }
}
