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

        private void calculateGasBut_Click(object sender, EventArgs e)
        {

            string unitRate, standingCharge, initialMeterReading, finalMeterReading;
            double valueDiff, consumptionKWH;
            //decimal gasPrice;
            const double IMPERIALTOMETRIC = 2.83;
            const double CORRECTION_FACTOR = 1.02264;
            const int CALORIFIC_VALUE = 39;

            int DAYS_PER_MONTH = int.Parse(noOfDaysBox.Text);

            const double CONVERSION_KWH = 3.6;

            initialMeterReading = firstMeterReadingBox.Text;

            finalMeterReading = secondMeterReadingBox.Text;

           // string caption = "wrong input detected!";

            unitRate = unitRateBox.Text;

            standingCharge = standingChargeBox.Text;

            //bool invalidInputDetected = false;


            validateMeterReadings(initialMeterReading, finalMeterReading, unitRate, standingCharge);

            /*if (initialMeterReading == "" || finalMeterReading == "")
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
            }*/

            /*else
            {
                MessageBox.Show("Thank you, you supplied a digit");
            }*/


            /*if (int.Parse(finalMeterReading) < int.Parse(initialMeterReading)) {

                string message = $"Current Meter Reading: {finalMeterReading} cannot be lower than the initial Meter Reading:  {initialMeterReading}, \n please " +
                    $"check the values supplied to be sure they are correct and try again!!";

                string captionTitle = "invalid user inputs detected";

                MessageBox.Show(message, captionTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);

                return;
            }*/

            if ((int.Parse(finalMeterReading) >= int.Parse(initialMeterReading))) {

                valueDiff = double.Parse(finalMeterReading) - double.Parse(initialMeterReading);

                double result1 = valueDiff * IMPERIALTOMETRIC;

                double result2 = result1 * CORRECTION_FACTOR;

                double caloricValueInt = (double)CALORIFIC_VALUE;

                double result3 = result2 * caloricValueInt;

                consumptionKWH = Math.Round((result3 / CONVERSION_KWH), 3);

                consumptionBox.Text = consumptionKWH.ToString();

                decimal standChargeDecimal = decimal.Parse(standingCharge);

                double unitRateDouble = double.Parse(unitRate);

                gasStandingCharge_DaysNo.Text = $"Cal.Standing charge for {DAYS_PER_MONTH} days: £";

                decimal chargePerMonth = Math.Round(((standChargeDecimal * (decimal)DAYS_PER_MONTH)) / 100, 2);

                standingChargePerMonthLabel.Text = "£" + chargePerMonth.ToString();

                decimal totalGasPrice = Math.Round(((decimal)consumptionKWH * (decimal)unitRateDouble) / 100 + chargePerMonth, 2);

                resultBox.Text = totalGasPrice.ToString();


                string finalResult = $"Your Bill is as follows: " +
                    $"\n\n 1. Standing Charge per {DAYS_PER_MONTH} days:  £{chargePerMonth}." +
                    $"\n\n 2. Gas Consumption Kwh for {DAYS_PER_MONTH} days:  {Math.Round(consumptionKWH, 2)} Kwh. " +
                    $"\n\n 3. Total Gas Price Consumed for {DAYS_PER_MONTH} days period: £{totalGasPrice}.";

                MessageBox.Show(finalResult, $"Your Gas Bill Usage for {DAYS_PER_MONTH} days period ", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }






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



        private void validateMeterReadings(String initialMeterReading, 
            String finalMeterReading, 
            String unitRate, String standingCharge) {
            string caption = "wrong input detected!";
           

            try {

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

                else if (  (int.Parse(finalMeterReading) < int.Parse(initialMeterReading))  )
                {

                    string message = $"Current Meter Reading of {finalMeterReading} cannot be lower than the initial Meter Reading of {initialMeterReading}. \n\n Please " +
                        $"check the values you supplied to be sure they are correct and try again!!";

                    string captionTitle = "invalid user inputs detected";

                    MessageBox.Show(message, captionTitle.ToUpper(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    
    

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

            }
            catch (Exception error)
            {
                Console.WriteLine($"Error occurred:{error.Message} ");
                MessageBox.Show(error.Message, "Error Occurred");
               
            }
        }

        private void calculateElectricBut_Click(object sender, EventArgs e)
        {

            string unitRate, standingCharge, lastMeterReading, currentMeterReading, daysConsumed;

            unitRate = electricUnitRateTextBox.Text;

            standingCharge = electricStandingChargeBox.Text;

            lastMeterReading = lastElectricMeterReadingTextBox.Text;

            currentMeterReading = currentElectricMeterTextBox.Text;

            daysConsumed = electricDayNoBox.Text;

            const int penceToPound = 100;

            const int noOfDecimalPlaces = 2;

            validateMeterReadings(lastMeterReading, currentMeterReading, unitRate, standingCharge);

           // MessageBox.Show($"Total standing charge days consumed is: {daysConsumed}");

            if ( Convert.ToInt32(lastMeterReading) <=  (Convert.ToInt32(currentMeterReading)) ) {

                int meterReadingDifference =  Convert.ToInt32(currentMeterReading) - Convert.ToInt32(lastMeterReading);

                double kwhConsumed = (Convert.ToDouble(unitRate) * Convert.ToDouble(meterReadingDifference))/ (double) 100;

                decimal kwhConsumedInDecimal = Math.Round((decimal)kwhConsumed, noOfDecimalPlaces);

                electricConsumptionBox.Text = meterReadingDifference.ToString();

                // MessageBox.Show($"Electricity KWH consumed:  {kwhConsumed}");

                double StandingChargePerDays = (Convert.ToDouble(daysConsumed) * (Convert.ToDouble(standingCharge))) / (double)penceToPound;

                decimal standChargePerDaysDecimal = Math.Round((decimal)StandingChargePerDays, noOfDecimalPlaces);

                electricStandingCharge_DaysNo.Text = $"Cal.Standing charge for {daysConsumed} days: £";

                electricStandingChargePerMonthLabel.Text = standChargePerDaysDecimal.ToString();

                decimal totalElectricityAmountConsumed = standChargePerDaysDecimal + kwhConsumedInDecimal;

                electricResultBox.Text = totalElectricityAmountConsumed.ToString();


                string finalResult = $"Your Bill is as follows: " +
                   $"\n\n 1. Standing Charge per {daysConsumed} days:  £{standChargePerDaysDecimal}." +
                   $"\n\n 2. Electricity Consumption Kwh for {daysConsumed} days:  {meterReadingDifference} Kwh. " +
                   $"\n\n 3. Total Gas Price Consumed for {daysConsumed} days period: £{totalElectricityAmountConsumed}.";

                MessageBox.Show(finalResult, $"Your Electricity Bill Usage for the {daysConsumed} period ", MessageBoxButtons.OK, MessageBoxIcon.Information);





            }


           /* if (comboBox.SelectedIndex == 0)
            {

                gasBut.Checked = true;
                gasBut.Visible = true;
                gasGroupBox.Visible = true;

                electricityBut.Visible = false;
                electricityBut.Checked = false;
                electricGroupBox.Visible = false;

                waterBut.Visible = false;
                waterBut.Checked = false;

            }
            else if (comboBox.SelectedIndex == 1)
            {
                gasBut.Checked = false;
                gasBut.Visible = false;
                gasGroupBox.Visible = false;

                electricityBut.Visible = true;
                electricityBut.Checked = true;
                electricGroupBox.Visible = true;

                waterBut.Visible = false;
                waterBut.Checked = false;

            }

            else if (comboBox.SelectedIndex == 2)
            {
                gasBut.Checked = false;
                gasBut.Visible = false;
                gasGroupBox.Visible = false;

                electricityBut.Visible = false;
                electricityBut.Checked = false;
                electricGroupBox.Visible = false;

                waterBut.Visible = true;
                waterBut.Checked = true;

            }

            else if (comboBox.SelectedIndex == 4)
            {

                gasBut.Checked = true;
                gasBut.Visible = true;
                gasGroupBox.Visible = true;

                electricityBut.Visible = true;
                electricityBut.Checked = true;
                electricGroupBox.Visible = true;

                waterBut.Visible = true;
                waterBut.Checked = true;

            }*/






        }

      

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox.SelectedIndex == 0)
            {

                gasBut.Checked = true;
                gasBut.Visible = true;
                gasGroupBox.Visible = true;

                electricityBut.Visible = false;
                electricityBut.Checked = false;
                electricGroupBox.Visible = false;

                waterBut.Visible = false;
                waterBut.Checked = false;

            }
            else if (comboBox.SelectedIndex == 1)
            {
                gasBut.Checked = false;
                gasBut.Visible = false;
                gasGroupBox.Visible = false;

                electricityBut.Visible = true;
                electricityBut.Checked = true;
                electricGroupBox.Visible = true;

                waterBut.Visible = false;
                waterBut.Checked = false;

            }

            else if (comboBox.SelectedIndex == 2)
            {
                gasBut.Checked = false;
                gasBut.Visible = false;
                gasGroupBox.Visible = false;

                electricityBut.Visible = false;
                electricityBut.Checked = false;
                electricGroupBox.Visible = false;

                waterBut.Visible = true;
                waterBut.Checked = true;

            }

            else if (comboBox.SelectedIndex == 4)
            {

                gasBut.Checked = true;
                gasBut.Visible = true;
                gasGroupBox.Visible = true;

                electricityBut.Visible = true;
                electricityBut.Checked = true;
                electricGroupBox.Visible = true;

                waterBut.Visible = true;
                waterBut.Checked = true;

            }
        }
    }
}
