using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Konversi_Suhu
{
    public partial class Form1 : Form
    {
        double c, f, r, k;
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            c = Convert.ToDouble(Celcius.Text);
            c = c + 5;
            r = c * 4 / 5;
            f = c * 9 / 5 + 32;
            k = c + 273;

            Celcius.Text = Convert.ToString(c);
            Fahrenheit.Text = Convert.ToString(f);
            Reamur.Text = Convert.ToString(r);
            Kelvin.Text = Convert.ToString(k);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            c = Convert.ToDouble(Celcius.Text);
            c = c - 5;
            r = c * 4 / 5;
            f = c * 9 / 5 + 32;
            k = c + 273;


            Celcius.Text = Convert.ToString(c);
            Fahrenheit.Text = Convert.ToString(f);
            Reamur.Text = Convert.ToString(r);
            Kelvin.Text = Convert.ToString(k);

        }

        private void Celcius_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Celcius.Text = "";
            Fahrenheit.Text = "";
            Reamur.Text = "";
            Kelvin.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Benarkah Anda Ingin Keluar  dari aplikasi ini ???", "Konfirmasi",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
                {

                }

                private void label2_Click(object sender, EventArgs e)
                {

                }

                private void button1_Click(object sender, EventArgs e)
                {
                    c = Convert.ToDouble(Celcius.Text);
                    r = (c * 4) / 5;
                    f = (c * 9 / 5) + 32;
                    k = (c + 273);

                    Fahrenheit.Text = Convert.ToString(f);
                    Reamur.Text = Convert.ToString(r);
                    Kelvin.Text = Convert.ToString(k);

                }
            }
        }
 
