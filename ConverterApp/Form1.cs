using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConverterApp
    // This program was written by Gail Mosdell
    // It forms the base of a converter program for the OS-Assessment Two for Cert IV
    // Date : February 2017
{
    public partial class frm_Main : Form
    {
        double[] conversion_ratio = new double[5];
        double[] conversions = new double[5];
        int cnt = 0;
          
        public frm_Main()
        {
            InitializeComponent();
            // Global Variables and Constants
            conversion_ratio[0] = 0.393701; //Centimetres to inches
            conversion_ratio[1] = 3.28084; //Metres to Feet
            conversion_ratio[2] = 1.8; //Celsius to Fahrenheit
            conversion_ratio[3] = 0.0328084; //Centimetres to Feet
            conversion_ratio[4] = 0.621371; //Kilometres to Miles
            labelEntryCheck.Hide();
            
        }

        // Centimetres to inches button
        private void btn_centimetres_to_inches_Click(object sender, EventArgs e)
        {
            if (cnt < 5)
            {
                if (double.TryParse(txt_UnitOfMeasure.Text, out conversions[cnt]))
                {
                    txt_Convert.Text = Convert.ToString(conversions[cnt] * conversion_ratio[0]);

                    listBox1.Items.Add(conversions[cnt] + " centimetres is " + txt_Convert.Text + " inches");

                    cnt++;

                }

                else
                {
                    MessageBox.Show("Please enter a numeric value");
                }
            }
            else
            {
                labelEntryCheck.Show();
            }
        }

        // Metres to feet button
        private void btn_metres_to_feet_Click(object sender, EventArgs e)
        {
            if (cnt < 5)
            {
                if (double.TryParse(txt_UnitOfMeasure.Text, out conversions[cnt]))
                {
                    txt_Convert.Text = Convert.ToString(conversions[cnt] * conversion_ratio[1]);

                    listBox1.Items.Add(conversions[cnt] + " metres is " + txt_Convert.Text + " feet");

                    cnt++;

                }

                else
                {
                    MessageBox.Show("Please enter a numeric value");
                }
            }
            else
            {
                labelEntryCheck.Show();
            }
        }

        // Celsius to fahrenheit button
        private void btn_celsius_to_fahrenheit_Click(object sender, EventArgs e)
        {
            if (cnt < 5)
            {
                if (double.TryParse(txt_UnitOfMeasure.Text, out conversions[cnt]))
                {
                    txt_Convert.Text = Convert.ToString(conversions[cnt] * conversion_ratio[2] + 32);

                    listBox1.Items.Add(conversions[cnt] + " degrees celsius is " + txt_Convert.Text + " degrees fahrenheit");

                    cnt++;

                }

                else
                {
                    MessageBox.Show("Please enter a numeric value");
                }
            }
            else
            {
                labelEntryCheck.Show();
            }
        }

        // Centimetres to feet button
        private void btn_centimetres_to_feet_Click(object sender, EventArgs e)
        {
            if (cnt < 5)
            {
                if (double.TryParse(txt_UnitOfMeasure.Text, out conversions[cnt]))
                {
                    txt_Convert.Text = Convert.ToString(conversions[cnt] * conversion_ratio[3]);

                    listBox1.Items.Add(conversions[cnt] + " centimetres is " + txt_Convert.Text + " feet");

                    cnt++;

                }

                else
                {
                    MessageBox.Show("Please enter a numeric value");
                }
            }
            else
            {
                labelEntryCheck.Show();
            }
        }

        // Kilometres to miles button
        private void btn_kilometres_to_miles_Click(object sender, EventArgs e)
        {
            if (cnt < 5)
            {
                if (double.TryParse(txt_UnitOfMeasure.Text, out conversions[cnt]))
                {
                    txt_Convert.Text = Convert.ToString(conversions[cnt] * conversion_ratio[4]);

                    listBox1.Items.Add(conversions[cnt] + " kilometres is " + txt_Convert.Text + " miles");

                    cnt++;

                }

                else
                {
                    MessageBox.Show("Please enter a numeric value");
                }
            }
            else
            {
                labelEntryCheck.Show();
            }
        }

        // Exit Button
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
