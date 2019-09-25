using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SestiDan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {label3.BackColor=Color.Transparent;
                int PrviBroj = Convert.ToInt32(textBox1.Text);
                int DrugiBroj = Convert.ToInt32(textBox2.Text);
                int rez = PrviBroj + DrugiBroj;
                label3.Text = "Rezultat:" + rez;
            }
            catch //(exception ex)  ako me zanima koja je greska u pitanju
            {
                label3.Text = "niste unijeli podatke";
                label3.BackColor = Color.Red;
            }
            //Text = (Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text)).ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                label3.BackColor = Color.Red;
            }
            else {
                label3.BackColor = Color.Transparent;
                label3.Text = "Rezultat";
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Text = "stanje je postavljeno na true";
            }
            else {
                Text = "stanje je postavljeno na false";
            }
        }

        //event handler
        private void button2_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            colorDialog1.ShowDialog();
            BackColor = colorDialog1.Color;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                BackColor = Color.Blue;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                BackColor = Color.Yellow;
            }
            else {
                BackColor = Color.Pink;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox3.Text);
            
        }

        private void izadjiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void postaviBojuNaRozoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Pink;
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }
    }
}
