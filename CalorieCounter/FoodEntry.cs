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
    public partial class FoodEntry : Form
    {
        public FoodEntry()
        {
            InitializeComponent();
            listBox1.Items.AddRange(typeof(FoodType).GetEnumNames());
            comboBox1.Items.AddRange(typeof(FoodType).GetEnumNames());
        }

        private void FoodEntry_Load(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
