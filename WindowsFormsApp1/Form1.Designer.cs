namespace WindowsFormsApp1
{
    partial class StaffBenefits
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbSalary = new System.Windows.Forms.TextBox();
            this.tbLeave = new System.Windows.Forms.TextBox();
            this.tbTransportation = new System.Windows.Forms.TextBox();
            this.tbHousing = new System.Windows.Forms.TextBox();
            this.tbBasic = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tbSalary);
            this.groupBox1.Controls.Add(this.tbLeave);
            this.groupBox1.Controls.Add(this.tbTransportation);
            this.groupBox1.Controls.Add(this.tbHousing);
            this.groupBox1.Controls.Add(this.tbBasic);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(-6, -6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(816, 433);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(267, 19);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 13;
            this.button6.Text = "Help";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(184, 18);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "Project";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(101, 18);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Edit";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(18, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "File";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(529, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Leave Allowance";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(288, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Salary";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbSalary
            // 
            this.tbSalary.Location = new System.Drawing.Point(237, 265);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Size = new System.Drawing.Size(180, 20);
            this.tbSalary.TabIndex = 7;
            // 
            // tbLeave
            // 
            this.tbLeave.Location = new System.Drawing.Point(504, 265);
            this.tbLeave.Name = "tbLeave";
            this.tbLeave.Size = new System.Drawing.Size(184, 20);
            this.tbLeave.TabIndex = 6;
            // 
            // tbTransportation
            // 
            this.tbTransportation.Location = new System.Drawing.Point(114, 180);
            this.tbTransportation.Name = "tbTransportation";
            this.tbTransportation.Size = new System.Drawing.Size(100, 20);
            this.tbTransportation.TabIndex = 5;
            this.tbTransportation.Text = "5";
            // 
            // tbHousing
            // 
            this.tbHousing.Location = new System.Drawing.Point(114, 136);
            this.tbHousing.Name = "tbHousing";
            this.tbHousing.Size = new System.Drawing.Size(100, 20);
            this.tbHousing.TabIndex = 4;
            this.tbHousing.Text = "15";
            this.tbHousing.TextChanged += new System.EventHandler(this.tbHousing_TextChanged);
            // 
            // tbBasic
            // 
            this.tbBasic.Location = new System.Drawing.Point(114, 96);
            this.tbBasic.Name = "tbBasic";
            this.tbBasic.Size = new System.Drawing.Size(100, 20);
            this.tbBasic.TabIndex = 3;
            this.tbBasic.Text = "10";
            this.tbBasic.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Transportation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Housing";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Basic";
            // 
            // StaffBenefits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "StaffBenefits";
            this.Text = "Staff Benefits";
            this.Load += new System.EventHandler(this.StaffBenefits_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbSalary;
        private System.Windows.Forms.TextBox tbLeave;
        private System.Windows.Forms.TextBox tbTransportation;
        private System.Windows.Forms.TextBox tbHousing;
        private System.Windows.Forms.TextBox tbBasic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}

