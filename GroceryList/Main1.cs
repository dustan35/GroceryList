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
    public partial class Main1 : Form
    {
        public Main1()
        {
            InitializeComponent();
        }

        private void breakfast_Click(object sender, EventArgs e)
        {

        }
        int half = 0;
        int full = 0;
        int cereal = 0;
        int bacon = 0;
        int eggs = 0;
        int sP = 0;
        int sL = 0;
        int hB = 0;
        int pMix = 0;
        int gJelly = 0;
        int sJelly = 0;
        int syrup = 0;



        private void button11_Click(object sender, EventArgs e)
        {

            half++;            
            textBox1.Text = half.ToString();
            
         
        }

        private void button12_Click(object sender, EventArgs e)
        {
            half--;
            if (half == -1)
            {
                half++;
            }
            textBox1.Text = half.ToString();
            
           
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            full++;
            textBox10.Text = full.ToString();

        }

        private void button24_Click(object sender, EventArgs e)
        {
            full--;
            if (full == -1)
            {
                full++;
            }
            textBox10.Text = full.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            cereal++;
            textBox9.Text = cereal.ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            cereal--;
            if (cereal == -1)
            {
                cereal++;

            }
            textBox9.Text = cereal.ToString();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            bacon++;
            textBox8.Text = bacon.ToString();

        }

        private void button22_Click(object sender, EventArgs e)
        {
            bacon--;
            if (bacon == -1)
            {
                bacon++;
            }
            textBox8.Text = bacon.ToString();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            eggs++;
            textBox7.Text = eggs.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            eggs--;
            if (eggs == -1)
            {
                eggs++;
            }
            textBox7.Text = eggs.ToString();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            sL++;
            textBox6.Text = sL.ToString();

        }

        private void button19_Click(object sender, EventArgs e)
        {
            sL--;
            if (sL == -1)
            {
                sL++;

            }
            textBox6.Text = sL.ToString();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            sP++;
            textBox5.Text = sP.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            sP--;
            if (sP == -1)
            {
                sP++;
            }
            textBox5.Text = sP.ToString();

        }

        private void button20_Click(object sender, EventArgs e)
        {
            hB++;
            textBox4.Text = hB.ToString();

        }

        private void button15_Click(object sender, EventArgs e)
        {
            hB--;
            if (hB == -1)
            {
                hB++;
            }
            textBox4.Text = hB.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            pMix++;
            textBox3.Text = pMix.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            pMix--;
            if (pMix == -1)
            {
                pMix++;
            }
            textBox3.Text = pMix.ToString();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            gJelly++;
            textBox2.Text = gJelly.ToString();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            
            gJelly--;
            if (gJelly == -1)
            {
                gJelly++;
            }
            textBox2.Text = gJelly.ToString();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            sJelly++;
            textBox11.Text = sJelly.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sJelly--;
            if (sJelly == -1)
            {
                sJelly++;
            }
            textBox11.Text = sJelly.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
