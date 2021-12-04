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

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            Food newFoodObject = BuildFoodObjectFromInput();
            if(newFoodObject != null)
            {
                MealEntryForm.AddFoodEntry(newFoodObject);
                Close();
            }
        }

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

        private void FoodEntry_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(MealEntryForm != null)
            {
                MealEntryForm.Enabled = true;
            }
        }
    }
}
