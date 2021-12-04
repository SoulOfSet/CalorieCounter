using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalorieCounter
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            lib.Data data = new lib.Data().init();
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
    }
}
