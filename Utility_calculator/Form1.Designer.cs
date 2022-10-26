
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.calculateGasBut = new System.Windows.Forms.Button();
            this.secondMeterReadingLabel = new System.Windows.Forms.Label();
            this.secondMeterReadingBox = new System.Windows.Forms.TextBox();
            this.firstMeterReadingLabel = new System.Windows.Forms.Label();
            this.standingChargeLabel = new System.Windows.Forms.Label();
            this.firstMeterReadingBox = new System.Windows.Forms.TextBox();
            this.standingChargeBox = new System.Windows.Forms.TextBox();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.gasPriceLabel = new System.Windows.Forms.Label();
            this.consumptionLabel = new System.Windows.Forms.Label();
            this.consumptionBox = new System.Windows.Forms.TextBox();
            this.kwh = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.standingChargePerMonthLabel = new System.Windows.Forms.Label();
            this.noOfDaysLabel = new System.Windows.Forms.Label();
            this.noOfDaysBox = new System.Windows.Forms.TextBox();
            this.reserBut = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(397, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(123, 19);
            this.title.TabIndex = 0;
            this.title.Text = "Utility Calculator";
            // 
            // electricityBut
            // 
            this.electricityBut.AutoSize = true;
            this.electricityBut.Location = new System.Drawing.Point(401, 48);
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
            this.gasBut.Location = new System.Drawing.Point(94, 48);
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
            this.waterBut.Location = new System.Drawing.Point(768, 48);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.reserBut);
            this.groupBox1.Controls.Add(this.noOfDaysLabel);
            this.groupBox1.Controls.Add(this.noOfDaysBox);
            this.groupBox1.Controls.Add(this.standingChargePerMonthLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.kwh);
            this.groupBox1.Controls.Add(this.consumptionLabel);
            this.groupBox1.Controls.Add(this.consumptionBox);
            this.groupBox1.Controls.Add(this.gasPriceLabel);
            this.groupBox1.Controls.Add(this.resultBox);
            this.groupBox1.Controls.Add(this.calculateGasBut);
            this.groupBox1.Controls.Add(this.secondMeterReadingLabel);
            this.groupBox1.Controls.Add(this.secondMeterReadingBox);
            this.groupBox1.Controls.Add(this.firstMeterReadingLabel);
            this.groupBox1.Controls.Add(this.standingChargeLabel);
            this.groupBox1.Controls.Add(this.firstMeterReadingBox);
            this.groupBox1.Controls.Add(this.standingChargeBox);
            this.groupBox1.Controls.Add(this.gasUnitRate);
            this.groupBox1.Controls.Add(this.unitRateBox);
            this.groupBox1.Location = new System.Drawing.Point(27, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 367);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gas Utility";
            // 
            // calculateGasBut
            // 
            this.calculateGasBut.Location = new System.Drawing.Point(50, 338);
            this.calculateGasBut.Name = "calculateGasBut";
            this.calculateGasBut.Size = new System.Drawing.Size(127, 23);
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
            this.firstMeterReadingLabel.Size = new System.Drawing.Size(104, 13);
            this.firstMeterReadingLabel.TabIndex = 7;
            this.firstMeterReadingLabel.Text = "Initial Meter Reading";
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
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(117, 298);
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(100, 20);
            this.resultBox.TabIndex = 7;
            this.resultBox.Text = "670";
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
            // kwh
            // 
            this.kwh.AutoSize = true;
            this.kwh.Location = new System.Drawing.Point(223, 260);
            this.kwh.Name = "kwh";
            this.kwh.Size = new System.Drawing.Size(28, 13);
            this.kwh.TabIndex = 15;
            this.kwh.Text = "Kwh";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Pence/Kwh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Standing charge/Days No: £";
            // 
            // standingChargePerMonthLabel
            // 
            this.standingChargePerMonthLabel.AutoSize = true;
            this.standingChargePerMonthLabel.Location = new System.Drawing.Point(142, 225);
            this.standingChargePerMonthLabel.Name = "standingChargePerMonthLabel";
            this.standingChargePerMonthLabel.Size = new System.Drawing.Size(28, 13);
            this.standingChargePerMonthLabel.TabIndex = 19;
            this.standingChargePerMonthLabel.Text = "0.00";
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
            // reserBut
            // 
            this.reserBut.Location = new System.Drawing.Point(183, 338);
            this.reserBut.Name = "reserBut";
            this.reserBut.Size = new System.Drawing.Size(68, 23);
            this.reserBut.TabIndex = 22;
            this.reserBut.Text = "reset values";
            this.reserBut.UseVisualStyleBackColor = true;
            this.reserBut.Click += new System.EventHandler(this.reserBut_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(935, 24);
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
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.detailsToolStripMenuItem.Text = "Details";
            this.detailsToolStripMenuItem.Click += new System.EventHandler(this.detailsToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem1
            // 
            this.closeToolStripMenuItem1.Name = "closeToolStripMenuItem1";
            this.closeToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.closeToolStripMenuItem1.Text = "Close";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.waterBut);
            this.Controls.Add(this.gasBut);
            this.Controls.Add(this.electricityBut);
            this.Controls.Add(this.title);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Utility_Bills_Calcualtor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.Label label3;
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
    }
}

