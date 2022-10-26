using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utility_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calculateGasBut_Click(object sender, EventArgs e)
        {

            string unitRate, standingCharge;

            unitRate = unitRateBox.Text;
            standingCharge = standingChargeBox.Text;

            if (unitRate == "" || standingCharge == "")
            {
                MessageBox.Show("Input is empty, supply a value");
                Console.WriteLine("Please supply a numeric value");
                return;

            }
            else if ( (!Char.IsDigit(unitRate, 0)) || (!Char.IsDigit(standingCharge, 0)))
            {
                MessageBox.Show("Input does not contain a digit, please supply a digit");
                Console.WriteLine("Please supply a numeric value");
                return;
            }

            else {
                MessageBox.Show("Thank you, you supplied a digit");
            }

            


           




        }

        private bool IsDigit(string text)
        {
            throw new NotImplementedException();
        }
    }
}
