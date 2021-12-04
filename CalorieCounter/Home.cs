using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace CalorieCounter
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            models.sql sql = new models.sql().init();
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
