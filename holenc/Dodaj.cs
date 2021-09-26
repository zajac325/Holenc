using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace holenc
{
    public partial class Dodaj : Form
    {
        public int opcja { get; set; }
        public double d_x { get; set; }
        public double d_y { get; set; }
        public int r_1 { get; set; }
        public int r_2 { get; set; }
        public int r_3 { get; set; }
        public int r_4 { get; set; }
        public bool c_1 { get; set; }


        public Dodaj(int opcja, double d_x, double d_y)
        {

            this.opcja = opcja;
            this.d_x = d_x;
            this.d_x = d_y;

        InitializeComponent();
            tabControl1.SelectedIndex = opcja;
            if (opcja == 0)
            {
                textBox1.Text = Convert.ToString(d_x);
                textBox2.Text = Convert.ToString(d_y);
            }
            if (opcja == 1)
            {
                textBox3.Text = Convert.ToString(d_x);
                textBox4.Text = Convert.ToString(d_y);
            }
            if (opcja == 2)
            {
                textBox5.Text = Convert.ToString(d_x);
                textBox6.Text = Convert.ToString(d_y);
            }
            if (opcja == 3)
            {
                textBox1.Text = Convert.ToString(d_x);
                textBox2.Text = Convert.ToString(d_y);
            }


        }

        private void button13_Click(object sender, EventArgs e)
        {

            if (opcja == 0)
            {
                d_x = Convert.ToDouble(textBox1.Text);
                d_y = Convert.ToDouble(textBox2.Text);
            }
            if (opcja == 1)
            {
                d_x = Convert.ToDouble(textBox3.Text);
                d_y = Convert.ToDouble(textBox4.Text);
                if (radioButton6.Checked)
                {
                    r_1 = 1;
                }
                else
                {
                    r_1 = 0;
                }
            }
            if (opcja == 2)
            {
                d_x = Convert.ToDouble(textBox5.Text);
                d_y = Convert.ToDouble(textBox6.Text);
                
            }
            if (opcja == 3)
            {
                if (radioButton3.Checked)
                {
                    r_1 = 1;
                }
                else
                {
                    r_1 = 0;
                }
                if (checkBox1.Checked)
                {
                    c_1 = true;
                }
                else
                {
                    c_1 = false;
                }

            }
            if (opcja == 4)
            {
                if (radioButton8.Checked)
                {
                    r_1 = 1;
                }
                else if (radioButton9.Checked)
                {
                    r_1 = 2;
                }
                else
                {
                    r_1 = 0;
                }
                if (checkBox2.Checked)
                {
                    c_1 = true;
                }
                else
                {
                    c_1 = false;
                }

            }

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = opcja;
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }
    }
}
