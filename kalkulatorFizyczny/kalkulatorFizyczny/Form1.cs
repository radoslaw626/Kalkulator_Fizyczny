using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulatorFizyczny
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void obliczbutton_Click(object sender, EventArgs e)
        {
            double parsedValue;
            if (list1.SelectedItems.Count == 0)
            {
                MessageBox.Show("nie wybrano żadnego parametru");
            }
            else
            {
                if (textBox1.Text == "" ^ textBox1.Text == "" ^ textBox2.Text == "" ^ textBox2.Text == "")
                {
                    MessageBox.Show("Nie podano wartości parametrów");
                }
                if (!double.TryParse(textBox2.Text, out parsedValue))
                {
                    MessageBox.Show("Parametry mogą posiadać tylko cyfry");
                    textBox2.Clear();
                    return;
                }
                if (list1.SelectedItems.Count == 0)
                {
                    MessageBox.Show("nie wybrano żadnego parametru");
                }
                if (list1.SelectedIndex == 0)
                {
                    Double value1 = Double.Parse(textBox1.Text);
                    Double value2 = Double.Parse(textBox2.Text);
                    Double wynik2 = value1 * value2;
                    string wynik1 = wynik2.ToString();
                    label3.Text = wynik1;
                }
                if (list1.SelectedIndex == 1)
                {
                    Double value1 = Double.Parse(textBox1.Text);
                    Double value2 = Double.Parse(textBox2.Text);
                    Double wynik2 = value1 / value2;
                    string wynik1 = wynik2.ToString();
                    label3.Text = wynik1;
                }
                if (list1.SelectedIndex == 2)
                {
                    Double value1 = Double.Parse(textBox1.Text);
                    Double value2 = Double.Parse(textBox2.Text);
                    if (value2 < 0)
                    {
                        MessageBox.Show("masa nie może być ujemna");
                        textBox2.Clear();
                        return;
                    }
                    Double wynik2 = value1 / value2;
                    string wynik1 = wynik2.ToString();
                    label3.Text = wynik1;
                }
                if (list1.SelectedIndex == 3)
                {
                    Double value1 = Double.Parse(textBox1.Text);
                    Double value2 = Double.Parse(textBox2.Text);
                    if (value2 < 0)
                    {
                        MessageBox.Show("prędkość nie może być ujemna");
                        textBox2.Clear();
                        return;
                    }
                    Double wynik2 = value1 * (value2 * value2) / 2;
                    string wynik1 = wynik2.ToString();
                    label3.Text = wynik1;
                }
                if (list1.SelectedIndex == 4)
                {
                    Double value1 = Double.Parse(textBox1.Text);
                    Double value2 = Double.Parse(textBox2.Text);
                    if (value2 < 0)
                    {
                        MessageBox.Show("wysokość nie może być ujemna");
                        textBox2.Clear();
                        return;
                    }
                    Double wynik2 = value1 * value2 * 9.81;
                    string wynik1 = wynik2.ToString();
                    label3.Text = wynik1;
                }
            }
        }
        public void ObliczButton()
        {
            double parsedValue;
            if (list1.SelectedItems.Count == 0)
            {
                MessageBox.Show("nie wybrano żadnego parametru");
            }
            else
            {
                if (textBox1.Text == "" ^ textBox1.Text == "" ^ textBox2.Text == "" ^ textBox2.Text == "")
                {
                    MessageBox.Show("Nie podano wartości parametrów");
                }
                if (!double.TryParse(textBox2.Text, out parsedValue))
                {
                    MessageBox.Show("Parametry mogą posiadać tylko cyfry");
                    textBox2.Clear();
                    return;
                }
                if (list1.SelectedItems.Count == 0)
                {
                    MessageBox.Show("nie wybrano żadnego parametru");
                }
                if (list1.SelectedIndex == 0)
                {
                    Double value1 = Double.Parse(textBox1.Text);
                    Double value2 = Double.Parse(textBox2.Text);
                    Double wynik2 = value1 * value2;
                    string wynik1 = wynik2.ToString();
                    label3.Text = wynik1;
                }
                if (list1.SelectedIndex == 1)
                {
                    Double value1 = Double.Parse(textBox1.Text);
                    Double value2 = Double.Parse(textBox2.Text);
                    Double wynik2 = value1 / value2;
                    string wynik1 = wynik2.ToString();
                    label3.Text = wynik1;
                }
                if (list1.SelectedIndex == 2)
                {
                    Double value1 = Double.Parse(textBox1.Text);
                    Double value2 = Double.Parse(textBox2.Text);
                    Double wynik2 = value1 / value2;
                    string wynik1 = wynik2.ToString();
                    label3.Text = wynik1;
                }
                if (list1.SelectedIndex == 3)
                {
                    Double value1 = Double.Parse(textBox1.Text);
                    Double value2 = Double.Parse(textBox2.Text);
                    if (value2 < 0)
                    {
                        MessageBox.Show("prędkość nie może być ujemna");
                        textBox2.Clear();
                        return;
                    }
                    Double wynik2 = value1 * (value2 * value2) / 2;
                    string wynik1 = wynik2.ToString();
                    label3.Text = wynik1;
                }
                if (list1.SelectedIndex == 4)
                {
                    Double value1 = Double.Parse(textBox1.Text);
                    Double value2 = Double.Parse(textBox2.Text);
                    if (value2 < 0)
                    {
                        MessageBox.Show("wysokość nie może być ujemna");
                        textBox2.Clear();
                        return;
                    }
                    Double wynik2 = value1 * value2 * 9.81;
                    string wynik1 = wynik2.ToString();
                    label3.Text = wynik1;
                }
            }
        }
        private void list1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Text = "";
            if (list1.SelectedItems.Count != 0)
            {
                jednostka4.Visible = true;
            }

            if (list1.SelectedIndex == 0)
            {
                textBox1.Visible = true;
                jednostka1.Visible = true;
                parametr1.Visible = true;
                textBox2.Visible = true;
                jednostka2.Visible = true;
                parametr2.Visible = true;
                textBox3.Visible = false;
                jednostka3.Visible = false;
                parametr3.Visible = false;
                parametr1.Text = "masa";
                parametr2.Text = "przyśpieszenie";
                jednostka1.Text = "kg";
                jednostka2.Text = "m/s^2";
                jednostka4.Text = "N";
                pictureBox1.Image = Properties.Resources.Sila;
                pictureBox2.Visible = false;
            }
            if (list1.SelectedIndex == 1)
            {
                textBox1.Visible = true;
                jednostka1.Visible = true;
                parametr1.Visible = true;
                textBox2.Visible = true;
                jednostka2.Visible = true;
                parametr2.Visible = true;
                textBox3.Visible = false;
                jednostka3.Visible = false;
                parametr3.Visible = false;
                parametr1.Text = "siła";
                parametr2.Text = "przyśpieszenie";
                jednostka1.Text = "N";
                jednostka2.Text = "m/s^2";
                jednostka4.Text = "kg";
                pictureBox1.Image = Properties.Resources.Masa;
                pictureBox2.Visible = false;
            }
            if (list1.SelectedIndex == 2)
            {
                textBox1.Visible = true;
                jednostka1.Visible = true;
                parametr1.Visible = true;
                textBox2.Visible = true;
                jednostka2.Visible = true;
                parametr2.Visible = true;
                textBox3.Visible = false;
                jednostka3.Visible = false;
                parametr3.Visible = false;
                parametr1.Text = "siła";
                parametr2.Text = "masa";
                jednostka1.Text = "N";
                jednostka2.Text = "kg";
                jednostka4.Text = "m/s^2";
                pictureBox1.Image = Properties.Resources.Przyspieszenie;
                pictureBox2.Visible = false;
            }
            if (list1.SelectedIndex == 3)
            {
                textBox1.Visible = true;
                jednostka1.Visible = true;
                parametr1.Visible = true;
                textBox2.Visible = true;
                jednostka2.Visible = true;
                parametr2.Visible = true;
                textBox3.Visible = false;
                jednostka3.Visible = false;
                parametr3.Visible = false;
                parametr1.Text = "masa";
                parametr2.Text = "prędkość";
                jednostka1.Text = "kg";
                jednostka2.Text = "m/s";
                jednostka4.Text = "J";
                pictureBox1.Image = Properties.Resources.EnergiaK1;
                pictureBox2.Visible = false;
            }
            if (list1.SelectedIndex == 4)
            {
                textBox1.Visible = true;
                jednostka1.Visible = true;
                parametr1.Visible = true;
                textBox2.Visible = true;
                jednostka2.Visible = true;
                parametr2.Visible = true;
                textBox3.Visible = false;
                jednostka3.Visible = false;
                parametr3.Visible = false;
                parametr1.Text = "masa";
                parametr2.Text = "wysokość";
                jednostka1.Text = "kg";
                jednostka2.Text = "m";
                jednostka4.Text = "J";
                pictureBox1.Image = Properties.Resources.EnergiaP;
                pictureBox2.Visible = true;
                pictureBox2.Image = Properties.Resources.przyspieszenieG;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("."))
            {
                MessageBox.Show("użyj znaku ',' zamiast '.'");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                textBox1.SelectionStart = textBox1.Text.Length;
                textBox1.SelectionLength = 0;
            }
            string literki = "qwertyuiopasdfghjklzxcvbnm";
            for (int i = 0; i < literki.Length; i++)
                if (textBox1.Text.Contains(literki[i]))
                {
                    MessageBox.Show("Parametr nie moze posiadac liter");
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                    textBox1.SelectionStart = textBox1.Text.Length;
                    textBox1.SelectionLength = 0;
                }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (list1.SelectedIndex == 1 ^ list1.SelectedIndex == 2)
                if (textBox2.Text == "0")
                {
                    MessageBox.Show("mianownik nie może być równy 0");
                    textBox2.Clear();
                }
            if (textBox2.Text.Contains("."))
            {
                MessageBox.Show("użyj znaku ',' zamiast '.'");
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
                textBox2.SelectionStart = textBox2.Text.Length;
                textBox2.SelectionLength = 0;
            }
            string literki = "qwertyuiopasdfghjklzxcvbnm";
            for (int i = 0; i < literki.Length; i++)
                if (textBox2.Text.Contains(literki[i]))
                {
                    MessageBox.Show("Parametr nie moze posiadac liter");
                    textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
                    textBox2.SelectionStart = textBox2.Text.Length;
                    textBox2.SelectionLength = 0;
                }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Contains("."))
            {
                MessageBox.Show("użyj znaku ',' zamiast '.'");
                textBox3.Text = textBox3.Text.Remove(textBox3.Text.Length - 1);
                textBox3.SelectionStart = textBox3.Text.Length;
                textBox3.SelectionLength = 0;
            }
            string literki = "qwertyuiopasdfghjklzxcvbnm";
            for (int i = 0; i < literki.Length; i++)
                if (textBox1.Text.Contains(literki[i]))
                {
                    MessageBox.Show("Parametr nie moze posiadac liter");
                    textBox3.Text = textBox3.Text.Remove(textBox3.Text.Length - 1);
                    textBox3.SelectionStart = textBox3.Text.Length;
                    textBox3.SelectionLength = 0;
                }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void parametr3_Click(object sender, EventArgs e)
        {

        }

        private void wynik_TextChanged(object sender, EventArgs e)
        {

        }
        int mouseX = 0, mouseY = 0, mouseinX = 0, mouseinY = 0;
        bool mouseDown;

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label4.Text = "";

        }

        public void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count == 0 ^ listBox2.SelectedItems.Count == 0 ^ listBox1.SelectedItems.Count == 0 && listBox2.SelectedItems.Count == 0)
            {
                MessageBox.Show("Nie wybrano przedrostków");
            }
            else if (listBox1.SelectedIndex == 0 & listBox2.SelectedIndex != 1 & listBox2.SelectedIndex != 0 ^ listBox1.SelectedIndex == 1 & listBox2.SelectedIndex != 1 & listBox2.SelectedIndex != 0 ^ listBox2.SelectedIndex == 0 & listBox1.SelectedIndex != 1 & listBox1.SelectedIndex != 0 ^ listBox2.SelectedIndex == 1 & listBox1.SelectedIndex != 1 & listBox1.SelectedIndex != 0)
            {
                MessageBox.Show("Stopnie i radiany mogą byc przeliczane tylko między sobą");
            }
            else
            {

                double[] tab1 = new double[20];
                tab1[0] = 57.297;
                tab1[1] = 1;
                tab1[2] = 0.000000000001;
                tab1[3] = 0.000000001;
                tab1[4] = 0.000001;
                tab1[5] = 0.001;
                tab1[6] = 0.01;
                tab1[7] = 0.1;
                tab1[8] = 1;
                tab1[9] = 10;
                tab1[10] = 100;
                tab1[11] = 1000;
                tab1[12] = 1000000;
                tab1[13] = 1000000000;
                tab1[14] = 1000000000000;
                tab1[15] = 1000000000000000;
                double tx4 = Double.Parse(textBox4.Text);
                double calculated = tx4 * tab1[listBox1.SelectedIndex] / tab1[listBox2.SelectedIndex];
                string lb4 = calculated.ToString();
                label4.Text = lb4;
            }
        }
        public void PrzelicznikButton()
        {
            if (listBox1.SelectedItems.Count == 0 ^ listBox2.SelectedItems.Count == 0 ^ listBox1.SelectedItems.Count == 0 && listBox2.SelectedItems.Count == 0)
            {
                MessageBox.Show("Nie wybrano przedrostków");
            }
            else if (listBox1.SelectedIndex == 0 & listBox2.SelectedIndex != 1 & listBox2.SelectedIndex != 0 ^ listBox1.SelectedIndex == 1 & listBox2.SelectedIndex != 1 & listBox2.SelectedIndex != 0 ^ listBox2.SelectedIndex == 0 & listBox1.SelectedIndex != 1 & listBox1.SelectedIndex != 0 ^ listBox2.SelectedIndex == 1 & listBox1.SelectedIndex != 1 & listBox1.SelectedIndex != 0)
            {
                MessageBox.Show("Stopnie i radiany mogą byc przeliczane tylko między sobą");
            }
            else
            {

                double[] tab1 = new double[20];
                tab1[0] = 57.297;
                tab1[1] = 1;
                tab1[2] = 0.000000000001;
                tab1[3] = 0.000000001;
                tab1[4] = 0.000001;
                tab1[5] = 0.001;
                tab1[6] = 0.01;
                tab1[7] = 0.1;
                tab1[8] = 1;
                tab1[9] = 10;
                tab1[10] = 100;
                tab1[11] = 1000;
                tab1[12] = 1000000;
                tab1[13] = 1000000000;
                tab1[14] = 1000000000000;
                tab1[15] = 1000000000000000;
                double tx4 = Double.Parse(textBox4.Text);
                double calculated = tx4 * tab1[listBox1.SelectedIndex] / tab1[listBox2.SelectedIndex];
                string lb4 = calculated.ToString();
                label4.Text = lb4;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int temp = listBox1.SelectedIndex;
            listBox1.SelectedIndex = listBox2.SelectedIndex;
            listBox2.SelectedIndex = temp;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label4.Text = "";
        }

        private void pictureBox4_Paint(object sender, PaintEventArgs e)
        {

            float pc4W = pictureBox4.Width;
            float pc4H = pictureBox4.Height;
            Pen VectorA = new Pen(Brushes.Red);
            VectorA.Width = 2;
            Graphics g = e.Graphics;

            g.DrawLine(Pens.White, pictureBox4.Width / 2, 10, pictureBox4.Width / 2, pictureBox4.Height - 10);
            g.DrawLine(Pens.White, 10, pictureBox4.Height / 2, pictureBox4.Width - 10, pictureBox4.Height / 2);
            g.DrawLine(VectorA, pc4H / 2, pc4W / 2, pc4W - 10, 10);



        }

        
        private void buttonObliczW_Click(object sender, EventArgs e)
        {
            if (textBoxXA.Text.Length != 0 & textBoxXB.Text.Length != 0 & textBoxYA.Text.Length != 0 & textBoxYB.Text.Length != 0)
            {
                Double XA = Double.Parse(textBoxXA.Text);
                Double XB = Double.Parse(textBoxXB.Text);
                Double YA = Double.Parse(textBoxYA.Text);
                Double YB = Double.Parse(textBoxYB.Text);
                Double XZ = XA + XB;
                Double YZ = YA + YB;
                string XZs = XZ.ToString();
                string YZs = YZ.ToString();
                labelXZ.Text = XZs;
                labelYZ.Text = YZs;
            }
            else
                MessageBox.Show("Należy podać wartości wektorów A i B");
        }

        private void textBoxYZ_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxXZ_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelXZ_Click(object sender, EventArgs e)
        {

        }

        private void buttonRysuj_Click(object sender, EventArgs e)
        {
            
            
            pictureBox4.Image = new Bitmap(pictureBox4.Width, pictureBox4.Height);
            using (var g = Graphics.FromImage(pictureBox4.Image))
            {
                float pc4W = pictureBox4.Width;
                float pc4H = pictureBox4.Height;
                Pen VectorA = new Pen(Brushes.Red);
                VectorA.Width = 3;
                Pen VectorB = new Pen(Brushes.Blue);
                VectorB.Width = 3;
                Pen VectorZ = new Pen(Brushes.Purple);
                VectorZ.Width = 3;
                g.DrawLine(Pens.White, pictureBox4.Width / 2, 10, pictureBox4.Width / 2, pictureBox4.Height - 10);
                g.DrawLine(Pens.White, pictureBox4.Width / 2, 10, pictureBox4.Width / 2-5, 15);
                g.DrawLine(Pens.White, pictureBox4.Width / 2, 10, pictureBox4.Width / 2+5, 15);
                g.DrawLine(Pens.White,pictureBox4.Width-10,pictureBox4.Height/2, pictureBox4.Width - 15, pictureBox4.Height / 2+5);
                g.DrawLine(Pens.White,pictureBox4.Width-10,pictureBox4.Height/2, pictureBox4.Width - 15, pictureBox4.Height / 2-5);
                g.DrawLine(Pens.White, 10, pictureBox4.Height / 2, pictureBox4.Width - 10, pictureBox4.Height / 2);
                if(textBoxXA.TextLength!=0 & textBoxYA.TextLength != 0)
                {
                    float XA = Single.Parse(textBoxXA.Text);
                    float YA = Single.Parse(textBoxYA.Text);
                    g.DrawLine(VectorA, pc4W / 2, pc4H / 2, pc4W/2+XA, pc4H/2-YA);
                }
                if (textBoxXB.TextLength != 0 & textBoxYB.TextLength != 0)
                {
                    float XB = Single.Parse(textBoxXB.Text);
                    float YB = Single.Parse(textBoxYB.Text);
                    g.DrawLine(VectorB, pc4W / 2, pc4H / 2, pc4W / 2 + XB, pc4H / 2 - YB);
                }
                if (labelXZ.Text.Length!=0 & labelYZ.Text.Length != 0)
                {
                    float XZ = Single.Parse(labelXZ.Text);
                    float YZ = Single.Parse(labelYZ.Text);
                    g.DrawLine(VectorZ, pc4W / 2, pc4H / 2, pc4W / 2 + XZ, pc4H / 2 - YZ);
                }

                pictureBox4.Refresh();

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBoxXA.TextLength != 0 & textBoxYA.TextLength != 0)
            {
                double XA = Double.Parse(textBoxXA.Text);
                double YA = Double.Parse(textBoxYA.Text);
                double dlugosc = Math.Sqrt(Math.Pow(XA,2)+ Math.Pow(YA, 2));
                string dlugoscStr= dlugosc.ToString();
                dlugoscA.Text = dlugoscStr;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBoxXB.TextLength != 0 & textBoxYB.TextLength != 0)
            {
                double XB = Double.Parse(textBoxXB.Text);
                double YB = Double.Parse(textBoxYB.Text);
                double dlugosc = Math.Sqrt(Math.Pow(XB, 2) + Math.Pow(YB, 2));
                string dlugoscStr = dlugosc.ToString();
                dlugoscB.Text = dlugoscStr;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (labelXZ.Text.Length != 0 & labelYZ.Text.Length != 0)
            {
                double XZ = Double.Parse(labelXZ.Text);
                double YZ = Double.Parse(labelYZ.Text);
                double dlugosc = Math.Sqrt(Math.Pow(XZ, 2) + Math.Pow(YZ, 2));
                string dlugoscStr = dlugosc.ToString();
                dlugoscZ.Text = dlugoscStr;
            }
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - mouseinX;
                mouseY = MousePosition.Y - mouseinY;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mouseinX = MousePosition.X - Bounds.X;
            mouseinY = MousePosition.Y - Bounds.Y;
        }

    }
}
