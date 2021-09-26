using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SimpleDXF;

namespace holenc
{
    public partial class Form1 : Form
    {
        List<Data> parts = new List<Data>();
        List<Data> partsR = new List<Data>();
        int nr = 1;
        OpenFileDialog ofd = new OpenFileDialog();
      
        string Ofn;
        // Zmienne transformacji obrazu
        int Oz = 100;
        int Ow = 0;
        int Oh = 0;
        int ex;
        int ey;
        double XL;
        double YL;

        bool ed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            using (Open_fd fd = new Open_fd())
            {
                if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    ofd.Filter = fd.wynik;
                    Ofn = fd.wynik;
                }
            }
            ofd.ShowDialog();
            try
            {
                if (Ofn == "txt|*.txt")
                {
                    wczytajTXT();
                }
                if (Ofn == "nc|*.nc")
                {
                    wczytajNC();
                }
                


            }
            catch { MessageBox.Show("Błąd odczytu pliku"); }
        }
        void wczytajTXT()
        {
            double[] dkod = new double[2];
            int counter = 0;
            string line;
            string[] kod = new string[3];
            StreamReader file = new System.IO.StreamReader(ofd.FileName);
            
            while ((line = file.ReadLine()) != null)
            {
                kod = line.Split(' ');
                dkod[0] = Convert.ToDouble(kod[0].Remove(0,1));
                dkod[1] = Convert.ToDouble(kod[1].Remove(0,1));

                parts.Add(new Data(Convert.ToString(nr), dkod[0], dkod[1]));
                counter++;
                nr++;
                
            }

            file.Close();

            dataGridView1.DataSource = 0;
            dataGridView1.DataSource = parts;
            rysuj();

        }
        void wczytajNC()
        {
            double[] dkod = new double[2];
            int counter = 0;
            string line;
            string[] kod = new string[3];
            StreamReader file = new System.IO.StreamReader(ofd.FileName);

            while ((line = file.ReadLine()) != null)
            {
                if (counter > 1 && line != "M02") { 
                kod = line.Split(' ');
                dkod[0] = Convert.ToDouble(kod[1].Remove(0, 1));
                dkod[1] = Convert.ToDouble(kod[2].Remove(0, 1));

                parts.Add(new Data(Convert.ToString(nr), dkod[0], dkod[1]));
                
                nr++;
                }
                counter++;

            }

            file.Close();

            dataGridView1.DataSource = 0;
            dataGridView1.DataSource = parts;
            rysuj();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void rysuj()
        {
            
            int Ph = panel1.Height / 2;
            int Pw = panel1.Width / 2;
            Graphics g = panel1.CreateGraphics();
            g.Clear(color: Color.Black);
            Pen pen = new Pen(color:Color.Red);
            Pen penO = new Pen(color: Color.Gray);
            Pen penS = new Pen(color: Color.Yellow);
            Pen penL = new Pen(color: Color.FromArgb(150, 150, 0));
            
            pen.Width = 3;
            
            int i = 0;

            g.DrawLine(penO, Pw + Ow,0, Pw + Ow, panel1.Height);
            g.DrawLine(penO, 0, Ph + Oh, panel1.Width, Ph + Oh);

            if (XL != 0 && YL != 0)
            {
                penL.Width = 1;
                g.DrawLine(penL, Pw + Convert.ToInt32(XL) * Oz / 10 + Ow, 0, Pw + Convert.ToInt32(XL) * Oz / 10 + Ow , panel1.Height);
                g.DrawLine(penL, 0, Ph - Convert.ToInt32(YL) * Oz / 10 + Oh, panel1.Width, Ph - Convert.ToInt32(YL) * Oz / 10 + Oh);
            }
            penS.Width = 3;
            label2.Text = "X: " + Convert.ToString(Ow / 10 ) + " Y: " + Convert.ToString(Oh / 10);
            foreach (var point in parts)
            {
                if (dataGridView1.Rows[i].Selected)
                {
                    float Dx = Convert.ToInt32(parts[i].X);
                    float Dy = Convert.ToInt32(parts[i].Y);
                    string nr = parts[i].Nr;
                    g.DrawEllipse(penS, Pw + Dx * Oz / 10 - 3 + Ow, Ph - Dy * Oz / 10 - 3 + Oh, 6, 6);
                    g.DrawString(nr, new Font("Segoe UI Light", 16), Brushes.Yellow, Pw + Dx * Oz / 10 + 3 + Ow, Ph - Dy * Oz / 10 + 3 + Oh);
                }
                else
                {
                    float Dx = Convert.ToInt32(parts[i].X);
                    float Dy = Convert.ToInt32(parts[i].Y);
                    string nr = parts[i].Nr;
                    g.DrawEllipse(pen, Pw + Dx * Oz / 10 - 3 + Ow, Ph - Dy * Oz / 10 - 3 + Oh, 6, 6);
                    g.DrawString(nr, new Font("Segoe UI Light", 16), Brushes.Red, Pw + Dx * Oz / 10 + 3 + Ow, Ph - Dy * Oz / 10 + 3 + Oh);
                }
                    i++;
            }
            
        }
        //######################### CONTROL PANEL ##################
        private void bc_min_Click(object sender, EventArgs e)
        {
            Oz -= 5;
            rysuj();
            label1.Text = "Zoom: " + Convert.ToString(Oz) + "%";
        }

        private void bc_plu_Click(object sender, EventArgs e)
        {
            Oz += 5;
            rysuj();
            label1.Text = "Zoom: " + Convert.ToString(Oz) + "%";
        }

        private void bc_op_Click(object sender, EventArgs e)
        {
            Oh += 10;
            rysuj();
        }

        private void bc_down_Click(object sender, EventArgs e)
        {
            Oh -= 10;
            rysuj();
        }

        private void bc_left_Click(object sender, EventArgs e)
        {
            Ow += 10;
            rysuj();
        }

        private void bc_right_Click(object sender, EventArgs e)
        {
            Ow -= 10;
            rysuj();
        }

        private void b_odswiez_Click(object sender, EventArgs e)
        {
            Oz = 100;
            Ow = 0;
            Oh = 0;
            label1.Text = "Zoom: " + Convert.ToString(Oz) + "%";
            label2.Text = "X: " + Convert.ToString(Ow) + " Y: " + Convert.ToString(Oh);
            dataGridView1.DataSource = 0;
            dataGridView1.DataSource = parts;
            
            rysuj();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            parts.Clear();
            Oz = 100;
            Ow = 0;
            Oh = 0;
            label1.Text = "Zoom: " + Convert.ToString(Oz) + "%";
            label2.Text = "X: " + Convert.ToString(Ow) + " Y: " + Convert.ToString(Oh);
            dataGridView1.DataSource = 0;
            nr = 1;
            rysuj();

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            panel1.Cursor = Cursors.SizeAll;
            ex = e.X;
            ey = e.Y;
            ed = true;

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            ed = false;
            ex -= e.X;
            ey -= e.Y;
            Ow -= ex;
            Oh -= ey;
            panel1.Cursor = Cursors.Arrow;
            rysuj();

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
           
        }



        //############################ Import export DXF




        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Import
                OpenFileDialog odxf = new OpenFileDialog();
                odxf.Filter = "dxf|*.dxf";
                odxf.ShowDialog();
                // StreamReader filedxf = new System.IO.StreamReader(odxf.FileName);
                Document doc = new Document(odxf.FileName);
                List<Line> lines;
                doc.Read();
                lines = doc.Lines;
                double[] dkod = new double[2];
                int cout = lines.Count;
                int i = 0;
                while (cout != 0)
                {


                    parts.Add(new Data(Convert.ToString(nr), lines[i].P2.X, lines[i].P2.Y));
                    nr++;
                    cout--;
                    i++;
                    
                }
                dataGridView1.DataSource = 0;
                dataGridView1.DataSource = parts;
                rysuj();
            }
            catch { MessageBox.Show("Błąd odczytu pliku"); }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aby odblokować wesprzyj projekt na dalszy rozwój:", "Wersja Demo", MessageBoxButtons.OKCancel);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "YouGar Mode File- YHWM" + Environment.NewLine;
            richTextBox1.Text += "G90" + Environment.NewLine;
            for (int i = 0; i < parts.Count; i++)
            {
                richTextBox1.Text += "G11 X" + Convert.ToString(parts[i].X) + " Y" + Convert.ToString(parts[i].Y) + Environment.NewLine;
                   
            }
            richTextBox1.Text += "M02" + Environment.NewLine;

        }

        private void b_ust_Click(object sender, EventArgs e)
        {
            //Ustawienia ust = new Ustawienia();
            // ust.Show();
            MessageBox.Show("Aby odblokować wesprzyj projekt na dalszy rozwój:", "Wersja Demo", MessageBoxButtons.OKCancel);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aby odblokować wesprzyj projekt na dalszy rozwój:","Wersja Demo",MessageBoxButtons.OKCancel);
        }
        // ########################## Przybornik
        private void bp_D_Click(object sender, EventArgs e)
        {
            // Dodaj;
            using (Dodaj Prz = new Dodaj(0,XL,YL))
            {
                if (Prz.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    parts.Add(new Data(Convert.ToString(nr), Prz.d_x, Prz.d_y));
                    nr++;

                }
                dataGridView1.DataSource = 0;
                dataGridView1.DataSource = parts;
                rysuj();
            }
            

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            int wybrano = dataGridView1.CurrentCell.RowIndex;
            using (Dodaj Prz = new Dodaj(1, XL, YL))
            {
                if (Prz.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    foreach (DataGridViewRow r in dataGridView1.SelectedRows)
                    {
                        if (Prz.r_1 == 1)
                        {
                            parts[r.Index].X += Prz.d_x;
                            parts[r.Index].Y += Prz.d_y;
                        }
                        else
                        {
                            parts[r.Index].X = Prz.d_x;
                            parts[r.Index].Y = Prz.d_y;
                        }
                    }

                }
                
                dataGridView1.DataSource = 0;
                dataGridView1.DataSource = parts;
                rysuj();
            }
        }

        private void bp_K_Click(object sender, EventArgs e)
        {
            int wybrano = dataGridView1.CurrentCell.RowIndex;
            using (Dodaj Prz = new Dodaj(2, XL, YL))
            {
                if (Prz.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    foreach (DataGridViewRow r in dataGridView1.SelectedRows)
                    {
                        
                         double X2 = parts[r.Index].X + Prz.d_x;
                         double Y2 = parts[r.Index].Y + Prz.d_y;
                        parts.Add(new Data(Convert.ToString(nr), X2, Y2));
                        nr++;


                    }

                }

                dataGridView1.DataSource = 0;
                dataGridView1.DataSource = parts;
                rysuj();
            }
        }

        private void bp_L_Click(object sender, EventArgs e)
        {
            int wybrano = dataGridView1.CurrentCell.RowIndex;
            using (Dodaj Prz = new Dodaj(3, XL, YL))
            {
                if (Prz.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    foreach (DataGridViewRow r in dataGridView1.SelectedRows)
                    {
                        if (Prz.c_1)
                        {
                            if (Prz.r_1 == 1)
                            {
                                parts.Add(new Data(Convert.ToString(nr), -parts[r.Index].X, parts[r.Index].Y));
                                nr++;
                            }
                            if (Prz.r_1 == 0)
                            {
                                parts.Add(new Data(Convert.ToString(nr), parts[r.Index].X, -parts[r.Index].Y));
                                nr++;
                            }

                        }
                        else
                        {
                            if (Prz.r_1 == 1)
                            {
                                parts[r.Index].X = -parts[r.Index].X;
                                
                            }
                            if (Prz.r_1 == 0)
                            {
                                parts[r.Index].Y = -parts[r.Index].Y;
                            }
                        }
                        


                    }

                }

                dataGridView1.DataSource = 0;
                dataGridView1.DataSource = parts;
                rysuj();
            }
        }

        private void bp_up_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aby odblokować wesprzyj projekt na dalszy rozwój:", "Wersja Demo", MessageBoxButtons.OKCancel);
        }

        private void bp_Down_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aby odblokować wesprzyj projekt na dalszy rozwój:", "Wersja Demo", MessageBoxButtons.OKCancel);
        }

        private void bp_U_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow r in dataGridView1.SelectedRows)
            {
                // int nr2 = 1;
                // for (int i = 0; i < r.Index; i++)
                // {
                parts.RemoveAt(r.Index);

                // }



            }
            int nrR = 1;
            for (int i = 0; i < parts.Count; i++) {
                partsR.Add(new Data(Convert.ToString(nrR), parts[i].X, parts[i].Y));
                nrR++;
            }
            parts.Clear();
            parts = partsR.ToList();
            partsR.Clear();
            nr = parts.Count;
            nr++;


            dataGridView1.DataSource = 0;
            dataGridView1.DataSource = parts;
            rysuj();
        }

        private void dataGridView1_MouseUp(object sender, MouseEventArgs e)
        {
            rysuj();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int wybrano = dataGridView1.CurrentCell.RowIndex;
            using (Dodaj Prz = new Dodaj(4, XL, YL))
            {
                if (Prz.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    foreach (DataGridViewRow r in dataGridView1.SelectedRows)
                    {
                        if (Prz.c_1)
                        {
                            if (Prz.r_1 == 0)
                            {
                                parts.Add(new Data(Convert.ToString(nr), parts[r.Index].Y, -parts[r.Index].X));
                                nr++;
                            }
                            if (Prz.r_1 == 1)
                            {
                                parts.Add(new Data(Convert.ToString(nr),-parts[r.Index].X,-parts[r.Index].Y));
                                nr++;
                            }
                            if (Prz.r_1 == 2)
                            {
                                parts.Add(new Data(Convert.ToString(nr), -parts[r.Index].Y, parts[r.Index].X));
                                nr++;
                            }

                        }
                        else
                        {
                            double X1 = parts[r.Index].X;
                            double Y1 = parts[r.Index].Y;
                            if (Prz.r_1 == 0)
                            {
                                parts[r.Index].X = Y1;
                                parts[r.Index].Y = -X1;


                            }
                            if (Prz.r_1 == 1)
                            {
                                parts[r.Index].X = -X1;
                                parts[r.Index].Y = -Y1;
                            }
                            if (Prz.r_1 == 2)
                            {
                                parts[r.Index].X = -Y1;
                                parts[r.Index].Y = X1;
                            }
                        }



                    }

                }

                dataGridView1.DataSource = 0;
                dataGridView1.DataSource = parts;
                rysuj();
            }
        }
        // Label zmiennych lokalnych
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                XL = Convert.ToDouble(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Nie dozwolony znak!");
                textBox1.Text = Convert.ToString(XL);
            }
            rysuj();
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                YL = Convert.ToDouble(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Nie dozwolony znak!");
                textBox2.Text = Convert.ToString(YL);
            }
            rysuj();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            XL = 0;
            YL = 0;
            textBox1.Text = Convert.ToString(XL);
            textBox2.Text = Convert.ToString(YL);
            rysuj();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            XL = parts[i].X;
            YL = parts[i].Y;
            textBox1.Text = Convert.ToString(XL);
            textBox2.Text = Convert.ToString(YL);
            rysuj();
        }

        private void panel1_DoubleClick(object sender, EventArgs e)
        {
           
        }


    }
    

    
}
