
namespace Utility_calculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.electricityBut = new System.Windows.Forms.RadioButton();
            this.gasBut = new System.Windows.Forms.RadioButton();
            this.waterBut = new System.Windows.Forms.RadioButton();
            this.gasUnitRate = new System.Windows.Forms.Label();
            this.unitRateBox = new System.Windows.Forms.TextBox();
            this.gasGroupBox = new System.Windows.Forms.GroupBox();
            this.reserBut = new System.Windows.Forms.Button();
            this.noOfDaysLabel = new System.Windows.Forms.Label();
            this.noOfDaysBox = new System.Windows.Forms.TextBox();
            this.standingChargePerMonthLabel = new System.Windows.Forms.Label();
            this.gasStandingCharge_DaysNo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kwh = new System.Windows.Forms.Label();
            this.consumptionLabel = new System.Windows.Forms.Label();
            this.consumptionBox = new System.Windows.Forms.TextBox();
            this.gasPriceLabel = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.calculateGasBut = new System.Windows.Forms.Button();
            this.secondMeterReadingLabel = new System.Windows.Forms.Label();
            this.secondMeterReadingBox = new System.Windows.Forms.TextBox();
            this.firstMeterReadingLabel = new System.Windows.Forms.Label();
            this.standingChargeLabel = new System.Windows.Forms.Label();
            this.firstMeterReadingBox = new System.Windows.Forms.TextBox();
            this.standingChargeBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.electricGroupBox = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.calculateElectricBut = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.electricResultBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.electricConsumptionBox = new System.Windows.Forms.TextBox();
            this.electricStandingChargePerMonthLabel = new System.Windows.Forms.Label();
            this.electricStandingCharge_DaysNo = new System.Windows.Forms.Label();
            this.electricDaysNo = new System.Windows.Forms.Label();
            this.electricDayNoBox = new System.Windows.Forms.TextBox();
            this.electricStandingChargeBack = new System.Windows.Forms.Label();
            this.electricStandingCharge = new System.Windows.Forms.Label();
            this.electricStandingChargeBox = new System.Windows.Forms.TextBox();
            this.electricUnitRate = new System.Windows.Forms.Label();
            this.currentElectricMeterLbl = new System.Windows.Forms.Label();
            this.electricUnitRateFrontText = new System.Windows.Forms.Label();
            this.currentElectricMeterTextBox = new System.Windows.Forms.TextBox();
            this.electricUnitRateTextBox = new System.Windows.Forms.TextBox();
            this.lastElectReadingLbl = new System.Windows.Forms.Label();
            this.lastElectricMeterReadingTextBox = new System.Windows.Forms.TextBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gasGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.electricGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(410, 5);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(123, 19);
            this.title.TabIndex = 0;
            this.title.Text = "Utility Calculator";
            // 
            // electricityBut
            // 
            this.electricityBut.AutoSize = true;
            this.electricityBut.Location = new System.Drawing.Point(414, 34);
            this.electricityBut.Name = "electricityBut";
            this.electricityBut.Size = new System.Drawing.Size(70, 17);
            this.electricityBut.TabIndex = 1;
            this.electricityBut.TabStop = true;
            this.electricityBut.Text = "Electricity";
            this.electricityBut.UseVisualStyleBackColor = true;
            // 
            // gasBut
            // 
            this.gasBut.AutoSize = true;
            this.gasBut.Location = new System.Drawing.Point(94, 34);
            this.gasBut.Name = "gasBut";
            this.gasBut.Size = new System.Drawing.Size(44, 17);
            this.gasBut.TabIndex = 2;
            this.gasBut.TabStop = true;
            this.gasBut.Text = "Gas";
            this.gasBut.UseVisualStyleBackColor = true;
            // 
            // waterBut
            // 
            this.waterBut.AutoSize = true;
            this.waterBut.Location = new System.Drawing.Point(768, 34);
            this.waterBut.Name = "waterBut";
            this.waterBut.Size = new System.Drawing.Size(54, 17);
            this.waterBut.TabIndex = 3;
            this.waterBut.TabStop = true;
            this.waterBut.Text = "Water";
            this.waterBut.UseVisualStyleBackColor = true;
            // 
            // gasUnitRate
            // 
            this.gasUnitRate.AutoSize = true;
            this.gasUnitRate.Location = new System.Drawing.Point(12, 109);
            this.gasUnitRate.Name = "gasUnitRate";
            this.gasUnitRate.Size = new System.Drawing.Size(52, 13);
            this.gasUnitRate.TabIndex = 4;
            this.gasUnitRate.Text = "Unit Rate";
            // 
            // unitRateBox
            // 
            this.unitRateBox.Location = new System.Drawing.Point(135, 102);
            this.unitRateBox.Name = "unitRateBox";
            this.unitRateBox.Size = new System.Drawing.Size(82, 20);
            this.unitRateBox.TabIndex = 5;
            this.unitRateBox.Text = "10.22";
            this.unitRateBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gasGroupBox
            // 
            this.gasGroupBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gasGroupBox.Controls.Add(this.reserBut);
            this.gasGroupBox.Controls.Add(this.noOfDaysLabel);
            this.gasGroupBox.Controls.Add(this.noOfDaysBox);
            this.gasGroupBox.Controls.Add(this.standingChargePerMonthLabel);
            this.gasGroupBox.Controls.Add(this.gasStandingCharge_DaysNo);
            this.gasGroupBox.Controls.Add(this.label2);
            this.gasGroupBox.Controls.Add(this.label1);
            this.gasGroupBox.Controls.Add(this.kwh);
            this.gasGroupBox.Controls.Add(this.consumptionLabel);
            this.gasGroupBox.Controls.Add(this.consumptionBox);
            this.gasGroupBox.Controls.Add(this.gasPriceLabel);
            this.gasGroupBox.Controls.Add(this.resultBox);
            this.gasGroupBox.Controls.Add(this.calculateGasBut);
            this.gasGroupBox.Controls.Add(this.secondMeterReadingLabel);
            this.gasGroupBox.Controls.Add(this.secondMeterReadingBox);
            this.gasGroupBox.Controls.Add(this.firstMeterReadingLabel);
            this.gasGroupBox.Controls.Add(this.standingChargeLabel);
            this.gasGroupBox.Controls.Add(this.firstMeterReadingBox);
            this.gasGroupBox.Controls.Add(this.standingChargeBox);
            this.gasGroupBox.Controls.Add(this.gasUnitRate);
            this.gasGroupBox.Controls.Add(this.unitRateBox);
            this.gasGroupBox.Location = new System.Drawing.Point(27, 71);
            this.gasGroupBox.Name = "gasGroupBox";
            this.gasGroupBox.Size = new System.Drawing.Size(288, 367);
            this.gasGroupBox.TabIndex = 6;
            this.gasGroupBox.TabStop = false;
            this.gasGroupBox.Text = "Gas Utility";
            // 
            // reserBut
            // 
            this.reserBut.Location = new System.Drawing.Point(183, 326);
            this.reserBut.Name = "reserBut";
            this.reserBut.Size = new System.Drawing.Size(68, 35);
            this.reserBut.TabIndex = 22;
            this.reserBut.Text = "reset values";
            this.reserBut.UseVisualStyleBackColor = true;
            this.reserBut.Click += new System.EventHandler(this.reserBut_Click);
            // 
            // noOfDaysLabel
            // 
            this.noOfDaysLabel.AutoSize = true;
            this.noOfDaysLabel.Location = new System.Drawing.Point(12, 187);
            this.noOfDaysLabel.Name = "noOfDaysLabel";
            this.noOfDaysLabel.Size = new System.Drawing.Size(60, 13);
            this.noOfDaysLabel.TabIndex = 20;
            this.noOfDaysLabel.Text = "No of Days";
            // 
            // noOfDaysBox
            // 
            this.noOfDaysBox.Location = new System.Drawing.Point(135, 180);
            this.noOfDaysBox.Name = "noOfDaysBox";
            this.noOfDaysBox.Size = new System.Drawing.Size(82, 20);
            this.noOfDaysBox.TabIndex = 21;
            this.noOfDaysBox.Text = "3";
            this.noOfDaysBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // standingChargePerMonthLabel
            // 
            this.standingChargePerMonthLabel.AutoSize = true;
            this.standingChargePerMonthLabel.Location = new System.Drawing.Point(180, 225);
            this.standingChargePerMonthLabel.Name = "standingChargePerMonthLabel";
            this.standingChargePerMonthLabel.Size = new System.Drawing.Size(28, 13);
            this.standingChargePerMonthLabel.TabIndex = 19;
            this.standingChargePerMonthLabel.Text = "0.00";
            // 
            // gasStandingCharge_DaysNo
            // 
            this.gasStandingCharge_DaysNo.AutoSize = true;
            this.gasStandingCharge_DaysNo.Location = new System.Drawing.Point(13, 225);
            this.gasStandingCharge_DaysNo.Name = "gasStandingCharge_DaysNo";
            this.gasStandingCharge_DaysNo.Size = new System.Drawing.Size(164, 13);
            this.gasStandingCharge_DaysNo.TabIndex = 18;
            this.gasStandingCharge_DaysNo.Text = "Cal. Standing charge/Days No: £";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Pence/Kwh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Pence/Day";
            // 
            // kwh
            // 
            this.kwh.AutoSize = true;
            this.kwh.Location = new System.Drawing.Point(223, 260);
            this.kwh.Name = "kwh";
            this.kwh.Size = new System.Drawing.Size(28, 13);
            this.kwh.TabIndex = 15;
            this.kwh.Text = "Kwh";
            // 
            // consumptionLabel
            // 
            this.consumptionLabel.AutoSize = true;
            this.consumptionLabel.Location = new System.Drawing.Point(12, 260);
            this.consumptionLabel.Name = "consumptionLabel";
            this.consumptionLabel.Size = new System.Drawing.Size(120, 13);
            this.consumptionLabel.TabIndex = 13;
            this.consumptionLabel.Text = "Gas Consumption (Kwh)";
            // 
            // consumptionBox
            // 
            this.consumptionBox.Location = new System.Drawing.Point(135, 253);
            this.consumptionBox.Name = "consumptionBox";
            this.consumptionBox.ReadOnly = true;
            this.consumptionBox.Size = new System.Drawing.Size(82, 20);
            this.consumptionBox.TabIndex = 14;
            this.consumptionBox.Text = "0.00";
            this.consumptionBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gasPriceLabel
            // 
            this.gasPriceLabel.AutoSize = true;
            this.gasPriceLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gasPriceLabel.Location = new System.Drawing.Point(21, 299);
            this.gasPriceLabel.Name = "gasPriceLabel";
            this.gasPriceLabel.Size = new System.Drawing.Size(90, 19);
            this.gasPriceLabel.TabIndex = 12;
            this.gasPriceLabel.Text = "Gas Price  £";
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(117, 298);
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(100, 20);
            this.resultBox.TabIndex = 7;
            this.resultBox.Text = "0";
            // 
            // calculateGasBut
            // 
            this.calculateGasBut.Location = new System.Drawing.Point(50, 326);
            this.calculateGasBut.Name = "calculateGasBut";
            this.calculateGasBut.Size = new System.Drawing.Size(127, 35);
            this.calculateGasBut.TabIndex = 11;
            this.calculateGasBut.Text = "calculate Gas";
            this.calculateGasBut.UseVisualStyleBackColor = true;
            this.calculateGasBut.Click += new System.EventHandler(this.calculateGasBut_Click);
            // 
            // secondMeterReadingLabel
            // 
            this.secondMeterReadingLabel.AutoSize = true;
            this.secondMeterReadingLabel.Location = new System.Drawing.Point(12, 69);
            this.secondMeterReadingLabel.Name = "secondMeterReadingLabel";
            this.secondMeterReadingLabel.Size = new System.Drawing.Size(114, 13);
            this.secondMeterReadingLabel.TabIndex = 9;
            this.secondMeterReadingLabel.Text = "Current Meter Reading";
            // 
            // secondMeterReadingBox
            // 
            this.secondMeterReadingBox.Location = new System.Drawing.Point(135, 62);
            this.secondMeterReadingBox.Name = "secondMeterReadingBox";
            this.secondMeterReadingBox.Size = new System.Drawing.Size(82, 20);
            this.secondMeterReadingBox.TabIndex = 10;
            this.secondMeterReadingBox.Text = "0690";
            this.secondMeterReadingBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // firstMeterReadingLabel
            // 
            this.firstMeterReadingLabel.AutoSize = true;
            this.firstMeterReadingLabel.Location = new System.Drawing.Point(12, 30);
            this.firstMeterReadingLabel.Name = "firstMeterReadingLabel";
            this.firstMeterReadingLabel.Size = new System.Drawing.Size(100, 13);
            this.firstMeterReadingLabel.TabIndex = 7;
            this.firstMeterReadingLabel.Text = "Last Meter Reading";
            // 
            // standingChargeLabel
            // 
            this.standingChargeLabel.AutoSize = true;
            this.standingChargeLabel.Location = new System.Drawing.Point(12, 149);
            this.standingChargeLabel.Name = "standingChargeLabel";
            this.standingChargeLabel.Size = new System.Drawing.Size(88, 13);
            this.standingChargeLabel.TabIndex = 6;
            this.standingChargeLabel.Text = "Standing charge ";
            // 
            // firstMeterReadingBox
            // 
            this.firstMeterReadingBox.Location = new System.Drawing.Point(135, 22);
            this.firstMeterReadingBox.Name = "firstMeterReadingBox";
            this.firstMeterReadingBox.Size = new System.Drawing.Size(82, 20);
            this.firstMeterReadingBox.TabIndex = 8;
            this.firstMeterReadingBox.Text = "0688";
            this.firstMeterReadingBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // standingChargeBox
            // 
            this.standingChargeBox.Location = new System.Drawing.Point(135, 142);
            this.standingChargeBox.Name = "standingChargeBox";
            this.standingChargeBox.Size = new System.Drawing.Size(82, 20);
            this.standingChargeBox.TabIndex = 7;
            this.standingChargeBox.Text = "28.47";
            this.standingChargeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1024, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // closeToolStripMenuItem1
            // 
            this.closeToolStripMenuItem1.Name = "closeToolStripMenuItem1";
            this.closeToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem1.Text = "Close";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.closeToolStripMenuItem.Text = "&Edit";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detailsToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.detailsToolStripMenuItem.Text = "Details";
            this.detailsToolStripMenuItem.Click += new System.EventHandler(this.detailsToolStripMenuItem_Click);
            // 
            // electricGroupBox
            // 
            this.electricGroupBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.electricGroupBox.Controls.Add(this.label7);
            this.electricGroupBox.Controls.Add(this.label3);
            this.electricGroupBox.Controls.Add(this.calculateElectricBut);
            this.electricGroupBox.Controls.Add(this.label6);
            this.electricGroupBox.Controls.Add(this.electricResultBox);
            this.electricGroupBox.Controls.Add(this.label4);
            this.electricGroupBox.Controls.Add(this.label5);
            this.electricGroupBox.Controls.Add(this.electricConsumptionBox);
            this.electricGroupBox.Controls.Add(this.electricStandingChargePerMonthLabel);
            this.electricGroupBox.Controls.Add(this.electricStandingCharge_DaysNo);
            this.electricGroupBox.Controls.Add(this.electricDaysNo);
            this.electricGroupBox.Controls.Add(this.electricDayNoBox);
            this.electricGroupBox.Controls.Add(this.electricStandingChargeBack);
            this.electricGroupBox.Controls.Add(this.electricStandingCharge);
            this.electricGroupBox.Controls.Add(this.electricStandingChargeBox);
            this.electricGroupBox.Controls.Add(this.electricUnitRate);
            this.electricGroupBox.Controls.Add(this.currentElectricMeterLbl);
            this.electricGroupBox.Controls.Add(this.electricUnitRateFrontText);
            this.electricGroupBox.Controls.Add(this.currentElectricMeterTextBox);
            this.electricGroupBox.Controls.Add(this.electricUnitRateTextBox);
            this.electricGroupBox.Controls.Add(this.lastElectReadingLbl);
            this.electricGroupBox.Controls.Add(this.lastElectricMeterReadingTextBox);
            this.electricGroupBox.Location = new System.Drawing.Point(352, 71);
            this.electricGroupBox.Name = "electricGroupBox";
            this.electricGroupBox.Size = new System.Drawing.Size(288, 361);
            this.electricGroupBox.TabIndex = 8;
            this.electricGroupBox.TabStop = false;
            this.electricGroupBox.Text = "Electic Utility";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(235, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Kwh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Kwh";
            // 
            // calculateElectricBut
            // 
            this.calculateElectricBut.BackColor = System.Drawing.SystemColors.Highlight;
            this.calculateElectricBut.Location = new System.Drawing.Point(70, 326);
            this.calculateElectricBut.Name = "calculateElectricBut";
            this.calculateElectricBut.Size = new System.Drawing.Size(127, 35);
            this.calculateElectricBut.TabIndex = 39;
            this.calculateElectricBut.Text = "calculate Electric";
            this.calculateElectricBut.UseVisualStyleBackColor = false;
            this.calculateElectricBut.Click += new System.EventHandler(this.calculateElectricBut_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 19);
            this.label6.TabIndex = 38;
            this.label6.Text = "Elctricity Price  £";
            // 
            // electricResultBox
            // 
            this.electricResultBox.Location = new System.Drawing.Point(158, 300);
            this.electricResultBox.Name = "electricResultBox";
            this.electricResultBox.ReadOnly = true;
            this.electricResultBox.Size = new System.Drawing.Size(66, 20);
            this.electricResultBox.TabIndex = 37;
            this.electricResultBox.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Kwh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Electricity  Consumption";
            // 
            // electricConsumptionBox
            // 
            this.electricConsumptionBox.Location = new System.Drawing.Point(142, 253);
            this.electricConsumptionBox.Name = "electricConsumptionBox";
            this.electricConsumptionBox.ReadOnly = true;
            this.electricConsumptionBox.Size = new System.Drawing.Size(82, 20);
            this.electricConsumptionBox.TabIndex = 35;
            this.electricConsumptionBox.Text = "0.00";
            this.electricConsumptionBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // electricStandingChargePerMonthLabel
            // 
            this.electricStandingChargePerMonthLabel.AutoSize = true;
            this.electricStandingChargePerMonthLabel.Location = new System.Drawing.Point(185, 225);
            this.electricStandingChargePerMonthLabel.Name = "electricStandingChargePerMonthLabel";
            this.electricStandingChargePerMonthLabel.Size = new System.Drawing.Size(28, 13);
            this.electricStandingChargePerMonthLabel.TabIndex = 33;
            this.electricStandingChargePerMonthLabel.Text = "0.00";
            // 
            // electricStandingCharge_DaysNo
            // 
            this.electricStandingCharge_DaysNo.AutoSize = true;
            this.electricStandingCharge_DaysNo.Location = new System.Drawing.Point(19, 225);
            this.electricStandingCharge_DaysNo.Name = "electricStandingCharge_DaysNo";
            this.electricStandingCharge_DaysNo.Size = new System.Drawing.Size(164, 13);
            this.electricStandingCharge_DaysNo.TabIndex = 32;
            this.electricStandingCharge_DaysNo.Text = "Cal. Standing charge/Days No: £";
            // 
            // electricDaysNo
            // 
            this.electricDaysNo.AutoSize = true;
            this.electricDaysNo.Location = new System.Drawing.Point(19, 191);
            this.electricDaysNo.Name = "electricDaysNo";
            this.electricDaysNo.Size = new System.Drawing.Size(60, 13);
            this.electricDaysNo.TabIndex = 30;
            this.electricDaysNo.Text = "No of Days";
            // 
            // electricDayNoBox
            // 
            this.electricDayNoBox.Location = new System.Drawing.Point(115, 188);
            this.electricDayNoBox.Name = "electricDayNoBox";
            this.electricDayNoBox.Size = new System.Drawing.Size(82, 20);
            this.electricDayNoBox.TabIndex = 31;
            this.electricDayNoBox.Text = "10";
            this.electricDayNoBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // electricStandingChargeBack
            // 
            this.electricStandingChargeBack.AutoSize = true;
            this.electricStandingChargeBack.Location = new System.Drawing.Point(203, 153);
            this.electricStandingChargeBack.Name = "electricStandingChargeBack";
            this.electricStandingChargeBack.Size = new System.Drawing.Size(62, 13);
            this.electricStandingChargeBack.TabIndex = 29;
            this.electricStandingChargeBack.Text = "Pence/Day";
            // 
            // electricStandingCharge
            // 
            this.electricStandingCharge.AutoSize = true;
            this.electricStandingCharge.Location = new System.Drawing.Point(19, 149);
            this.electricStandingCharge.Name = "electricStandingCharge";
            this.electricStandingCharge.Size = new System.Drawing.Size(88, 13);
            this.electricStandingCharge.TabIndex = 27;
            this.electricStandingCharge.Text = "Standing charge ";
            // 
            // electricStandingChargeBox
            // 
            this.electricStandingChargeBox.Location = new System.Drawing.Point(115, 146);
            this.electricStandingChargeBox.Name = "electricStandingChargeBox";
            this.electricStandingChargeBox.Size = new System.Drawing.Size(82, 20);
            this.electricStandingChargeBox.TabIndex = 28;
            this.electricStandingChargeBox.Text = "43.48";
            this.electricStandingChargeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // electricUnitRate
            // 
            this.electricUnitRate.AutoSize = true;
            this.electricUnitRate.Location = new System.Drawing.Point(199, 109);
            this.electricUnitRate.Name = "electricUnitRate";
            this.electricUnitRate.Size = new System.Drawing.Size(64, 13);
            this.electricUnitRate.TabIndex = 25;
            this.electricUnitRate.Text = "Pence/Kwh";
            // 
            // currentElectricMeterLbl
            // 
            this.currentElectricMeterLbl.AutoSize = true;
            this.currentElectricMeterLbl.Location = new System.Drawing.Point(19, 69);
            this.currentElectricMeterLbl.Name = "currentElectricMeterLbl";
            this.currentElectricMeterLbl.Size = new System.Drawing.Size(114, 13);
            this.currentElectricMeterLbl.TabIndex = 25;
            this.currentElectricMeterLbl.Text = "Current Meter Reading";
            // 
            // electricUnitRateFrontText
            // 
            this.electricUnitRateFrontText.AutoSize = true;
            this.electricUnitRateFrontText.Location = new System.Drawing.Point(19, 109);
            this.electricUnitRateFrontText.Name = "electricUnitRateFrontText";
            this.electricUnitRateFrontText.Size = new System.Drawing.Size(85, 13);
            this.electricUnitRateFrontText.TabIndex = 23;
            this.electricUnitRateFrontText.Text = "Unit Rate (Tariff)";
            // 
            // currentElectricMeterTextBox
            // 
            this.currentElectricMeterTextBox.Location = new System.Drawing.Point(142, 61);
            this.currentElectricMeterTextBox.Name = "currentElectricMeterTextBox";
            this.currentElectricMeterTextBox.Size = new System.Drawing.Size(82, 20);
            this.currentElectricMeterTextBox.TabIndex = 26;
            this.currentElectricMeterTextBox.Text = "1640";
            this.currentElectricMeterTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // electricUnitRateTextBox
            // 
            this.electricUnitRateTextBox.Location = new System.Drawing.Point(115, 102);
            this.electricUnitRateTextBox.Name = "electricUnitRateTextBox";
            this.electricUnitRateTextBox.Size = new System.Drawing.Size(82, 20);
            this.electricUnitRateTextBox.TabIndex = 24;
            this.electricUnitRateTextBox.Text = "33.81";
            this.electricUnitRateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lastElectReadingLbl
            // 
            this.lastElectReadingLbl.AutoSize = true;
            this.lastElectReadingLbl.Location = new System.Drawing.Point(19, 29);
            this.lastElectReadingLbl.Name = "lastElectReadingLbl";
            this.lastElectReadingLbl.Size = new System.Drawing.Size(100, 13);
            this.lastElectReadingLbl.TabIndex = 23;
            this.lastElectReadingLbl.Text = "Last Meter Reading";
            // 
            // lastElectricMeterReadingTextBox
            // 
            this.lastElectricMeterReadingTextBox.Location = new System.Drawing.Point(142, 21);
            this.lastElectricMeterReadingTextBox.Name = "lastElectricMeterReadingTextBox";
            this.lastElectricMeterReadingTextBox.Size = new System.Drawing.Size(82, 20);
            this.lastElectricMeterReadingTextBox.TabIndex = 24;
            this.lastElectricMeterReadingTextBox.Text = "1320";
            this.lastElectricMeterReadingTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Gas Utility",
            "Electricity Utility",
            "Water Utility",
            "Broadband",
            "All"});
            this.comboBox.Location = new System.Drawing.Point(269, 3);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 21);
            this.comboBox.TabIndex = 9;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(173, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Select Your Utility";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.electricGroupBox);
            this.Controls.Add(this.gasGroupBox);
            this.Controls.Add(this.waterBut);
            this.Controls.Add(this.gasBut);
            this.Controls.Add(this.electricityBut);
            this.Controls.Add(this.title);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Utility_Bills_Calcualtor";
            this.gasGroupBox.ResumeLayout(false);
            this.gasGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.electricGroupBox.ResumeLayout(false);
            this.electricGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.RadioButton electricityBut;
        private System.Windows.Forms.RadioButton gasBut;
        private System.Windows.Forms.RadioButton waterBut;
        private System.Windows.Forms.Label gasUnitRate;
        private System.Windows.Forms.TextBox unitRateBox;
        private System.Windows.Forms.GroupBox gasGroupBox;
        private System.Windows.Forms.Label standingChargeLabel;
        private System.Windows.Forms.TextBox standingChargeBox;
        private System.Windows.Forms.Label secondMeterReadingLabel;
        private System.Windows.Forms.TextBox secondMeterReadingBox;
        private System.Windows.Forms.Label firstMeterReadingLabel;
        private System.Windows.Forms.TextBox firstMeterReadingBox;
        private System.Windows.Forms.Button calculateGasBut;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Label kwh;
        private System.Windows.Forms.Label consumptionLabel;
        private System.Windows.Forms.TextBox consumptionBox;
        private System.Windows.Forms.Label gasPriceLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label standingChargePerMonthLabel;
        private System.Windows.Forms.Label gasStandingCharge_DaysNo;
        private System.Windows.Forms.Label noOfDaysLabel;
        private System.Windows.Forms.TextBox noOfDaysBox;
        private System.Windows.Forms.Button reserBut;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox electricGroupBox;
        private System.Windows.Forms.Label electricUnitRate;
        private System.Windows.Forms.Label currentElectricMeterLbl;
        private System.Windows.Forms.Label electricUnitRateFrontText;
        private System.Windows.Forms.TextBox currentElectricMeterTextBox;
        private System.Windows.Forms.TextBox electricUnitRateTextBox;
        private System.Windows.Forms.Label lastElectReadingLbl;
        private System.Windows.Forms.TextBox lastElectricMeterReadingTextBox;
        private System.Windows.Forms.Label electricStandingChargeBack;
        private System.Windows.Forms.Label electricStandingCharge;
        private System.Windows.Forms.TextBox electricStandingChargeBox;
        private System.Windows.Forms.Label electricDaysNo;
        private System.Windows.Forms.TextBox electricDayNoBox;
        private System.Windows.Forms.Label electricStandingChargePerMonthLabel;
        private System.Windows.Forms.Label electricStandingCharge_DaysNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox electricConsumptionBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox electricResultBox;
        private System.Windows.Forms.Button calculateElectricBut;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label label8;
    }
}

