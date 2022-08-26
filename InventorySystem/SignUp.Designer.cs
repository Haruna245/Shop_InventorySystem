namespace InventorySystem
{
    partial class SignUp
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
            this.fname = new System.Windows.Forms.TextBox();
            this.Lname = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.confPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Registerbtn = new System.Windows.Forms.Button();
            this.PhoneNum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Admin = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SIGN UP";
            // 
            // fname
            // 
            this.fname.Location = new System.Drawing.Point(327, 80);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(325, 20);
            this.fname.TabIndex = 1;
            this.fname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Lname
            // 
            this.Lname.Location = new System.Drawing.Point(327, 116);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(325, 20);
            this.Lname.TabIndex = 1;
            this.Lname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(327, 151);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(325, 20);
            this.Email.TabIndex = 1;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(327, 186);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(325, 20);
            this.Password.TabIndex = 1;
            // 
            // confPassword
            // 
            this.confPassword.Location = new System.Drawing.Point(327, 221);
            this.confPassword.Name = "confPassword";
            this.confPassword.Size = new System.Drawing.Size(325, 20);
            this.confPassword.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Firstname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lastname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(268, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(230, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Confirm Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(268, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "UserType";
            // 
            // Registerbtn
            // 
            this.Registerbtn.Location = new System.Drawing.Point(384, 342);
            this.Registerbtn.Name = "Registerbtn";
            this.Registerbtn.Size = new System.Drawing.Size(157, 34);
            this.Registerbtn.TabIndex = 5;
            this.Registerbtn.Text = "Register";
            this.Registerbtn.UseVisualStyleBackColor = true;
            this.Registerbtn.Click += new System.EventHandler(this.Registerbtn_Click);
            // 
            // PhoneNum
            // 
            this.PhoneNum.Location = new System.Drawing.Point(327, 260);
            this.PhoneNum.Name = "PhoneNum";
            this.PhoneNum.Size = new System.Drawing.Size(325, 20);
            this.PhoneNum.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(230, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Phone Number";
            // 
            // Admin
            // 
            this.Admin.FormattingEnabled = true;
            this.Admin.Items.AddRange(new object[] {
            "Admin",
            "Attendant"});
            this.Admin.Location = new System.Drawing.Point(327, 294);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(148, 21);
            this.Admin.TabIndex = 6;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 403);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.Registerbtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PhoneNum);
            this.Controls.Add(this.confPassword);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Lname);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.label1);
            this.Name = "SignUp";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.TextBox Lname;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox confPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Registerbtn;
        private System.Windows.Forms.TextBox PhoneNum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Admin;
    }
}