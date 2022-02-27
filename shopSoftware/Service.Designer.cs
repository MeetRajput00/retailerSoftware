namespace shopSoftware
{
    partial class Service
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
            this.serviceName = new System.Windows.Forms.TextBox();
            this.serviceCharges = new System.Windows.Forms.TextBox();
            this.serviceDescription = new System.Windows.Forms.RichTextBox();
            this.serviceSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(68, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Service Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(68, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Charges:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(68, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Service Description:";
            // 
            // serviceName
            // 
            this.serviceName.Location = new System.Drawing.Point(264, 44);
            this.serviceName.Name = "serviceName";
            this.serviceName.Size = new System.Drawing.Size(166, 23);
            this.serviceName.TabIndex = 9;
            // 
            // serviceCharges
            // 
            this.serviceCharges.Location = new System.Drawing.Point(264, 110);
            this.serviceCharges.Name = "serviceCharges";
            this.serviceCharges.Size = new System.Drawing.Size(166, 23);
            this.serviceCharges.TabIndex = 10;
            this.serviceCharges.TextChanged += new System.EventHandler(this.serviceCharges_TextChanged);
            // 
            // serviceDescription
            // 
            this.serviceDescription.Location = new System.Drawing.Point(264, 188);
            this.serviceDescription.Name = "serviceDescription";
            this.serviceDescription.Size = new System.Drawing.Size(166, 87);
            this.serviceDescription.TabIndex = 14;
            this.serviceDescription.Text = "";
            // 
            // serviceSubmit
            // 
            this.serviceSubmit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.serviceSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.serviceSubmit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.serviceSubmit.Location = new System.Drawing.Point(294, 307);
            this.serviceSubmit.Name = "serviceSubmit";
            this.serviceSubmit.Size = new System.Drawing.Size(96, 34);
            this.serviceSubmit.TabIndex = 18;
            this.serviceSubmit.Text = "Submit";
            this.serviceSubmit.UseVisualStyleBackColor = false;
            this.serviceSubmit.Click += new System.EventHandler(this.serviceSubmit_Click);
            // 
            // Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(541, 353);
            this.Controls.Add(this.serviceSubmit);
            this.Controls.Add(this.serviceDescription);
            this.Controls.Add(this.serviceCharges);
            this.Controls.Add(this.serviceName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Service";
            this.Text = "Service";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox serviceName;
        private RichTextBox serviceDescription;
        private Button serviceSubmit;
        public TextBox serviceCharges;
    }
}