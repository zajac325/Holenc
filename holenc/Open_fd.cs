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
    public partial class Open_fd : Form
    {
        public string wynik { get; set; }

        public Open_fd()
        {
            InitializeComponent();
        }

        private void Open_fd_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            wynik = "allfiles|*.*";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            wynik = "nc|*.nc";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            wynik = "txt|*.txt";
        }
    }
}
