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
        
        public frm_Main()
        {
            InitializeComponent();
            // Global Variables and Constants
            conversion_ratio[0] = 0.393701; //Centimetres to inches
            conversion_ratio[1] = 3.28084; //Metres to Feet
            conversion_ratio[2] = 1.8; //Celsius to Fahrenheit
            conversion_ratio[3] = 0.0328084; //Centimetres to Feet
            conversion_ratio[4] = 0.621371; //Kilometres to Miles
            
        }
        
        // Centimetres to inches button
        private void btn_centimetres_to_inches_Click(object sender, EventArgs e)
        {
            double checkiftrue;
            if (double.TryParse(txt_UnitOfMeasure.Text, out checkiftrue))
            {
                txt_Convert.Text = Convert.ToString(Convert.ToDouble(txt_UnitOfMeasure.Text) * conversion_ratio[0]);
            }
            else
            {
                MessageBox.Show("Please enter a numeric value");
            }
        }

        // Metres to feet button
        private void btn_metres_to_feet_Click(object sender, EventArgs e)
        {
            double checkiftrue;
            if (double.TryParse(txt_UnitOfMeasure.Text, out checkiftrue))
            {
                txt_Convert.Text = Convert.ToString(Convert.ToDouble(txt_UnitOfMeasure.Text) * conversion_ratio[1]);
            }
            else
            {
                MessageBox.Show("Please enter a numeric value");
            }
        }

        // Celsius to fahrenheit button
        private void btn_celsius_to_fahrenheit_Click(object sender, EventArgs e)
        {
            double checkiftrue;
            if (double.TryParse(txt_UnitOfMeasure.Text, out checkiftrue))
            {
                txt_Convert.Text = Convert.ToString(Convert.ToDouble(txt_UnitOfMeasure.Text) * conversion_ratio[2] + 32);
            }
            else
            {
                MessageBox.Show("Please enter a numeric value");
            }
        }

        // Centimetres to feet button
        private void btn_centimetres_to_feet_Click(object sender, EventArgs e)
        {
            double checkiftrue;
            if (double.TryParse(txt_UnitOfMeasure.Text, out checkiftrue))
            {
                txt_Convert.Text = Convert.ToString(Convert.ToDouble(txt_UnitOfMeasure.Text) * conversion_ratio[3]);
            }
            else
            {
                MessageBox.Show("Please enter a numeric value");
            }
        }

        // Kilometres to miles button
        private void btn_kilometres_to_miles_Click(object sender, EventArgs e)
        {
            double checkiftrue;
            if (double.TryParse(txt_UnitOfMeasure.Text, out checkiftrue))
            {
                txt_Convert.Text = Convert.ToString(Convert.ToDouble(txt_UnitOfMeasure.Text) * conversion_ratio[4]);
            }
            else
            {
                MessageBox.Show("Please enter a numeric value");
            }
        }

        // Exit Button
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
