namespace CISK343_Assignment5_Douglas.Lee
{
    partial class fmMain
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
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtHRate = new System.Windows.Forms.TextBox();
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.btnCalcPay = new System.Windows.Forms.Button();
            this.rbtnHourly = new System.Windows.Forms.RadioButton();
            this.rbtnCommission = new System.Windows.Forms.RadioButton();
            this.rbtnSalaried = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mskTxtHours = new System.Windows.Forms.MaskedTextBox();
            this.gBoxHourly = new System.Windows.Forms.GroupBox();
            this.gBoxSalary = new System.Windows.Forms.GroupBox();
            this.mskTxtSalary = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnListEmps = new System.Windows.Forms.Button();
            this.gBoxSales = new System.Windows.Forms.GroupBox();
            this.mskTxtSales = new System.Windows.Forms.MaskedTextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gBoxHourly.SuspendLayout();
            this.gBoxSalary.SuspendLayout();
            this.gBoxSales.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(194, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 55);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-16, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(317, 55);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hourly Rate: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(115, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 55);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hours: ";
            // 
            // txtFName
            // 
            this.txtFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFName.Location = new System.Drawing.Point(580, 87);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(531, 61);
            this.txtFName.TabIndex = 0;
            this.txtFName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFName_KeyPress);
            // 
            // txtLName
            // 
            this.txtLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLName.Location = new System.Drawing.Point(580, 188);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(528, 61);
            this.txtLName.TabIndex = 1;
            this.txtLName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFName_KeyPress);
            // 
            // txtHRate
            // 
            this.txtHRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHRate.Location = new System.Drawing.Point(399, 35);
            this.txtHRate.Name = "txtHRate";
            this.txtHRate.Size = new System.Drawing.Size(534, 61);
            this.txtHRate.TabIndex = 6;
            this.txtHRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHRate_KeyPress);
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmp.Location = new System.Drawing.Point(208, 876);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(287, 163);
            this.btnAddEmp.TabIndex = 4;
            this.btnAddEmp.Text = "Add Employee";
            this.btnAddEmp.UseVisualStyleBackColor = false;
            this.btnAddEmp.Click += new System.EventHandler(this.btnAddEmp_Click);
            // 
            // btnCalcPay
            // 
            this.btnCalcPay.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCalcPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcPay.Location = new System.Drawing.Point(843, 876);
            this.btnCalcPay.Name = "btnCalcPay";
            this.btnCalcPay.Size = new System.Drawing.Size(287, 163);
            this.btnCalcPay.TabIndex = 6;
            this.btnCalcPay.Text = "Calculate Pay";
            this.btnCalcPay.UseVisualStyleBackColor = false;
            this.btnCalcPay.Click += new System.EventHandler(this.button3_Click);
            // 
            // rbtnHourly
            // 
            this.rbtnHourly.AutoSize = true;
            this.rbtnHourly.Checked = true;
            this.rbtnHourly.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnHourly.Location = new System.Drawing.Point(60, 101);
            this.rbtnHourly.Name = "rbtnHourly";
            this.rbtnHourly.Size = new System.Drawing.Size(206, 59);
            this.rbtnHourly.TabIndex = 0;
            this.rbtnHourly.TabStop = true;
            this.rbtnHourly.Text = "Hourly";
            this.rbtnHourly.UseVisualStyleBackColor = true;
            this.rbtnHourly.CheckedChanged += new System.EventHandler(this.rbtnHourly_CheckedChanged);
            // 
            // rbtnCommission
            // 
            this.rbtnCommission.AutoSize = true;
            this.rbtnCommission.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCommission.Location = new System.Drawing.Point(334, 101);
            this.rbtnCommission.Name = "rbtnCommission";
            this.rbtnCommission.Size = new System.Drawing.Size(335, 59);
            this.rbtnCommission.TabIndex = 1;
            this.rbtnCommission.Text = "Commission";
            this.rbtnCommission.UseVisualStyleBackColor = true;
            this.rbtnCommission.CheckedChanged += new System.EventHandler(this.rbtnCommission_CheckedChanged);
            // 
            // rbtnSalaried
            // 
            this.rbtnSalaried.AutoSize = true;
            this.rbtnSalaried.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSalaried.Location = new System.Drawing.Point(751, 101);
            this.rbtnSalaried.Name = "rbtnSalaried";
            this.rbtnSalaried.Size = new System.Drawing.Size(245, 59);
            this.rbtnSalaried.TabIndex = 2;
            this.rbtnSalaried.Text = "Salaried";
            this.rbtnSalaried.UseVisualStyleBackColor = true;
            this.rbtnSalaried.CheckedChanged += new System.EventHandler(this.rbtnSalaried_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.rbtnSalaried);
            this.groupBox1.Controls.Add(this.rbtnHourly);
            this.groupBox1.Controls.Add(this.rbtnCommission);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(175, 362);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1083, 218);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type";
            // 
            // mskTxtHours
            // 
            this.mskTxtHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTxtHours.Location = new System.Drawing.Point(399, 155);
            this.mskTxtHours.Mask = "00.0";
            this.mskTxtHours.Name = "mskTxtHours";
            this.mskTxtHours.Size = new System.Drawing.Size(534, 61);
            this.mskTxtHours.TabIndex = 15;
            // 
            // gBoxHourly
            // 
            this.gBoxHourly.Controls.Add(this.mskTxtHours);
            this.gBoxHourly.Controls.Add(this.txtHRate);
            this.gBoxHourly.Controls.Add(this.label4);
            this.gBoxHourly.Controls.Add(this.label3);
            this.gBoxHourly.Location = new System.Drawing.Point(175, 583);
            this.gBoxHourly.Name = "gBoxHourly";
            this.gBoxHourly.Size = new System.Drawing.Size(1083, 245);
            this.gBoxHourly.TabIndex = 16;
            this.gBoxHourly.TabStop = false;
            // 
            // gBoxSalary
            // 
            this.gBoxSalary.Controls.Add(this.mskTxtSalary);
            this.gBoxSalary.Controls.Add(this.label6);
            this.gBoxSalary.Location = new System.Drawing.Point(175, 590);
            this.gBoxSalary.Name = "gBoxSalary";
            this.gBoxSalary.Size = new System.Drawing.Size(1038, 232);
            this.gBoxSalary.TabIndex = 17;
            this.gBoxSalary.TabStop = false;
            // 
            // mskTxtSalary
            // 
            this.mskTxtSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTxtSalary.Location = new System.Drawing.Point(399, 35);
            this.mskTxtSalary.Mask = "000000.00";
            this.mskTxtSalary.Name = "mskTxtSalary";
            this.mskTxtSalary.Size = new System.Drawing.Size(537, 61);
            this.mskTxtSalary.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(107, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 55);
            this.label6.TabIndex = 2;
            this.label6.Text = "Salary: ";
            // 
            // btnListEmps
            // 
            this.btnListEmps.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnListEmps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListEmps.Location = new System.Drawing.Point(534, 876);
            this.btnListEmps.Name = "btnListEmps";
            this.btnListEmps.Size = new System.Drawing.Size(270, 163);
            this.btnListEmps.TabIndex = 5;
            this.btnListEmps.Text = "List Employees";
            this.btnListEmps.UseVisualStyleBackColor = false;
            this.btnListEmps.Click += new System.EventHandler(this.btnListEmps_Click);
            // 
            // gBoxSales
            // 
            this.gBoxSales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gBoxSales.Controls.Add(this.mskTxtSales);
            this.gBoxSales.Controls.Add(this.label23);
            this.gBoxSales.Location = new System.Drawing.Point(175, 597);
            this.gBoxSales.Name = "gBoxSales";
            this.gBoxSales.Size = new System.Drawing.Size(1077, 179);
            this.gBoxSales.TabIndex = 3;
            this.gBoxSales.TabStop = false;
            // 
            // mskTxtSales
            // 
            this.mskTxtSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTxtSales.Location = new System.Drawing.Point(399, 27);
            this.mskTxtSales.Mask = "00000.00";
            this.mskTxtSales.Name = "mskTxtSales";
            this.mskTxtSales.Size = new System.Drawing.Size(534, 61);
            this.mskTxtSales.TabIndex = 0;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(124, 30);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(177, 55);
            this.label23.TabIndex = 2;
            this.label23.Text = "Sales: ";
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1330, 1109);
            this.Controls.Add(this.gBoxSales);
            this.Controls.Add(this.gBoxSalary);
            this.Controls.Add(this.btnListEmps);
            this.Controls.Add(this.gBoxHourly);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCalcPay);
            this.Controls.Add(this.btnAddEmp);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fmMain";
            this.Text = "Employee Inheritance";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gBoxHourly.ResumeLayout(false);
            this.gBoxHourly.PerformLayout();
            this.gBoxSalary.ResumeLayout(false);
            this.gBoxSalary.PerformLayout();
            this.gBoxSales.ResumeLayout(false);
            this.gBoxSales.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtHRate;
        private System.Windows.Forms.Button btnAddEmp;
        private System.Windows.Forms.Button btnCalcPay;
        private System.Windows.Forms.RadioButton rbtnHourly;
        private System.Windows.Forms.RadioButton rbtnCommission;
        private System.Windows.Forms.RadioButton rbtnSalaried;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mskTxtHours;
        private System.Windows.Forms.GroupBox gBoxHourly;
        private System.Windows.Forms.Button btnListEmps;
        private System.Windows.Forms.GroupBox gBoxSalary;
        private System.Windows.Forms.MaskedTextBox mskTxtSalary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gBoxSales;
        private System.Windows.Forms.MaskedTextBox mskTxtSales;
        private System.Windows.Forms.Label label23;
    }
}

