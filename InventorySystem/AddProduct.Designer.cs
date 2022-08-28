namespace InventorySystem
{
    partial class AddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProduct));
            this.label1 = new System.Windows.Forms.Label();
            this.Pname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.ManuDate = new System.Windows.Forms.DateTimePicker();
            this.Price = new System.Windows.Forms.NumericUpDown();
            this.Qnty = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Qnty)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADD PRODUCT";
            // 
            // Pname
            // 
            this.Pname.Location = new System.Drawing.Point(314, 76);
            this.Pname.Name = "Pname";
            this.Pname.Size = new System.Drawing.Size(200, 20);
            this.Pname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Manufacture Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Expiry Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(233, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Quantity";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(351, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExpiryDate
            // 
            this.ExpiryDate.CustomFormat = "yyyy-MM-dd";
            this.ExpiryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ExpiryDate.Location = new System.Drawing.Point(314, 191);
            this.ExpiryDate.Name = "ExpiryDate";
            this.ExpiryDate.Size = new System.Drawing.Size(200, 20);
            this.ExpiryDate.TabIndex = 4;
            // 
            // ManuDate
            // 
            this.ManuDate.CustomFormat = "yyyy-MM-dd";
            this.ManuDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ManuDate.Location = new System.Drawing.Point(314, 157);
            this.ManuDate.Name = "ManuDate";
            this.ManuDate.Size = new System.Drawing.Size(200, 20);
            this.ManuDate.TabIndex = 4;
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(314, 115);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(120, 20);
            this.Price.TabIndex = 5;
            // 
            // Qnty
            // 
            this.Qnty.Location = new System.Drawing.Point(314, 236);
            this.Qnty.Name = "Qnty";
            this.Qnty.Size = new System.Drawing.Size(120, 20);
            this.Qnty.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(342, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 36);
            this.button2.TabIndex = 6;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(291, 380);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(273, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Please  Enter only the name of the product to be deleted";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Brown;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(136, 453);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Qnty);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.ManuDate);
            this.Controls.Add(this.ExpiryDate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Pname);
            this.Controls.Add(this.label1);
            this.Name = "AddProduct";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.Price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Qnty)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Pname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker ExpiryDate;
        private System.Windows.Forms.DateTimePicker ManuDate;
        private System.Windows.Forms.NumericUpDown Price;
        private System.Windows.Forms.NumericUpDown Qnty;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}