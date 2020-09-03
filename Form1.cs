using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcTemp
{
    public partial class F_TempCalc : Form
    {
        public F_TempCalc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double c, f, k;

            try
            {
                if (txt_celsius.TextLength != 0)
                {
                    c = Convert.ToDouble(txt_celsius.Text);
                    f = c * 1.8 + 32;
                    txt_fahrenheit.Text = Convert.ToString(Math.Round(f, 1));

                    k = c + 273.15;
                    txt_kelvin.Text = Convert.ToString(Math.Round(k, 1));
                }
                else if (txt_fahrenheit.TextLength != 0)
                {
                    f = Convert.ToDouble(txt_fahrenheit.Text);
                    c = (f - 32) / 1.8;
                    txt_celsius.Text = Convert.ToString(Math.Round(c, 1));

                    k = c + 273.15;
                    txt_kelvin.Text = Convert.ToString(Math.Round(k, 1));
                }
                else if (txt_kelvin.TextLength != 0)
                {

                    k = Convert.ToDouble(txt_kelvin.Text);
                    c = k - 273.15;
                    txt_celsius.Text = Convert.ToString(Math.Round(c, 1));

                    f = c * 1.8 + 32;
                    txt_fahrenheit.Text = Convert.ToString(Math.Round(f, 1));
                }
            }
            catch
            {
                MessageBox.Show("Erro ao calcular. Utilize apenas números.");
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_fahrenheit.Clear();
            txt_celsius.Clear();
            txt_kelvin.Clear();
        }

        private void txt_celsius_TextChanged(object sender, EventArgs e)
        {
            if (txt_celsius.TextLength != 0)
            {
                txt_fahrenheit.ReadOnly = true;
                txt_fahrenheit.BackColor = Color.LightGray;
                txt_kelvin.ReadOnly = true;
                txt_kelvin.BackColor = Color.LightGray;
            }
            else
            {
                txt_fahrenheit.ReadOnly = false;
                txt_fahrenheit.BackColor = Color.White;
                txt_kelvin.ReadOnly = false;
                txt_kelvin.BackColor = Color.White;
            }
        }

        private void txt_fahrenheit_TextChanged(object sender, EventArgs e)
        {
            if (txt_fahrenheit.TextLength != 0)
            {
                txt_celsius.ReadOnly = true;
                txt_kelvin.ReadOnly = true;
                txt_kelvin.BackColor = Color.LightGray;
                txt_celsius.BackColor = Color.LightGray;
            }
            else
            {
                txt_celsius.ReadOnly = false;
                txt_celsius.BackColor = Color.White;
                txt_kelvin.ReadOnly = false;
                txt_kelvin.BackColor = Color.White;
            }
        }

        private void txt_kelvin_TextChanged(object sender, EventArgs e)
        {
            if (txt_kelvin.TextLength != 0)
            {
                txt_fahrenheit.ReadOnly = true;
                txt_fahrenheit.BackColor = Color.LightGray;
                txt_celsius.ReadOnly = true;
                txt_celsius.BackColor = Color.LightGray;
            }
            else
            {
                txt_fahrenheit.ReadOnly = false;
                txt_fahrenheit.BackColor = Color.White;
                txt_celsius.ReadOnly = false;
                txt_celsius.BackColor = Color.White;
            }
        }
    }
}
