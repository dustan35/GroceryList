using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryList
{
    public partial class Selection : Form
    {
        public Selection()
        {
            InitializeComponent();
        }

        private void Breakfast_Click(object sender, EventArgs e)
        {
            Breakfast go = new Breakfast();
            go.Show();
        }

        private void Lunch_Click(object sender, EventArgs e)
        {
            Lunch go = new Lunch();
            go.Show();
        }

        private void Dinner_Click(object sender, EventArgs e)
        {
            Dinner go = new Dinner();
            go.Show();
        }
    }
}
