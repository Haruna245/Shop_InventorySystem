namespace InventorySystem
{
    partial class UpdatePage
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
            this.ProdID = new System.Windows.Forms.TextBox();
            this.Pname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ManuDate = new System.Windows.Forms.DateTimePicker();
            this.ExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.Price = new System.Windows.Forms.NumericUpDown();
            this.Qnty = new System.Windows.Forms.NumericUpDown();
            this.UpdateBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Qnty)).BeginInit();
            this.SuspendLayout();
            // 
            // ProdID
            // 
            this.ProdID.Location = new System.Drawing.Point(254, 60);
            this.ProdID.Name = "ProdID";
            this.ProdID.Size = new System.Drawing.Size(338, 20);
            this.ProdID.TabIndex = 0;
            // 
            // Pname
            // 
            this.Pname.Location = new System.Drawing.Point(254, 101);
            this.Pname.Name = "Pname";
            this.Pname.Size = new System.Drawing.Size(338, 20);
            this.Pname.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ProductID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ProductName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Manufacturing Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Expiry Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Quantity";
            // 
            // ManuDate
            // 
            this.ManuDate.CustomFormat = "yyyy-MM-dd";
            this.ManuDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ManuDate.Location = new System.Drawing.Point(270, 188);
            this.ManuDate.Name = "ManuDate";
            this.ManuDate.Size = new System.Drawing.Size(200, 20);
            this.ManuDate.TabIndex = 2;
            // 
            // ExpiryDate
            // 
            this.ExpiryDate.CustomFormat = "yyyy-MM-dd";
            this.ExpiryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ExpiryDate.Location = new System.Drawing.Point(270, 230);
            this.ExpiryDate.Name = "ExpiryDate";
            this.ExpiryDate.Size = new System.Drawing.Size(200, 20);
            this.ExpiryDate.TabIndex = 2;
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(264, 146);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(138, 20);
            this.Price.TabIndex = 3;
            // 
            // Qnty
            // 
            this.Qnty.Location = new System.Drawing.Point(270, 280);
            this.Qnty.Name = "Qnty";
            this.Qnty.Size = new System.Drawing.Size(138, 20);
            this.Qnty.TabIndex = 3;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(380, 340);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 32);
            this.UpdateBtn.TabIndex = 4;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // UpdatePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.Qnty);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.ExpiryDate);
            this.Controls.Add(this.ManuDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pname);
            this.Controls.Add(this.ProdID);
            this.Name = "UpdatePage";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.Price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Qnty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ProdID;
        private System.Windows.Forms.TextBox Pname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker ManuDate;
        private System.Windows.Forms.DateTimePicker ExpiryDate;
        private System.Windows.Forms.NumericUpDown Price;
        private System.Windows.Forms.NumericUpDown Qnty;
        private System.Windows.Forms.Button UpdateBtn;
    }
}