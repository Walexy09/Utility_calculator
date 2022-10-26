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
            double valueDiff, consumptionKWH;
            decimal gasPrice;
            const double IMPERIALTOMETRIC = 2.83;
            const double CORRECTION_FACTOR = 1.02264;
            const int CALORIFIC_VALUE = 39;

            int DAYS_PER_MONTH = int.Parse(noOfDaysBox.Text);

            const double CONVERSION_KWH = 3.6;

            initialMeterReading = firstMeterReadingBox.Text;

            finalMeterReading = secondMeterReadingBox.Text;

            string caption = "wrong input detected!";

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

            /*else
            {
                MessageBox.Show("Thank you, you supplied a digit");
            }*/


            if (int.Parse(finalMeterReading) < int.Parse(initialMeterReading)) {

                string message = $"Current Meter Reading: {finalMeterReading} cannot be lower than the initial Meter Reading:  {initialMeterReading}, \n please " +
                    $"check the values supplied to be sure they are correct and try again!!";

                string captionTitle = "invalid user inputs detected";

                MessageBox.Show(message, captionTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);

                return;
            }

            valueDiff = double.Parse(finalMeterReading) - double.Parse(initialMeterReading);

            double result1 = valueDiff * IMPERIALTOMETRIC;

            double result2 = result1 * CORRECTION_FACTOR;

            double caloricValueInt = (double)CALORIFIC_VALUE;

            double result3 = result2 * caloricValueInt;

            consumptionKWH = Math.Round((result3 / CONVERSION_KWH), 3);

            consumptionBox.Text = consumptionKWH.ToString();

            decimal standChargeDecimal = decimal.Parse(standingCharge);

            double unitRateDouble = double.Parse(unitRate);

            decimal chargePerMonth = Math.Round(((standChargeDecimal * (decimal)DAYS_PER_MONTH))/100, 2);

            standingChargePerMonthLabel.Text = "£" + chargePerMonth.ToString();

            decimal totalGasPrice = Math.Round(( (decimal)consumptionKWH * (decimal)unitRateDouble )/100 + chargePerMonth, 2);

            resultBox.Text = totalGasPrice.ToString();


            string finalResult = $"Your Bill is as follows: " +
                $"\n\n 1. Standing Charge per {DAYS_PER_MONTH} days:  £{chargePerMonth}." +
                $"\n\n 2. Gas Consumption Kwh for {DAYS_PER_MONTH} days:  {Math.Round(consumptionKWH, 2)} Kwh. " +
                $"\n\n 3. Total Gas Price Consumed for {DAYS_PER_MONTH} days period: £{totalGasPrice}.";

            MessageBox.Show(finalResult, "Your Gas Bill Usage", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private bool IsDigit(string text)
        {
            throw new NotImplementedException();
        }

        private void reserBut_Click(object sender, EventArgs e)
        {



        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string version = "1.0.0";
            string author = "Joshua Ajayi Adewale";
            string email = "walexy85@gmail.com";
            string title = $"\n\n Utily Bills Calculator.\n\n Written by : {author}. \n\n Version: {version}. \n\n You can contact me on " +
                $"email address: {email}";

            MessageBox.Show(title, "About App", MessageBoxButtons.OK);
        }
    }
}
