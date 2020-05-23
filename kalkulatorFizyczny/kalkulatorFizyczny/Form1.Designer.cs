namespace kalkulatorFizyczny
{
     public partial class Form1
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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Parametry = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.wynik = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.list1 = new System.Windows.Forms.ListBox();
            this.jednostka4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.jednostka3 = new System.Windows.Forms.Label();
            this.jednostka1 = new System.Windows.Forms.Label();
            this.jednostka2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.parametr1 = new System.Windows.Forms.Label();
            this.parametr2 = new System.Windows.Forms.Label();
            this.parametr3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage2.SuspendLayout();
            this.Parametry.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "comment_1582655271AXZbsSDJODfX2dUPcnkqAs.jpg");
            this.imageList1.Images.SetKeyName(1, "przyspieszenieG.PNG");
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(59)))));
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.textBox6);
            this.tabPage2.Controls.Add(this.textBox5);
            this.tabPage2.Controls.Add(this.listBox2);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(886, 479);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "         Przelicznik         ";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.label4.Location = new System.Drawing.Point(451, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 7;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.Location = new System.Drawing.Point(336, 239);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 79);
            this.button5.TabIndex = 6;
            this.button5.Text = "Przelicz";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.button4.BackgroundImage = global::kalkulatorFizyczny.Properties.Resources.swap_horizontal_change_reverse_arrow_right_left_32111;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(368, 90);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 34);
            this.button4.TabIndex = 5;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(442, 156);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(128, 46);
            this.textBox6.TabIndex = 4;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(59)))));
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Microsoft YaHei", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox5.Location = new System.Drawing.Point(376, 156);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(52, 46);
            this.textBox5.TabIndex = 3;
            this.textBox5.Text = "=";
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.listBox2.ForeColor = System.Drawing.Color.White;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 19;
            this.listBox2.Items.AddRange(new object[] {
            "Radiany",
            "Stopnie",
            "Nano",
            "Piko",
            "Mikro",
            "Mili",
            "Centy",
            "Decy",
            "-",
            "Deka",
            "Hekta",
            "Kilo",
            "Mega",
            "Giga",
            "Tera",
            "Peta"});
            this.listBox2.Location = new System.Drawing.Point(595, 76);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(157, 213);
            this.listBox2.TabIndex = 2;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Location = new System.Drawing.Point(217, 156);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(128, 46);
            this.textBox4.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Items.AddRange(new object[] {
            "Radiany",
            "Stopnie",
            "Nano",
            "Piko",
            "Mikro",
            "Mili",
            "Centy",
            "Decy",
            "-",
            "Deka",
            "Hekta",
            "Kilo",
            "Mega",
            "Giga",
            "Tera",
            "Peta"});
            this.listBox1.Location = new System.Drawing.Point(37, 76);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(157, 213);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Parametry
            // 
            this.Parametry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(59)))));
            this.Parametry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Parametry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Parametry.Controls.Add(this.label3);
            this.Parametry.Controls.Add(this.wynik);
            this.Parametry.Controls.Add(this.panel1);
            this.Parametry.Controls.Add(this.list1);
            this.Parametry.Controls.Add(this.jednostka4);
            this.Parametry.Controls.Add(this.label1);
            this.Parametry.Controls.Add(this.jednostka3);
            this.Parametry.Controls.Add(this.jednostka1);
            this.Parametry.Controls.Add(this.jednostka2);
            this.Parametry.Controls.Add(this.button1);
            this.Parametry.Controls.Add(this.textBox1);
            this.Parametry.Controls.Add(this.textBox2);
            this.Parametry.Controls.Add(this.textBox3);
            this.Parametry.Controls.Add(this.parametr1);
            this.Parametry.Controls.Add(this.parametr2);
            this.Parametry.Controls.Add(this.parametr3);
            this.Parametry.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Parametry.Location = new System.Drawing.Point(4, 34);
            this.Parametry.Margin = new System.Windows.Forms.Padding(0);
            this.Parametry.Name = "Parametry";
            this.Parametry.Size = new System.Drawing.Size(886, 479);
            this.Parametry.TabIndex = 0;
            this.Parametry.Text = "          Parametry          ";
            this.Parametry.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.label3.Location = new System.Drawing.Point(453, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 19);
            this.label3.TabIndex = 18;
            // 
            // wynik
            // 
            this.wynik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.wynik.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wynik.Enabled = false;
            this.wynik.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wynik.ForeColor = System.Drawing.Color.Black;
            this.wynik.HideSelection = false;
            this.wynik.Location = new System.Drawing.Point(444, 240);
            this.wynik.Multiline = true;
            this.wynik.Name = "wynik";
            this.wynik.ReadOnly = true;
            this.wynik.Size = new System.Drawing.Size(214, 66);
            this.wynik.TabIndex = 11;
            this.wynik.TextChanged += new System.EventHandler(this.wynik_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(240, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 203);
            this.panel1.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 105);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(3, 114);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // list1
            // 
            this.list1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.list1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.list1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.list1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.list1.FormattingEnabled = true;
            this.list1.ItemHeight = 19;
            this.list1.Items.AddRange(new object[] {
            "Siła (2 ZDN)",
            "Masa (2 ZDN)",
            "Przyśpieszenie (2 ZDN)",
            "Energia kinetyczna",
            "Enetgia potencjalna"});
            this.list1.Location = new System.Drawing.Point(48, 31);
            this.list1.Name = "list1";
            this.list1.Size = new System.Drawing.Size(169, 154);
            this.list1.TabIndex = 13;
            this.list1.SelectedIndexChanged += new System.EventHandler(this.list1_SelectedIndexChanged);
            // 
            // jednostka4
            // 
            this.jednostka4.AutoSize = true;
            this.jednostka4.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.jednostka4.ForeColor = System.Drawing.Color.White;
            this.jednostka4.Location = new System.Drawing.Point(661, 261);
            this.jednostka4.Name = "jednostka4";
            this.jednostka4.Size = new System.Drawing.Size(67, 25);
            this.jednostka4.TabIndex = 12;
            this.jednostka4.Text = "label6";
            this.jednostka4.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(438, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Wynik:";
            // 
            // jednostka3
            // 
            this.jednostka3.AutoSize = true;
            this.jednostka3.ForeColor = System.Drawing.Color.White;
            this.jednostka3.Location = new System.Drawing.Point(661, 158);
            this.jednostka3.Name = "jednostka3";
            this.jednostka3.Size = new System.Drawing.Size(50, 19);
            this.jednostka3.TabIndex = 10;
            this.jednostka3.Text = "label6";
            this.jednostka3.Visible = false;
            // 
            // jednostka1
            // 
            this.jednostka1.AutoSize = true;
            this.jednostka1.ForeColor = System.Drawing.Color.White;
            this.jednostka1.Location = new System.Drawing.Point(664, 63);
            this.jednostka1.Name = "jednostka1";
            this.jednostka1.Size = new System.Drawing.Size(50, 19);
            this.jednostka1.TabIndex = 8;
            this.jednostka1.Text = "label4";
            this.jednostka1.Visible = false;
            // 
            // jednostka2
            // 
            this.jednostka2.AutoSize = true;
            this.jednostka2.ForeColor = System.Drawing.Color.White;
            this.jednostka2.Location = new System.Drawing.Point(662, 110);
            this.jednostka2.Name = "jednostka2";
            this.jednostka2.Size = new System.Drawing.Size(50, 19);
            this.jednostka2.TabIndex = 9;
            this.jednostka2.Text = "label5";
            this.jednostka2.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.CausesValidation = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(48, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 73);
            this.button1.TabIndex = 0;
            this.button1.Tag = "Oblicz";
            this.button1.Text = "Oblicz";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.obliczbutton_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei", 8.5F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(444, 65);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 17);
            this.textBox1.TabIndex = 3;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Microsoft YaHei", 8.5F, System.Drawing.FontStyle.Bold);
            this.textBox2.Location = new System.Drawing.Point(444, 110);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(214, 17);
            this.textBox2.TabIndex = 5;
            this.textBox2.Visible = false;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox3.Location = new System.Drawing.Point(444, 157);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(214, 17);
            this.textBox3.TabIndex = 7;
            this.textBox3.Visible = false;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // parametr1
            // 
            this.parametr1.AutoSize = true;
            this.parametr1.ForeColor = System.Drawing.Color.White;
            this.parametr1.Location = new System.Drawing.Point(438, 43);
            this.parametr1.Name = "parametr1";
            this.parametr1.Size = new System.Drawing.Size(50, 19);
            this.parametr1.TabIndex = 2;
            this.parametr1.Text = "label1";
            this.parametr1.Visible = false;
            // 
            // parametr2
            // 
            this.parametr2.AutoSize = true;
            this.parametr2.ForeColor = System.Drawing.Color.White;
            this.parametr2.Location = new System.Drawing.Point(438, 88);
            this.parametr2.Name = "parametr2";
            this.parametr2.Size = new System.Drawing.Size(50, 19);
            this.parametr2.TabIndex = 4;
            this.parametr2.Text = "label2";
            this.parametr2.Visible = false;
            // 
            // parametr3
            // 
            this.parametr3.AutoSize = true;
            this.parametr3.ForeColor = System.Drawing.Color.White;
            this.parametr3.Location = new System.Drawing.Point(438, 135);
            this.parametr3.Name = "parametr3";
            this.parametr3.Size = new System.Drawing.Size(50, 19);
            this.parametr3.TabIndex = 6;
            this.parametr3.Text = "label3";
            this.parametr3.Visible = false;
            this.parametr3.Click += new System.EventHandler(this.parametr3_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Parametry);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tabControl1.ItemSize = new System.Drawing.Size(150, 30);
            this.tabControl1.Location = new System.Drawing.Point(-5, 27);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.ShowToolTips = true;
            this.tabControl1.Size = new System.Drawing.Size(894, 517);
            this.tabControl1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(-5, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(799, 27);
            this.panel2.TabIndex = 18;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::kalkulatorFizyczny.Properties.Resources.Science_Physics_icon22;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(9, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 23);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(38, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "KALKULATOR FIZYCZNY";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::kalkulatorFizyczny.Properties.Resources.download__3_;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(728, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 24);
            this.button3.TabIndex = 1;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.button2.BackgroundImage = global::kalkulatorFizyczny.Properties.Resources.download__2_;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(762, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(34, 24);
            this.button2.TabIndex = 0;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button2_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(790, 455);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = " Kalkulator fizyczny";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.Parametry.ResumeLayout(false);
            this.Parametry.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage Parametry;
        public System.Windows.Forms.ListBox list1;
        private System.Windows.Forms.Label jednostka4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label jednostka3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label jednostka1;
        private System.Windows.Forms.Label jednostka2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox wynik;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label parametr1;
        private System.Windows.Forms.Label parametr2;
        private System.Windows.Forms.Label parametr3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        public System.Windows.Forms.ListBox listBox2;
        public System.Windows.Forms.TextBox textBox4;
        public System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
    }
}

