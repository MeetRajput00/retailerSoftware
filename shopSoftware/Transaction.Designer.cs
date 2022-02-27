namespace shopSoftware
{
    partial class Transaction
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
            this.serviceCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.paidAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.Label();
            this.receiver = new System.Windows.Forms.ComboBox();
            this.transactionSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serviceCount
            // 
            this.serviceCount.Location = new System.Drawing.Point(245, 41);
            this.serviceCount.Name = "serviceCount";
            this.serviceCount.Size = new System.Drawing.Size(166, 23);
            this.serviceCount.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(49, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Amount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(49, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "Service Count:";
            // 
            // paidAmount
            // 
            this.paidAmount.Location = new System.Drawing.Point(633, 41);
            this.paidAmount.Name = "paidAmount";
            this.paidAmount.Size = new System.Drawing.Size(166, 23);
            this.paidAmount.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(437, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 21);
            this.label5.TabIndex = 20;
            this.label5.Text = "Amount Received By:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(437, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 21);
            this.label6.TabIndex = 19;
            this.label6.Text = "Paid Amount:";
            // 
            // amount
            // 
            this.amount.AutoSize = true;
            this.amount.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.amount.Location = new System.Drawing.Point(245, 110);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(19, 21);
            this.amount.TabIndex = 22;
            this.amount.Text = "0";
            // 
            // receiver
            // 
            this.receiver.FormattingEnabled = true;
            this.receiver.Location = new System.Drawing.Point(633, 108);
            this.receiver.Name = "receiver";
            this.receiver.Size = new System.Drawing.Size(166, 23);
            this.receiver.TabIndex = 23;
            // 
            // transactionSubmit
            // 
            this.transactionSubmit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.transactionSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transactionSubmit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.transactionSubmit.Location = new System.Drawing.Point(633, 160);
            this.transactionSubmit.Name = "transactionSubmit";
            this.transactionSubmit.Size = new System.Drawing.Size(96, 34);
            this.transactionSubmit.TabIndex = 24;
            this.transactionSubmit.Text = "Submit";
            this.transactionSubmit.UseVisualStyleBackColor = false;
            this.transactionSubmit.Click += new System.EventHandler(this.transactionSubmit_Click);
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(819, 212);
            this.Controls.Add(this.transactionSubmit);
            this.Controls.Add(this.receiver);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.paidAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.serviceCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Name = "Transaction";
            this.Text = "Transaction";
            this.Load += new System.EventHandler(this.Transaction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox serviceCount;
        private Label label3;
        private Label label4;
        private TextBox paidAmount;
        private Label label5;
        private Label label6;
        private Label amount;
        private ComboBox receiver;
        private Button transactionSubmit;
    }
}