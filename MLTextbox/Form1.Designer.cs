namespace MLTextbox
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
            this.tboxSonuc = new System.Windows.Forms.TextBox();
            this.btonIslem = new System.Windows.Forms.Button();
            this.lbelMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tboxSonuc
            // 
            this.tboxSonuc.Location = new System.Drawing.Point(131, 107);
            this.tboxSonuc.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tboxSonuc.Multiline = true;
            this.tboxSonuc.Name = "tboxSonuc";
            this.tboxSonuc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tboxSonuc.Size = new System.Drawing.Size(293, 229);
            this.tboxSonuc.TabIndex = 0;
            // 
            // btonIslem
            // 
            this.btonIslem.Location = new System.Drawing.Point(131, 29);
            this.btonIslem.Name = "btonIslem";
            this.btonIslem.Size = new System.Drawing.Size(91, 38);
            this.btonIslem.TabIndex = 1;
            this.btonIslem.Text = "Üret";
            this.btonIslem.UseVisualStyleBackColor = true;
            this.btonIslem.Click += new System.EventHandler(this.btonIslem_Click);
            // 
            // lbelMessage
            // 
            this.lbelMessage.AutoSize = true;
            this.lbelMessage.Location = new System.Drawing.Point(12, 367);
            this.lbelMessage.Name = "lbelMessage";
            this.lbelMessage.Size = new System.Drawing.Size(70, 26);
            this.lbelMessage.TabIndex = 2;
            this.lbelMessage.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 428);
            this.Controls.Add(this.lbelMessage);
            this.Controls.Add(this.btonIslem);
            this.Controls.Add(this.tboxSonuc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxSonuc;
        private System.Windows.Forms.Button btonIslem;
        private System.Windows.Forms.Label lbelMessage;
    }
}

