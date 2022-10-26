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

            string unitRate, standingCharge, initialMeterReading, finalMeterReading;
            double valueDiff;
            const double IMPERIALTOMETRIC = 2.83;
            const double CORRECTION_FACTOR = 1.02264;
            const int CALORIFIC_VALUE = 40;

            initialMeterReading = firstMeterReadingBox.Text;

            finalMeterReading = secondMeterReadingBox.Text;

            string caption = "wrong input detected!";


            //valueDiff = (finalMeterReading - initialMeterReading);

            unitRate = unitRateBox.Text;

            standingCharge = standingChargeBox.Text;

            if (initialMeterReading == "" || finalMeterReading == "")
            {
                string stringValue = initialMeterReading == "" ? "First meter reading is empty, please supply numeric value" : "Second meter reading is empty, please supply numeric value";

                MessageBox.Show(stringValue, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
       
                return;

            }
            else if ((!Char.IsDigit(initialMeterReading, 0)) || (!Char.IsDigit(finalMeterReading, 0)))   
            {
                
                string stringValue = ((!Char.IsDigit(initialMeterReading, 0)) == true) ? $"{initialMeterReading} is not valid entry, please supply numeric value" : $" {finalMeterReading} is not a valid entry, Please supply numeric value";
                
                MessageBox.Show(stringValue, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                return;
            }

            else if (unitRate == "" || standingCharge == "")
            {
                string stringValue = unitRate == "" ? "Unit Rate input is empty, supply a value" : "Standing charge input is empty, supply a value";

                MessageBox.Show(stringValue, caption, MessageBoxButtons.OK, MessageBoxIcon.Hand);

                return;

            }
            else if ((!Char.IsDigit(unitRate, 0)) || (!Char.IsDigit(standingCharge, 0)))
            {
                string stringValue = !Char.IsDigit(unitRate, 0) == true ? "Unit Rate contains a non digit, supply a value" : "Standing charge contains a non input is empty, supply a value";

                MessageBox.Show(stringValue, caption, MessageBoxButtons.OK, MessageBoxIcon.Hand);

                return;
            }

            else
            {
                MessageBox.Show("Thank you, you supplied a digit");
            }














        }

        private bool IsDigit(string text)
        {
            throw new NotImplementedException();
        }
    }
}
