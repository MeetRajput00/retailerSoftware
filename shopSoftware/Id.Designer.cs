namespace shopSoftware
{
    partial class Id
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
            this.idSubmit = new System.Windows.Forms.Button();
            this.idDescription = new System.Windows.Forms.RichTextBox();
            this.idName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // idSubmit
            // 
            this.idSubmit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.idSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.idSubmit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.idSubmit.Location = new System.Drawing.Point(256, 240);
            this.idSubmit.Name = "idSubmit";
            this.idSubmit.Size = new System.Drawing.Size(96, 34);
            this.idSubmit.TabIndex = 23;
            this.idSubmit.Text = "Submit";
            this.idSubmit.UseVisualStyleBackColor = false;
            this.idSubmit.Click += new System.EventHandler(this.idSubmit_Click);
            // 
            // idDescription
            // 
            this.idDescription.Location = new System.Drawing.Point(226, 121);
            this.idDescription.Name = "idDescription";
            this.idDescription.Size = new System.Drawing.Size(166, 87);
            this.idDescription.TabIndex = 22;
            this.idDescription.Text = "";
            // 
            // idName
            // 
            this.idName.Location = new System.Drawing.Point(226, 43);
            this.idName.Name = "idName";
            this.idName.Size = new System.Drawing.Size(166, 23);
            this.idName.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(30, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 20;
            this.label3.Text = "Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(30, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "Name:";
            // 
            // Id
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(456, 310);
            this.Controls.Add(this.idSubmit);
            this.Controls.Add(this.idDescription);
            this.Controls.Add(this.idName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Id";
            this.Text = "Id";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button idSubmit;
        private RichTextBox idDescription;
        private TextBox idName;
        private Label label3;
        private Label label2;
    }
}