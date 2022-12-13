namespace CS311_FinalProject_MRE
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUnitConverter = new System.Windows.Forms.Label();
            this.rdoMeterstoFeet = new System.Windows.Forms.RadioButton();
            this.rdoFeettoMeeters = new System.Windows.Forms.RadioButton();
            this.btn1 = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.rtf1 = new System.Windows.Forms.RichTextBox();
            this.rdoMilestoKilometers = new System.Windows.Forms.RadioButton();
            this.rdoKilometerstoMiles = new System.Windows.Forms.RadioButton();
            this.rdoPoundstoKilogram = new System.Windows.Forms.RadioButton();
            this.rdoKilogramtoPounds = new System.Windows.Forms.RadioButton();
            this.rdoFahrenheittoCelsius = new System.Windows.Forms.RadioButton();
            this.rdoCelciustoFahrenheit = new System.Windows.Forms.RadioButton();
            this.rdoOuncestoGrams = new System.Windows.Forms.RadioButton();
            this.rdoGramstoOunces = new System.Windows.Forms.RadioButton();
            this.btn2 = new System.Windows.Forms.Button();
            this.lblDirections1 = new System.Windows.Forms.Label();
            this.rdoExample = new System.Windows.Forms.RadioButton();
            this.txtExample = new System.Windows.Forms.TextBox();
            this.btnExample1 = new System.Windows.Forms.Button();
            this.rtfExample = new System.Windows.Forms.RichTextBox();
            this.btnExample = new System.Windows.Forms.Button();
            this.lblDirections2 = new System.Windows.Forms.Label();
            this.lblExampleTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUnitConverter
            // 
            this.lblUnitConverter.AutoSize = true;
            this.lblUnitConverter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUnitConverter.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUnitConverter.Location = new System.Drawing.Point(456, 9);
            this.lblUnitConverter.Name = "lblUnitConverter";
            this.lblUnitConverter.Size = new System.Drawing.Size(213, 40);
            this.lblUnitConverter.TabIndex = 0;
            this.lblUnitConverter.Text = "Unit Converter";
            // 
            // rdoMeterstoFeet
            // 
            this.rdoMeterstoFeet.AutoSize = true;
            this.rdoMeterstoFeet.Location = new System.Drawing.Point(111, 226);
            this.rdoMeterstoFeet.Name = "rdoMeterstoFeet";
            this.rdoMeterstoFeet.Size = new System.Drawing.Size(125, 24);
            this.rdoMeterstoFeet.TabIndex = 1;
            this.rdoMeterstoFeet.TabStop = true;
            this.rdoMeterstoFeet.Text = "Meters to Feet";
            this.rdoMeterstoFeet.UseVisualStyleBackColor = true;
            // 
            // rdoFeettoMeeters
            // 
            this.rdoFeettoMeeters.AutoSize = true;
            this.rdoFeettoMeeters.Location = new System.Drawing.Point(111, 267);
            this.rdoFeettoMeeters.Name = "rdoFeettoMeeters";
            this.rdoFeettoMeeters.Size = new System.Drawing.Size(125, 24);
            this.rdoFeettoMeeters.TabIndex = 2;
            this.rdoFeettoMeeters.TabStop = true;
            this.rdoFeettoMeeters.Text = "Feet to Meters";
            this.rdoFeettoMeeters.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(604, 288);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(94, 29);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "Calculate";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(473, 288);
            this.txt1.Name = "txt1";
            this.txt1.PlaceholderText = "Enter # value";
            this.txt1.Size = new System.Drawing.Size(125, 27);
            this.txt1.TabIndex = 4;
            this.txt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rtf1
            // 
            this.rtf1.Location = new System.Drawing.Point(715, 288);
            this.rtf1.Name = "rtf1";
            this.rtf1.Size = new System.Drawing.Size(228, 27);
            this.rtf1.TabIndex = 6;
            this.rtf1.Text = "";
            // 
            // rdoMilestoKilometers
            // 
            this.rdoMilestoKilometers.AutoSize = true;
            this.rdoMilestoKilometers.Location = new System.Drawing.Point(111, 348);
            this.rdoMilestoKilometers.Name = "rdoMilestoKilometers";
            this.rdoMilestoKilometers.Size = new System.Drawing.Size(158, 24);
            this.rdoMilestoKilometers.TabIndex = 8;
            this.rdoMilestoKilometers.TabStop = true;
            this.rdoMilestoKilometers.Text = "Miles to Kilometers";
            this.rdoMilestoKilometers.UseVisualStyleBackColor = true;
            // 
            // rdoKilometerstoMiles
            // 
            this.rdoKilometerstoMiles.AutoSize = true;
            this.rdoKilometerstoMiles.Location = new System.Drawing.Point(111, 307);
            this.rdoKilometerstoMiles.Name = "rdoKilometerstoMiles";
            this.rdoKilometerstoMiles.Size = new System.Drawing.Size(158, 24);
            this.rdoKilometerstoMiles.TabIndex = 7;
            this.rdoKilometerstoMiles.TabStop = true;
            this.rdoKilometerstoMiles.Text = "Kilometers to Miles";
            this.rdoKilometerstoMiles.UseVisualStyleBackColor = true;
            // 
            // rdoPoundstoKilogram
            // 
            this.rdoPoundstoKilogram.AutoSize = true;
            this.rdoPoundstoKilogram.Location = new System.Drawing.Point(289, 309);
            this.rdoPoundstoKilogram.Name = "rdoPoundstoKilogram";
            this.rdoPoundstoKilogram.Size = new System.Drawing.Size(166, 24);
            this.rdoPoundstoKilogram.TabIndex = 20;
            this.rdoPoundstoKilogram.TabStop = true;
            this.rdoPoundstoKilogram.Text = "Pounds to Kilograms";
            this.rdoPoundstoKilogram.UseVisualStyleBackColor = true;
            // 
            // rdoKilogramtoPounds
            // 
            this.rdoKilogramtoPounds.AutoSize = true;
            this.rdoKilogramtoPounds.Location = new System.Drawing.Point(289, 267);
            this.rdoKilogramtoPounds.Name = "rdoKilogramtoPounds";
            this.rdoKilogramtoPounds.Size = new System.Drawing.Size(166, 24);
            this.rdoKilogramtoPounds.TabIndex = 19;
            this.rdoKilogramtoPounds.TabStop = true;
            this.rdoKilogramtoPounds.Text = "Kilograms to Pounds";
            this.rdoKilogramtoPounds.UseVisualStyleBackColor = true;
            // 
            // rdoFahrenheittoCelsius
            // 
            this.rdoFahrenheittoCelsius.AutoSize = true;
            this.rdoFahrenheittoCelsius.Location = new System.Drawing.Point(289, 225);
            this.rdoFahrenheittoCelsius.Name = "rdoFahrenheittoCelsius";
            this.rdoFahrenheittoCelsius.Size = new System.Drawing.Size(165, 24);
            this.rdoFahrenheittoCelsius.TabIndex = 14;
            this.rdoFahrenheittoCelsius.TabStop = true;
            this.rdoFahrenheittoCelsius.Text = "Farhenheit to Celsius";
            this.rdoFahrenheittoCelsius.UseVisualStyleBackColor = true;
            // 
            // rdoCelciustoFahrenheit
            // 
            this.rdoCelciustoFahrenheit.AutoSize = true;
            this.rdoCelciustoFahrenheit.Location = new System.Drawing.Point(111, 388);
            this.rdoCelciustoFahrenheit.Name = "rdoCelciustoFahrenheit";
            this.rdoCelciustoFahrenheit.Size = new System.Drawing.Size(165, 24);
            this.rdoCelciustoFahrenheit.TabIndex = 13;
            this.rdoCelciustoFahrenheit.TabStop = true;
            this.rdoCelciustoFahrenheit.Text = "Celsius to Fahrenheit";
            this.rdoCelciustoFahrenheit.UseVisualStyleBackColor = true;
            // 
            // rdoOuncestoGrams
            // 
            this.rdoOuncestoGrams.AutoSize = true;
            this.rdoOuncestoGrams.Location = new System.Drawing.Point(289, 391);
            this.rdoOuncestoGrams.Name = "rdoOuncestoGrams";
            this.rdoOuncestoGrams.Size = new System.Drawing.Size(142, 24);
            this.rdoOuncestoGrams.TabIndex = 26;
            this.rdoOuncestoGrams.TabStop = true;
            this.rdoOuncestoGrams.Text = "Ounces to Grams";
            this.rdoOuncestoGrams.UseVisualStyleBackColor = true;
            // 
            // rdoGramstoOunces
            // 
            this.rdoGramstoOunces.AutoSize = true;
            this.rdoGramstoOunces.Location = new System.Drawing.Point(289, 350);
            this.rdoGramstoOunces.Name = "rdoGramstoOunces";
            this.rdoGramstoOunces.Size = new System.Drawing.Size(142, 24);
            this.rdoGramstoOunces.TabIndex = 25;
            this.rdoGramstoOunces.TabStop = true;
            this.rdoGramstoOunces.Text = "Grams to Ounces";
            this.rdoGramstoOunces.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(604, 323);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(94, 29);
            this.btn2.TabIndex = 27;
            this.btn2.Text = "Clear";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // lblDirections1
            // 
            this.lblDirections1.AutoSize = true;
            this.lblDirections1.Location = new System.Drawing.Point(314, 57);
            this.lblDirections1.Name = "lblDirections1";
            this.lblDirections1.Size = new System.Drawing.Size(513, 20);
            this.lblDirections1.TabIndex = 28;
            this.lblDirections1.Text = "Select the desired conversion button and then type the value of the first unit.";
            // 
            // rdoExample
            // 
            this.rdoExample.AutoSize = true;
            this.rdoExample.Location = new System.Drawing.Point(362, 124);
            this.rdoExample.Name = "rdoExample";
            this.rdoExample.Size = new System.Drawing.Size(125, 24);
            this.rdoExample.TabIndex = 29;
            this.rdoExample.TabStop = true;
            this.rdoExample.Text = "Meters to Feet";
            this.rdoExample.UseVisualStyleBackColor = true;
            // 
            // txtExample
            // 
            this.txtExample.Location = new System.Drawing.Point(493, 124);
            this.txtExample.Name = "txtExample";
            this.txtExample.Size = new System.Drawing.Size(125, 27);
            this.txtExample.TabIndex = 30;
            this.txtExample.Text = "Enter # of meters";
            this.txtExample.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnExample1
            // 
            this.btnExample1.Location = new System.Drawing.Point(627, 158);
            this.btnExample1.Name = "btnExample1";
            this.btnExample1.Size = new System.Drawing.Size(94, 29);
            this.btnExample1.TabIndex = 33;
            this.btnExample1.Text = "Clear";
            this.btnExample1.UseVisualStyleBackColor = true;
            // 
            // rtfExample
            // 
            this.rtfExample.Location = new System.Drawing.Point(736, 122);
            this.rtfExample.Name = "rtfExample";
            this.rtfExample.Size = new System.Drawing.Size(101, 65);
            this.rtfExample.TabIndex = 32;
            this.rtfExample.Text = "Output in feet";
            // 
            // btnExample
            // 
            this.btnExample.Location = new System.Drawing.Point(627, 123);
            this.btnExample.Name = "btnExample";
            this.btnExample.Size = new System.Drawing.Size(94, 29);
            this.btnExample.TabIndex = 31;
            this.btnExample.Text = "Calculate";
            this.btnExample.UseVisualStyleBackColor = true;
            // 
            // lblDirections2
            // 
            this.lblDirections2.AutoSize = true;
            this.lblDirections2.Location = new System.Drawing.Point(314, 77);
            this.lblDirections2.Name = "lblDirections2";
            this.lblDirections2.Size = new System.Drawing.Size(502, 20);
            this.lblDirections2.TabIndex = 34;
            this.lblDirections2.Text = "Once you type the value, click calcuate and it will complete the conversion.";
            // 
            // lblExampleTitle
            // 
            this.lblExampleTitle.AutoSize = true;
            this.lblExampleTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblExampleTitle.Location = new System.Drawing.Point(298, 119);
            this.lblExampleTitle.Name = "lblExampleTitle";
            this.lblExampleTitle.Size = new System.Drawing.Size(39, 28);
            this.lblExampleTitle.TabIndex = 35;
            this.lblExampleTitle.Text = "Ex:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 507);
            this.Controls.Add(this.lblExampleTitle);
            this.Controls.Add(this.lblDirections2);
            this.Controls.Add(this.btnExample1);
            this.Controls.Add(this.rtfExample);
            this.Controls.Add(this.btnExample);
            this.Controls.Add(this.txtExample);
            this.Controls.Add(this.rdoExample);
            this.Controls.Add(this.lblDirections1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.rdoOuncestoGrams);
            this.Controls.Add(this.rdoGramstoOunces);
            this.Controls.Add(this.rdoPoundstoKilogram);
            this.Controls.Add(this.rdoKilogramtoPounds);
            this.Controls.Add(this.rdoFahrenheittoCelsius);
            this.Controls.Add(this.rdoCelciustoFahrenheit);
            this.Controls.Add(this.rdoMilestoKilometers);
            this.Controls.Add(this.rdoKilometerstoMiles);
            this.Controls.Add(this.rtf1);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.rdoFeettoMeeters);
            this.Controls.Add(this.rdoMeterstoFeet);
            this.Controls.Add(this.lblUnitConverter);
            this.Name = "Form1";
            this.Text = "Unit Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblUnitConverter;
        private RadioButton rdoMeterstoFeet;
        private RadioButton rdoFeettoMeeters;
        private Button btn1;
        private TextBox txt1;
        private RichTextBox rtf1;
        private RadioButton rdoMilestoKilometers;
        private RadioButton rdoKilometerstoMiles;
        private RadioButton rdoPoundstoKilogram;
        private RadioButton rdoKilogramtoPounds;
        private RadioButton rdoFahrenheittoCelsius;
        private RadioButton rdoCelciustoFahrenheit;
        private RadioButton rdoOuncestoGrams;
        private RadioButton rdoGramstoOunces;
        private Button btn2;
        private Label lblDirections1;
        private RadioButton rdoExample;
        private TextBox txtExample;
        private Button btnExample1;
        private RichTextBox rtfExample;
        private Button btnExample;
        private Label lblDirections2;
        private Label lblExampleTitle;
    }
}