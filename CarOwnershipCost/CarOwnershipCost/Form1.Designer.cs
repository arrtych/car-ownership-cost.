namespace CarOwnershipCost
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
            this.useInYears = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.carPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.carInsurance = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.carRepair = new System.Windows.Forms.TextBox();
            this.calculatorBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.useInYears)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plan to use(in years)";
            // 
            // useInYears
            // 
            this.useInYears.Location = new System.Drawing.Point(340, 36);
            this.useInYears.Name = "useInYears";
            this.useInYears.Size = new System.Drawing.Size(82, 22);
            this.useInYears.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Car Price at time of Purchase (in euros)";
            // 
            // carPrice
            // 
            this.carPrice.Location = new System.Drawing.Point(340, 94);
            this.carPrice.Name = "carPrice";
            this.carPrice.Size = new System.Drawing.Size(82, 22);
            this.carPrice.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Insurance Cost Per Year (in euros)";
            // 
            // carInsurance
            // 
            this.carInsurance.Location = new System.Drawing.Point(340, 169);
            this.carInsurance.Name = "carInsurance";
            this.carInsurance.Size = new System.Drawing.Size(82, 22);
            this.carInsurance.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(264, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Average Repair Cost Per Year (in euros)";
            // 
            // carRepair
            // 
            this.carRepair.Location = new System.Drawing.Point(340, 235);
            this.carRepair.Name = "carRepair";
            this.carRepair.Size = new System.Drawing.Size(82, 22);
            this.carRepair.TabIndex = 7;
            // 
            // calculatorBtn
            // 
            this.calculatorBtn.Location = new System.Drawing.Point(48, 287);
            this.calculatorBtn.Name = "calculatorBtn";
            this.calculatorBtn.Size = new System.Drawing.Size(374, 39);
            this.calculatorBtn.TabIndex = 8;
            this.calculatorBtn.Text = "Calculate";
            this.calculatorBtn.UseVisualStyleBackColor = true;
            this.calculatorBtn.Click += new System.EventHandler(this.calculatorBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 356);
            this.Controls.Add(this.calculatorBtn);
            this.Controls.Add(this.carRepair);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.carInsurance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.carPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.useInYears);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Car Ownership Cost";
            ((System.ComponentModel.ISupportInitialize)(this.useInYears)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown useInYears;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox carPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox carInsurance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox carRepair;
        private System.Windows.Forms.Button calculatorBtn;
    }
}

