namespace ConverterApp
{
    partial class frm_Main
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
            this.lbl_UofM = new System.Windows.Forms.Label();
            this.txt_UnitOfMeasure = new System.Windows.Forms.TextBox();
            this.btn_centimetres_to_inches = new System.Windows.Forms.Button();
            this.btn_metres_to_feet = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.txt_Convert = new System.Windows.Forms.TextBox();
            this.btn_celsius_to_fahrenheit = new System.Windows.Forms.Button();
            this.btn_centimetres_to_feet = new System.Windows.Forms.Button();
            this.btn_kilometres_to_miles = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelEntryCheck = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_UofM
            // 
            this.lbl_UofM.AutoSize = true;
            this.lbl_UofM.Location = new System.Drawing.Point(11, 20);
            this.lbl_UofM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_UofM.Name = "lbl_UofM";
            this.lbl_UofM.Size = new System.Drawing.Size(139, 13);
            this.lbl_UofM.TabIndex = 0;
            this.lbl_UofM.Text = "Enter Unit of Measure Here:";
            // 
            // txt_UnitOfMeasure
            // 
            this.txt_UnitOfMeasure.Location = new System.Drawing.Point(154, 17);
            this.txt_UnitOfMeasure.Margin = new System.Windows.Forms.Padding(2);
            this.txt_UnitOfMeasure.Name = "txt_UnitOfMeasure";
            this.txt_UnitOfMeasure.Size = new System.Drawing.Size(106, 20);
            this.txt_UnitOfMeasure.TabIndex = 1;
            // 
            // btn_centimetres_to_inches
            // 
            this.btn_centimetres_to_inches.Location = new System.Drawing.Point(12, 41);
            this.btn_centimetres_to_inches.Margin = new System.Windows.Forms.Padding(2);
            this.btn_centimetres_to_inches.Name = "btn_centimetres_to_inches";
            this.btn_centimetres_to_inches.Size = new System.Drawing.Size(122, 19);
            this.btn_centimetres_to_inches.TabIndex = 2;
            this.btn_centimetres_to_inches.Text = "Centimetres to Inches";
            this.btn_centimetres_to_inches.UseVisualStyleBackColor = true;
            this.btn_centimetres_to_inches.Click += new System.EventHandler(this.btn_centimetres_to_inches_Click);
            // 
            // btn_metres_to_feet
            // 
            this.btn_metres_to_feet.Location = new System.Drawing.Point(138, 41);
            this.btn_metres_to_feet.Margin = new System.Windows.Forms.Padding(2);
            this.btn_metres_to_feet.Name = "btn_metres_to_feet";
            this.btn_metres_to_feet.Size = new System.Drawing.Size(122, 19);
            this.btn_metres_to_feet.TabIndex = 3;
            this.btn_metres_to_feet.Text = "Metres to Feet";
            this.btn_metres_to_feet.UseVisualStyleBackColor = true;
            this.btn_metres_to_feet.Click += new System.EventHandler(this.btn_metres_to_feet_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(105, 134);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(56, 19);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.Text = "EXIT";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // txt_Convert
            // 
            this.txt_Convert.Location = new System.Drawing.Point(72, 110);
            this.txt_Convert.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Convert.Name = "txt_Convert";
            this.txt_Convert.ReadOnly = true;
            this.txt_Convert.Size = new System.Drawing.Size(122, 20);
            this.txt_Convert.TabIndex = 7;
            // 
            // btn_celsius_to_fahrenheit
            // 
            this.btn_celsius_to_fahrenheit.Location = new System.Drawing.Point(12, 64);
            this.btn_celsius_to_fahrenheit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_celsius_to_fahrenheit.Name = "btn_celsius_to_fahrenheit";
            this.btn_celsius_to_fahrenheit.Size = new System.Drawing.Size(122, 19);
            this.btn_celsius_to_fahrenheit.TabIndex = 8;
            this.btn_celsius_to_fahrenheit.Text = "Celsius to Fahrenheit";
            this.btn_celsius_to_fahrenheit.UseVisualStyleBackColor = true;
            this.btn_celsius_to_fahrenheit.Click += new System.EventHandler(this.btn_celsius_to_fahrenheit_Click);
            // 
            // btn_centimetres_to_feet
            // 
            this.btn_centimetres_to_feet.Location = new System.Drawing.Point(138, 64);
            this.btn_centimetres_to_feet.Margin = new System.Windows.Forms.Padding(2);
            this.btn_centimetres_to_feet.Name = "btn_centimetres_to_feet";
            this.btn_centimetres_to_feet.Size = new System.Drawing.Size(122, 19);
            this.btn_centimetres_to_feet.TabIndex = 9;
            this.btn_centimetres_to_feet.Text = "Centimetres to Feet";
            this.btn_centimetres_to_feet.UseVisualStyleBackColor = true;
            this.btn_centimetres_to_feet.Click += new System.EventHandler(this.btn_centimetres_to_feet_Click);
            // 
            // btn_kilometres_to_miles
            // 
            this.btn_kilometres_to_miles.Location = new System.Drawing.Point(72, 87);
            this.btn_kilometres_to_miles.Margin = new System.Windows.Forms.Padding(2);
            this.btn_kilometres_to_miles.Name = "btn_kilometres_to_miles";
            this.btn_kilometres_to_miles.Size = new System.Drawing.Size(122, 19);
            this.btn_kilometres_to_miles.TabIndex = 10;
            this.btn_kilometres_to_miles.Text = "Kilometres to Miles";
            this.btn_kilometres_to_miles.UseVisualStyleBackColor = true;
            this.btn_kilometres_to_miles.Click += new System.EventHandler(this.btn_kilometres_to_miles_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(14, 158);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(246, 82);
            this.listBox1.TabIndex = 11;
            // 
            // labelEntryCheck
            // 
            this.labelEntryCheck.AutoSize = true;
            this.labelEntryCheck.Location = new System.Drawing.Point(12, 246);
            this.labelEntryCheck.Name = "labelEntryCheck";
            this.labelEntryCheck.Size = new System.Drawing.Size(141, 13);
            this.labelEntryCheck.TabIndex = 12;
            this.labelEntryCheck.Text = "5 Entries have been entered";
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 275);
            this.Controls.Add(this.labelEntryCheck);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_kilometres_to_miles);
            this.Controls.Add(this.btn_centimetres_to_feet);
            this.Controls.Add(this.btn_celsius_to_fahrenheit);
            this.Controls.Add(this.txt_Convert);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_metres_to_feet);
            this.Controls.Add(this.btn_centimetres_to_inches);
            this.Controls.Add(this.txt_UnitOfMeasure);
            this.Controls.Add(this.lbl_UofM);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_Main";
            this.Text = "ATCA Gas Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_UofM;
        private System.Windows.Forms.TextBox txt_UnitOfMeasure;
        private System.Windows.Forms.Button btn_centimetres_to_inches;
        private System.Windows.Forms.Button btn_metres_to_feet;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.TextBox txt_Convert;
        private System.Windows.Forms.Button btn_celsius_to_fahrenheit;
        private System.Windows.Forms.Button btn_centimetres_to_feet;
        private System.Windows.Forms.Button btn_kilometres_to_miles;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labelEntryCheck;
    }
}

