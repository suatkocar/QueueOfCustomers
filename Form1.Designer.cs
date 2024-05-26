namespace Exercise1
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtAmountOwed = new System.Windows.Forms.TextBox();
            this.btnDequeue = new System.Windows.Forms.Button();
            this.btnPeek = new System.Windows.Forms.Button();
            this.FirstCustomers = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalCustomers = new System.Windows.Forms.Label();
            this.lblTotalAmountOwed = new System.Windows.Forms.Label();
            this.btnEnqueue = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMaxDebtCustomerInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Amount Owed:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(254, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(258, 31);
            this.txtName.TabIndex = 4;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(254, 120);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(85, 31);
            this.txtAge.TabIndex = 5;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(254, 220);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(258, 65);
            this.txtAddress.TabIndex = 6;
            // 
            // txtAmountOwed
            // 
            this.txtAmountOwed.Location = new System.Drawing.Point(254, 361);
            this.txtAmountOwed.Name = "txtAmountOwed";
            this.txtAmountOwed.Size = new System.Drawing.Size(191, 31);
            this.txtAmountOwed.TabIndex = 7;
            // 
            // btnDequeue
            // 
            this.btnDequeue.Location = new System.Drawing.Point(522, 745);
            this.btnDequeue.Name = "btnDequeue";
            this.btnDequeue.Size = new System.Drawing.Size(141, 53);
            this.btnDequeue.TabIndex = 9;
            this.btnDequeue.Text = "Dequeue";
            this.btnDequeue.UseVisualStyleBackColor = true;
            this.btnDequeue.Click += new System.EventHandler(this.btnDequeue_Click);
            // 
            // btnPeek
            // 
            this.btnPeek.Location = new System.Drawing.Point(855, 745);
            this.btnPeek.Name = "btnPeek";
            this.btnPeek.Size = new System.Drawing.Size(141, 53);
            this.btnPeek.TabIndex = 10;
            this.btnPeek.Text = "Peek";
            this.btnPeek.UseVisualStyleBackColor = true;
            this.btnPeek.Click += new System.EventHandler(this.btnPeek_Click);
            // 
            // FirstCustomers
            // 
            this.FirstCustomers.FormattingEnabled = true;
            this.FirstCustomers.ItemHeight = 25;
            this.FirstCustomers.Location = new System.Drawing.Point(554, 35);
            this.FirstCustomers.Name = "FirstCustomers";
            this.FirstCustomers.Size = new System.Drawing.Size(688, 529);
            this.FirstCustomers.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(549, 586);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Total Customers:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(549, 687);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Total Amount Owed:";
            // 
            // lblTotalCustomers
            // 
            this.lblTotalCustomers.AutoSize = true;
            this.lblTotalCustomers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalCustomers.Location = new System.Drawing.Point(776, 586);
            this.lblTotalCustomers.Name = "lblTotalCustomers";
            this.lblTotalCustomers.Size = new System.Drawing.Size(2, 27);
            this.lblTotalCustomers.TabIndex = 14;
            // 
            // lblTotalAmountOwed
            // 
            this.lblTotalAmountOwed.AutoSize = true;
            this.lblTotalAmountOwed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalAmountOwed.Location = new System.Drawing.Point(776, 685);
            this.lblTotalAmountOwed.Name = "lblTotalAmountOwed";
            this.lblTotalAmountOwed.Size = new System.Drawing.Size(2, 27);
            this.lblTotalAmountOwed.TabIndex = 15;
            // 
            // btnEnqueue
            // 
            this.btnEnqueue.Location = new System.Drawing.Point(226, 745);
            this.btnEnqueue.Name = "btnEnqueue";
            this.btnEnqueue.Size = new System.Drawing.Size(141, 53);
            this.btnEnqueue.TabIndex = 16;
            this.btnEnqueue.Text = "Enqueue";
            this.btnEnqueue.UseVisualStyleBackColor = true;
            this.btnEnqueue.Click += new System.EventHandler(this.btnEnqueue_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(549, 633);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Max Owed Customer:";
            // 
            // lblMaxDebtCustomerInfo
            // 
            this.lblMaxDebtCustomerInfo.AutoSize = true;
            this.lblMaxDebtCustomerInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMaxDebtCustomerInfo.Location = new System.Drawing.Point(776, 633);
            this.lblMaxDebtCustomerInfo.Name = "lblMaxDebtCustomerInfo";
            this.lblMaxDebtCustomerInfo.Size = new System.Drawing.Size(2, 27);
            this.lblMaxDebtCustomerInfo.TabIndex = 18;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1489, 887);
            this.Controls.Add(this.lblMaxDebtCustomerInfo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnEnqueue);
            this.Controls.Add(this.lblTotalAmountOwed);
            this.Controls.Add(this.lblTotalCustomers);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FirstCustomers);
            this.Controls.Add(this.btnPeek);
            this.Controls.Add(this.btnDequeue);
            this.Controls.Add(this.txtAmountOwed);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtAmountOwed;
        private System.Windows.Forms.Button btnDequeue;
        private System.Windows.Forms.Button btnPeek;
        private System.Windows.Forms.ListBox FirstCustomers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotalCustomers;
        private System.Windows.Forms.Label lblTotalAmountOwed;
        private System.Windows.Forms.Button btnEnqueue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblMaxDebtCustomerInfo;
    }
}

