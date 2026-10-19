namespace Management_System
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCustomerAge = new System.Windows.Forms.TextBox();
            this.txtRentalDays = new System.Windows.Forms.TextBox();
            this.txtDrivingExperience = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rdoEconomy = new System.Windows.Forms.RadioButton();
            this.rdoSUV = new System.Windows.Forms.RadioButton();
            this.rdoLuxury = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.chkInsurance = new System.Windows.Forms.CheckBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstRental = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(51, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(62, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(-1, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of Rental Days";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(-1, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Years of Driving Experience";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(240, 36);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(146, 26);
            this.txtCustomerName.TabIndex = 4;
            // 
            // txtCustomerAge
            // 
            this.txtCustomerAge.Location = new System.Drawing.Point(240, 80);
            this.txtCustomerAge.Name = "txtCustomerAge";
            this.txtCustomerAge.Size = new System.Drawing.Size(146, 26);
            this.txtCustomerAge.TabIndex = 5;
            // 
            // txtRentalDays
            // 
            this.txtRentalDays.Location = new System.Drawing.Point(240, 130);
            this.txtRentalDays.Name = "txtRentalDays";
            this.txtRentalDays.Size = new System.Drawing.Size(146, 26);
            this.txtRentalDays.TabIndex = 6;
            // 
            // txtDrivingExperience
            // 
            this.txtDrivingExperience.Location = new System.Drawing.Point(240, 174);
            this.txtDrivingExperience.Name = "txtDrivingExperience";
            this.txtDrivingExperience.Size = new System.Drawing.Size(146, 26);
            this.txtDrivingExperience.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(12, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Vehicle Type";
            // 
            // rdoEconomy
            // 
            this.rdoEconomy.AutoSize = true;
            this.rdoEconomy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoEconomy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdoEconomy.Location = new System.Drawing.Point(16, 273);
            this.rdoEconomy.Name = "rdoEconomy";
            this.rdoEconomy.Size = new System.Drawing.Size(107, 24);
            this.rdoEconomy.TabIndex = 9;
            this.rdoEconomy.TabStop = true;
            this.rdoEconomy.Text = "Economy";
            this.rdoEconomy.UseVisualStyleBackColor = true;
            // 
            // rdoSUV
            // 
            this.rdoSUV.AutoSize = true;
            this.rdoSUV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSUV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdoSUV.Location = new System.Drawing.Point(180, 273);
            this.rdoSUV.Name = "rdoSUV";
            this.rdoSUV.Size = new System.Drawing.Size(71, 24);
            this.rdoSUV.TabIndex = 10;
            this.rdoSUV.TabStop = true;
            this.rdoSUV.Text = "SUV";
            this.rdoSUV.UseVisualStyleBackColor = true;
            // 
            // rdoLuxury
            // 
            this.rdoLuxury.AutoSize = true;
            this.rdoLuxury.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoLuxury.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdoLuxury.Location = new System.Drawing.Point(331, 273);
            this.rdoLuxury.Name = "rdoLuxury";
            this.rdoLuxury.Size = new System.Drawing.Size(86, 24);
            this.rdoLuxury.TabIndex = 11;
            this.rdoLuxury.TabStop = true;
            this.rdoLuxury.Text = "Luxury";
            this.rdoLuxury.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(12, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "insurence option";
            // 
            // chkInsurance
            // 
            this.chkInsurance.AutoSize = true;
            this.chkInsurance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkInsurance.Location = new System.Drawing.Point(12, 356);
            this.chkInsurance.Name = "chkInsurance";
            this.chkInsurance.Size = new System.Drawing.Size(234, 24);
            this.chkInsurance.TabIndex = 13;
            this.chkInsurance.Text = "Add insurance($15 per day) ";
            this.chkInsurance.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCalculate.Location = new System.Drawing.Point(16, 393);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(107, 37);
            this.btnCalculate.TabIndex = 14;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClear.Location = new System.Drawing.Point(156, 393);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 37);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.Location = new System.Drawing.Point(266, 393);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 34);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lstRental
            // 
            this.lstRental.FormattingEnabled = true;
            this.lstRental.ItemHeight = 20;
            this.lstRental.Location = new System.Drawing.Point(479, 34);
            this.lstRental.Name = "lstRental";
            this.lstRental.Size = new System.Drawing.Size(243, 344);
            this.lstRental.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 450);
            this.Controls.Add(this.lstRental);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.chkInsurance);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rdoLuxury);
            this.Controls.Add(this.rdoSUV);
            this.Controls.Add(this.rdoEconomy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDrivingExperience);
            this.Controls.Add(this.txtRentalDays);
            this.Controls.Add(this.txtCustomerAge);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Form1";
            this.Text = "Customer information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCustomerAge;
        private System.Windows.Forms.TextBox txtRentalDays;
        private System.Windows.Forms.TextBox txtDrivingExperience;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdoEconomy;
        private System.Windows.Forms.RadioButton rdoSUV;
        private System.Windows.Forms.RadioButton rdoLuxury;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkInsurance;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lstRental;
    }
}

