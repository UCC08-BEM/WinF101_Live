namespace ADO01
{
    partial class ADO01_Detail
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
            this.tboxCustomerID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxCompanyName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxContactName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxCountry = new System.Windows.Forms.TextBox();
            this.btonSave = new System.Windows.Forms.Button();
            this.btonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer ID";
            // 
            // tboxCustomerID
            // 
            this.tboxCustomerID.Location = new System.Drawing.Point(164, 57);
            this.tboxCustomerID.MaxLength = 5;
            this.tboxCustomerID.Name = "tboxCustomerID";
            this.tboxCustomerID.Size = new System.Drawing.Size(105, 26);
            this.tboxCustomerID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Company Name";
            // 
            // tboxCompanyName
            // 
            this.tboxCompanyName.Location = new System.Drawing.Point(164, 115);
            this.tboxCompanyName.Name = "tboxCompanyName";
            this.tboxCompanyName.Size = new System.Drawing.Size(264, 26);
            this.tboxCompanyName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contact Name";
            // 
            // tboxContactName
            // 
            this.tboxContactName.Location = new System.Drawing.Point(164, 182);
            this.tboxContactName.Name = "tboxContactName";
            this.tboxContactName.Size = new System.Drawing.Size(264, 26);
            this.tboxContactName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Country";
            // 
            // tboxCountry
            // 
            this.tboxCountry.Location = new System.Drawing.Point(164, 253);
            this.tboxCountry.Name = "tboxCountry";
            this.tboxCountry.Size = new System.Drawing.Size(126, 26);
            this.tboxCountry.TabIndex = 7;
            // 
            // btonSave
            // 
            this.btonSave.Location = new System.Drawing.Point(164, 316);
            this.btonSave.Name = "btonSave";
            this.btonSave.Size = new System.Drawing.Size(91, 39);
            this.btonSave.TabIndex = 8;
            this.btonSave.Text = "Kaydet";
            this.btonSave.UseVisualStyleBackColor = true;
            this.btonSave.Click += new System.EventHandler(this.btonSave_Click);
            // 
            // btonClose
            // 
            this.btonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btonClose.Location = new System.Drawing.Point(362, 376);
            this.btonClose.Name = "btonClose";
            this.btonClose.Size = new System.Drawing.Size(82, 33);
            this.btonClose.TabIndex = 9;
            this.btonClose.Text = "Kapat";
            this.btonClose.UseVisualStyleBackColor = true;
            this.btonClose.Click += new System.EventHandler(this.btonClose_Click);
            // 
            // ADO01_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(456, 421);
            this.Controls.Add(this.btonClose);
            this.Controls.Add(this.btonSave);
            this.Controls.Add(this.tboxCountry);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tboxContactName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tboxCompanyName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tboxCustomerID);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ADO01_Detail";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADO01_Detail";
            this.Load += new System.EventHandler(this.ADO01_Detail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btonSave;
        private System.Windows.Forms.Button btonClose;
        public System.Windows.Forms.TextBox tboxCustomerID;
        public System.Windows.Forms.TextBox tboxCompanyName;
        public System.Windows.Forms.TextBox tboxContactName;
        public System.Windows.Forms.TextBox tboxCountry;
    }
}