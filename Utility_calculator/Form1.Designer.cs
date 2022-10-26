
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
            this.label1 = new System.Windows.Forms.Label();
            this.standingChargeBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.firstMeterReadingBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.secondMeterReadingBox = new System.Windows.Forms.TextBox();
            this.calculateGasBut = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(397, 24);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(123, 19);
            this.title.TabIndex = 0;
            this.title.Text = "Utility Calculator";
            // 
            // electricityBut
            // 
            this.electricityBut.AutoSize = true;
            this.electricityBut.Location = new System.Drawing.Point(401, 80);
            this.electricityBut.Name = "electricityBut";
            this.electricityBut.Size = new System.Drawing.Size(70, 17);
            this.electricityBut.TabIndex = 1;
            this.electricityBut.TabStop = true;
            this.electricityBut.Text = "Electricity";
            this.electricityBut.UseVisualStyleBackColor = true;
            this.electricityBut.CheckedChanged += new System.EventHandler(this.electricityBut_CheckedChanged);
            // 
            // gasBut
            // 
            this.gasBut.AutoSize = true;
            this.gasBut.Location = new System.Drawing.Point(120, 57);
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
            this.waterBut.Location = new System.Drawing.Point(768, 80);
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
            this.gasUnitRate.Location = new System.Drawing.Point(12, 135);
            this.gasUnitRate.Name = "gasUnitRate";
            this.gasUnitRate.Size = new System.Drawing.Size(52, 13);
            this.gasUnitRate.TabIndex = 4;
            this.gasUnitRate.Text = "Unit Rate";
            // 
            // unitRateBox
            // 
            this.unitRateBox.Location = new System.Drawing.Point(135, 127);
            this.unitRateBox.Name = "unitRateBox";
            this.unitRateBox.Size = new System.Drawing.Size(97, 20);
            this.unitRateBox.TabIndex = 5;
            this.unitRateBox.Text = "10.22";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.calculateGasBut);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.secondMeterReadingBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.firstMeterReadingBox);
            this.groupBox1.Controls.Add(this.standingChargeBox);
            this.groupBox1.Controls.Add(this.gasUnitRate);
            this.groupBox1.Controls.Add(this.unitRateBox);
            this.groupBox1.Location = new System.Drawing.Point(35, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 322);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gas Utility";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Standing charge";
            // 
            // standingChargeBox
            // 
            this.standingChargeBox.Location = new System.Drawing.Point(135, 176);
            this.standingChargeBox.Name = "standingChargeBox";
            this.standingChargeBox.Size = new System.Drawing.Size(97, 20);
            this.standingChargeBox.TabIndex = 7;
            this.standingChargeBox.Text = "28.47";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "First Meter Reading";
            // 
            // firstMeterReadingBox
            // 
            this.firstMeterReadingBox.Location = new System.Drawing.Point(117, 38);
            this.firstMeterReadingBox.Name = "firstMeterReadingBox";
            this.firstMeterReadingBox.Size = new System.Drawing.Size(115, 20);
            this.firstMeterReadingBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Second Meter Reading";
            // 
            // secondMeterReadingBox
            // 
            this.secondMeterReadingBox.Location = new System.Drawing.Point(135, 82);
            this.secondMeterReadingBox.Name = "secondMeterReadingBox";
            this.secondMeterReadingBox.Size = new System.Drawing.Size(97, 20);
            this.secondMeterReadingBox.TabIndex = 10;
            // 
            // calculateGasBut
            // 
            this.calculateGasBut.Location = new System.Drawing.Point(85, 271);
            this.calculateGasBut.Name = "calculateGasBut";
            this.calculateGasBut.Size = new System.Drawing.Size(127, 23);
            this.calculateGasBut.TabIndex = 11;
            this.calculateGasBut.Text = "calculate Gas";
            this.calculateGasBut.UseVisualStyleBackColor = true;
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox standingChargeBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox secondMeterReadingBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstMeterReadingBox;
        private System.Windows.Forms.Button calculateGasBut;
    }
}

