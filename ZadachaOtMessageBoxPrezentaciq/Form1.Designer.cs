namespace ZadachaOtMessageBoxPrezentaciq
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
            lblName = new Label();
            lblLname = new Label();
            lblsalary = new Label();
            txtBname = new TextBox();
            txtBnameL = new TextBox();
            txtBSalary = new TextBox();
            cmb = new ComboBox();
            chBox = new CheckBox();
            btnEnter = new Button();
            lblJob = new Label();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Calisto MT", 16.2F, FontStyle.Bold);
            lblName.Location = new Point(18, 37);
            lblName.Name = "lblName";
            lblName.Size = new Size(98, 32);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            // 
            // lblLname
            // 
            lblLname.AutoSize = true;
            lblLname.Font = new Font("Calisto MT", 16.2F, FontStyle.Bold);
            lblLname.Location = new Point(18, 159);
            lblLname.Name = "lblLname";
            lblLname.Size = new Size(151, 32);
            lblLname.TabIndex = 1;
            lblLname.Text = "Last name:";
            
            // 
            // lblsalary
            // 
            lblsalary.AutoSize = true;
            lblsalary.Font = new Font("Calisto MT", 16.2F, FontStyle.Bold);
            lblsalary.Location = new Point(18, 302);
            lblsalary.Name = "lblsalary";
            lblsalary.Size = new Size(101, 32);
            lblsalary.TabIndex = 2;
            lblsalary.Text = "Salary:";
            // 
            // txtBname
            // 
            txtBname.Font = new Font("Calisto MT", 16.2F, FontStyle.Bold);
            txtBname.Location = new Point(18, 72);
            txtBname.Name = "txtBname";
            txtBname.Size = new Size(202, 39);
            txtBname.TabIndex = 3;
            // 
            // txtBnameL
            // 
            txtBnameL.Font = new Font("Calisto MT", 16.2F, FontStyle.Bold);
            txtBnameL.Location = new Point(18, 209);
            txtBnameL.Name = "txtBnameL";
            txtBnameL.Size = new Size(202, 39);
            txtBnameL.TabIndex = 4;
            // 
            // txtBSalary
            // 
            txtBSalary.Font = new Font("Calisto MT", 16.2F, FontStyle.Bold);
            txtBSalary.Location = new Point(18, 337);
            txtBSalary.Name = "txtBSalary";
            txtBSalary.Size = new Size(123, 39);
            txtBSalary.TabIndex = 5;
            // 
            // cmb
            // 
            cmb.Font = new Font("Calisto MT", 16.2F, FontStyle.Bold);
            cmb.FormattingEnabled = true;
            cmb.Items.AddRange(new object[] { "Engineer", "Programmer", "Worker", "Chef", "Waiter" });
            cmb.Location = new Point(228, 72);
            cmb.Name = "cmb";
            cmb.Size = new Size(242, 39);
            cmb.TabIndex = 6;
            // 
            // chBox
            // 
            chBox.AutoSize = true;
            chBox.Font = new Font("Calisto MT", 16.2F, FontStyle.Bold);
            chBox.Location = new Point(162, 337);
            chBox.Name = "chBox";
            chBox.Size = new Size(93, 36);
            chBox.TabIndex = 7;
            chBox.Text = "Man";
            chBox.UseVisualStyleBackColor = true;
            // 
            // btnEnter
            // 
            btnEnter.Font = new Font("Calisto MT", 16.2F, FontStyle.Bold);
            btnEnter.Location = new Point(273, 303);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(176, 102);
            btnEnter.TabIndex = 8;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // lblJob
            // 
            lblJob.AutoSize = true;
            lblJob.Font = new Font("Calisto MT", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJob.Location = new Point(228, 37);
            lblJob.Name = "lblJob";
            lblJob.Size = new Size(67, 32);
            lblJob.TabIndex = 9;
            lblJob.Text = "Job:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 432);
            Controls.Add(lblJob);
            Controls.Add(btnEnter);
            Controls.Add(chBox);
            Controls.Add(cmb);
            Controls.Add(txtBSalary);
            Controls.Add(txtBnameL);
            Controls.Add(txtBname);
            Controls.Add(lblsalary);
            Controls.Add(lblLname);
            Controls.Add(lblName);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Info";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblLname;
        private Label lblsalary;
        private TextBox txtBname;
        private TextBox txtBnameL;
        private TextBox txtBSalary;
        private ComboBox cmb;
        private CheckBox chBox;
        private Button btnEnter;
        private Label lblJob;
    }
}
