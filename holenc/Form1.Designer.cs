
namespace holenc
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.bp_Down = new System.Windows.Forms.Button();
            this.bp_up = new System.Windows.Forms.Button();
            this.bp_D = new System.Windows.Forms.Button();
            this.bp_U = new System.Windows.Forms.Button();
            this.bp_L = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.bp_K = new System.Windows.Forms.Button();
            this.b_ust = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.b_odswiez = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bc_right = new System.Windows.Forms.Button();
            this.bc_down = new System.Windows.Forms.Button();
            this.bc_left = new System.Windows.Forms.Button();
            this.bc_plu = new System.Windows.Forms.Button();
            this.bc_op = new System.Windows.Forms.Button();
            this.bc_min = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.xDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dataBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nr,
            this.xDataGridViewTextBoxColumn,
            this.yDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dataBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 35;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(353, 87);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseUp);
            // 
            // Nr
            // 
            this.Nr.DataPropertyName = "Nr";
            this.Nr.FillWeight = 96.25668F;
            this.Nr.HeaderText = "Nr";
            this.Nr.MinimumWidth = 6;
            this.Nr.Name = "Nr";
            this.Nr.ReadOnly = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(1030, 87);
            this.richTextBox1.MaximumSize = new System.Drawing.Size(500, 1000);
            this.richTextBox1.MinimumSize = new System.Drawing.Size(247, 100);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(370, 475);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.bp_Down);
            this.groupBox1.Controls.Add(this.bp_up);
            this.groupBox1.Controls.Add(this.bp_D);
            this.groupBox1.Controls.Add(this.bp_U);
            this.groupBox1.Controls.Add(this.bp_L);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.bp_K);
            this.groupBox1.Location = new System.Drawing.Point(3, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 376);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Przybornik";
            // 
            // button8
            // 
            this.button8.AutoSize = true;
            this.button8.BackColor = System.Drawing.Color.Moccasin;
            this.button8.Location = new System.Drawing.Point(6, 326);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(341, 45);
            this.button8.TabIndex = 18;
            this.button8.Text = "Rotacja";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // bp_Down
            // 
            this.bp_Down.AutoSize = true;
            this.bp_Down.BackColor = System.Drawing.Color.Moccasin;
            this.bp_Down.Location = new System.Drawing.Point(6, 21);
            this.bp_Down.Name = "bp_Down";
            this.bp_Down.Size = new System.Drawing.Size(166, 45);
            this.bp_Down.TabIndex = 17;
            this.bp_Down.Text = "Kolejność niżej";
            this.bp_Down.UseVisualStyleBackColor = false;
            this.bp_Down.Click += new System.EventHandler(this.bp_Down_Click);
            // 
            // bp_up
            // 
            this.bp_up.AutoSize = true;
            this.bp_up.BackColor = System.Drawing.Color.Moccasin;
            this.bp_up.Location = new System.Drawing.Point(181, 21);
            this.bp_up.Name = "bp_up";
            this.bp_up.Size = new System.Drawing.Size(166, 45);
            this.bp_up.TabIndex = 16;
            this.bp_up.Text = "Kolejność wyżej";
            this.bp_up.UseVisualStyleBackColor = false;
            this.bp_up.Click += new System.EventHandler(this.bp_up_Click);
            // 
            // bp_D
            // 
            this.bp_D.AutoSize = true;
            this.bp_D.BackColor = System.Drawing.Color.Moccasin;
            this.bp_D.Location = new System.Drawing.Point(6, 72);
            this.bp_D.Name = "bp_D";
            this.bp_D.Size = new System.Drawing.Size(341, 45);
            this.bp_D.TabIndex = 11;
            this.bp_D.Text = "Dodaj";
            this.bp_D.UseVisualStyleBackColor = false;
            this.bp_D.Click += new System.EventHandler(this.bp_D_Click);
            // 
            // bp_U
            // 
            this.bp_U.AutoSize = true;
            this.bp_U.BackColor = System.Drawing.Color.Moccasin;
            this.bp_U.Location = new System.Drawing.Point(6, 124);
            this.bp_U.Name = "bp_U";
            this.bp_U.Size = new System.Drawing.Size(341, 45);
            this.bp_U.TabIndex = 12;
            this.bp_U.Text = "Usuń";
            this.bp_U.UseVisualStyleBackColor = false;
            this.bp_U.Click += new System.EventHandler(this.bp_U_Click);
            // 
            // bp_L
            // 
            this.bp_L.AutoSize = true;
            this.bp_L.BackColor = System.Drawing.Color.Moccasin;
            this.bp_L.Location = new System.Drawing.Point(6, 277);
            this.bp_L.Name = "bp_L";
            this.bp_L.Size = new System.Drawing.Size(341, 45);
            this.bp_L.TabIndex = 15;
            this.bp_L.Text = "Lustro";
            this.bp_L.UseVisualStyleBackColor = false;
            this.bp_L.Click += new System.EventHandler(this.bp_L_Click);
            // 
            // button6
            // 
            this.button6.AutoSize = true;
            this.button6.BackColor = System.Drawing.Color.Moccasin;
            this.button6.Location = new System.Drawing.Point(6, 175);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(341, 45);
            this.button6.TabIndex = 13;
            this.button6.Text = "Przesuń";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // bp_K
            // 
            this.bp_K.AutoSize = true;
            this.bp_K.BackColor = System.Drawing.Color.Moccasin;
            this.bp_K.Location = new System.Drawing.Point(6, 226);
            this.bp_K.Name = "bp_K";
            this.bp_K.Size = new System.Drawing.Size(341, 45);
            this.bp_K.TabIndex = 14;
            this.bp_K.Text = "Kopiuj";
            this.bp_K.UseVisualStyleBackColor = false;
            this.bp_K.Click += new System.EventHandler(this.bp_K_Click);
            // 
            // b_ust
            // 
            this.b_ust.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_ust.BackColor = System.Drawing.Color.Moccasin;
            this.b_ust.Location = new System.Drawing.Point(1281, 12);
            this.b_ust.Name = "b_ust";
            this.b_ust.Size = new System.Drawing.Size(119, 69);
            this.b_ust.TabIndex = 12;
            this.b_ust.Text = "Ustawienia";
            this.b_ust.UseVisualStyleBackColor = false;
            this.b_ust.Click += new System.EventHandler(this.b_ust_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.Moccasin;
            this.button2.Location = new System.Drawing.Point(137, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 69);
            this.button2.TabIndex = 10;
            this.button2.Text = "Zapisz";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Moccasin;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 69);
            this.button1.TabIndex = 9;
            this.button1.Text = "Otwórz";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // b_odswiez
            // 
            this.b_odswiez.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_odswiez.BackColor = System.Drawing.Color.Moccasin;
            this.b_odswiez.Location = new System.Drawing.Point(905, 11);
            this.b_odswiez.Name = "b_odswiez";
            this.b_odswiez.Size = new System.Drawing.Size(119, 69);
            this.b_odswiez.TabIndex = 13;
            this.b_odswiez.Text = "Odświerz";
            this.b_odswiez.UseVisualStyleBackColor = false;
            this.b_odswiez.Click += new System.EventHandler(this.b_odswiez_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.BackColor = System.Drawing.Color.Moccasin;
            this.button3.Location = new System.Drawing.Point(262, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 69);
            this.button3.TabIndex = 14;
            this.button3.Text = "Import DXF";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.BackColor = System.Drawing.Color.Moccasin;
            this.button4.Location = new System.Drawing.Point(387, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 69);
            this.button4.TabIndex = 15;
            this.button4.Text = "Export DXF";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.BackColor = System.Drawing.Color.Moccasin;
            this.button5.Location = new System.Drawing.Point(512, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(119, 69);
            this.button5.TabIndex = 16;
            this.button5.Text = "Generuj Gcode";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.groupBox2.Controls.Add(this.bc_right);
            this.groupBox2.Controls.Add(this.bc_down);
            this.groupBox2.Controls.Add(this.bc_left);
            this.groupBox2.Controls.Add(this.bc_plu);
            this.groupBox2.Controls.Add(this.bc_op);
            this.groupBox2.Controls.Add(this.bc_min);
            this.groupBox2.Location = new System.Drawing.Point(386, 332);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 140);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Widok";
            // 
            // bc_right
            // 
            this.bc_right.BackColor = System.Drawing.Color.Moccasin;
            this.bc_right.Location = new System.Drawing.Point(169, 80);
            this.bc_right.Name = "bc_right";
            this.bc_right.Size = new System.Drawing.Size(75, 53);
            this.bc_right.TabIndex = 5;
            this.bc_right.Text = "→";
            this.bc_right.UseVisualStyleBackColor = false;
            this.bc_right.Click += new System.EventHandler(this.bc_right_Click);
            // 
            // bc_down
            // 
            this.bc_down.BackColor = System.Drawing.Color.Moccasin;
            this.bc_down.Location = new System.Drawing.Point(88, 80);
            this.bc_down.Name = "bc_down";
            this.bc_down.Size = new System.Drawing.Size(75, 53);
            this.bc_down.TabIndex = 4;
            this.bc_down.Text = "↓";
            this.bc_down.UseVisualStyleBackColor = false;
            this.bc_down.Click += new System.EventHandler(this.bc_down_Click);
            // 
            // bc_left
            // 
            this.bc_left.BackColor = System.Drawing.Color.Moccasin;
            this.bc_left.Location = new System.Drawing.Point(7, 80);
            this.bc_left.Name = "bc_left";
            this.bc_left.Size = new System.Drawing.Size(75, 53);
            this.bc_left.TabIndex = 3;
            this.bc_left.Text = "←";
            this.bc_left.UseVisualStyleBackColor = false;
            this.bc_left.Click += new System.EventHandler(this.bc_left_Click);
            // 
            // bc_plu
            // 
            this.bc_plu.BackColor = System.Drawing.Color.Moccasin;
            this.bc_plu.Location = new System.Drawing.Point(169, 21);
            this.bc_plu.Name = "bc_plu";
            this.bc_plu.Size = new System.Drawing.Size(75, 53);
            this.bc_plu.TabIndex = 2;
            this.bc_plu.Text = "+";
            this.bc_plu.UseVisualStyleBackColor = false;
            this.bc_plu.Click += new System.EventHandler(this.bc_plu_Click);
            // 
            // bc_op
            // 
            this.bc_op.BackColor = System.Drawing.Color.Moccasin;
            this.bc_op.Location = new System.Drawing.Point(88, 21);
            this.bc_op.Name = "bc_op";
            this.bc_op.Size = new System.Drawing.Size(75, 53);
            this.bc_op.TabIndex = 1;
            this.bc_op.Text = "↑";
            this.bc_op.UseVisualStyleBackColor = false;
            this.bc_op.Click += new System.EventHandler(this.bc_op_Click);
            // 
            // bc_min
            // 
            this.bc_min.BackColor = System.Drawing.Color.Moccasin;
            this.bc_min.Location = new System.Drawing.Point(7, 21);
            this.bc_min.Name = "bc_min";
            this.bc_min.Size = new System.Drawing.Size(75, 53);
            this.bc_min.TabIndex = 0;
            this.bc_min.Text = "-";
            this.bc_min.UseVisualStyleBackColor = false;
            this.bc_min.Click += new System.EventHandler(this.bc_min_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Location = new System.Drawing.Point(12, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 475);
            this.panel1.TabIndex = 4;
            this.panel1.DoubleClick += new System.EventHandler(this.panel1_DoubleClick);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.AntiqueWhite;
            this.groupBox3.Controls.Add(this.button10);
            this.groupBox3.Controls.Add(this.button9);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(319, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(317, 119);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lokalne Osie";
            // 
            // button10
            // 
            this.button10.AutoSize = true;
            this.button10.BackColor = System.Drawing.Color.Moccasin;
            this.button10.Location = new System.Drawing.Point(166, 67);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(144, 45);
            this.button10.TabIndex = 20;
            this.button10.Text = "Ustaw 0,0";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.AutoSize = true;
            this.button9.BackColor = System.Drawing.Color.Moccasin;
            this.button9.Location = new System.Drawing.Point(12, 67);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(142, 45);
            this.button9.TabIndex = 19;
            this.button9.Text = "Ustaw z pkt";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2.Location = new System.Drawing.Point(200, 20);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 41);
            this.textBox2.TabIndex = 3;
            this.textBox2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(160, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 36);
            this.label4.TabIndex = 2;
            this.label4.Text = "Y:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(54, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 41);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(3, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "X: +0 Y: +0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zoom: 100%";
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.BackColor = System.Drawing.Color.Moccasin;
            this.button7.Location = new System.Drawing.Point(1030, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(119, 69);
            this.button7.TabIndex = 17;
            this.button7.Text = "Wyczyść";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(1155, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 68);
            this.listBox1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(657, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(367, 475);
            this.panel2.TabIndex = 19;
            // 
            // xDataGridViewTextBoxColumn
            // 
            this.xDataGridViewTextBoxColumn.DataPropertyName = "X";
            this.xDataGridViewTextBoxColumn.FillWeight = 101.8717F;
            this.xDataGridViewTextBoxColumn.HeaderText = "X";
            this.xDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.xDataGridViewTextBoxColumn.Name = "xDataGridViewTextBoxColumn";
            this.xDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yDataGridViewTextBoxColumn
            // 
            this.yDataGridViewTextBoxColumn.DataPropertyName = "Y";
            this.yDataGridViewTextBoxColumn.FillWeight = 101.8717F;
            this.yDataGridViewTextBoxColumn.HeaderText = "Y";
            this.yDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yDataGridViewTextBoxColumn.Name = "yDataGridViewTextBoxColumn";
            this.yDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataBindingSource3
            // 
            this.dataBindingSource3.DataSource = typeof(holenc.Data);
            // 
            // dataBindingSource2
            // 
            this.dataBindingSource2.DataSource = typeof(holenc.Data);
            // 
            // dataBindingSource1
            // 
            this.dataBindingSource1.DataSource = typeof(holenc.Data);
            // 
            // dataBindingSource
            // 
            this.dataBindingSource.DataSource = typeof(holenc.Data);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1412, 574);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.b_odswiez);
            this.Controls.Add(this.b_ust);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Holenc Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
       
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button b_ust;
        private System.Windows.Forms.Button bp_D;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bp_K;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button bp_U;
        private System.Windows.Forms.Button bp_L;
        private System.Windows.Forms.Button bp_Down;
        private System.Windows.Forms.Button bp_up;
        private System.Windows.Forms.Button b_odswiez;
        private System.Windows.Forms.BindingSource dataBindingSource;
        private System.Windows.Forms.BindingSource dataBindingSource1;
        internal System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dataBindingSource2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bc_right;
        private System.Windows.Forms.Button bc_down;
        private System.Windows.Forms.Button bc_left;
        private System.Windows.Forms.Button bc_plu;
        private System.Windows.Forms.Button bc_op;
        private System.Windows.Forms.Button bc_min;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource dataBindingSource3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nr;
        private System.Windows.Forms.DataGridViewTextBoxColumn xDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Panel panel2;
    }
}

