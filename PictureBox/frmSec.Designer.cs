namespace PictureBox
{
    partial class frmSec
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
            this.btonSelect = new System.Windows.Forms.Button();
            this.ofdSec = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btonSelect
            // 
            this.btonSelect.Location = new System.Drawing.Point(97, 159);
            this.btonSelect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btonSelect.Name = "btonSelect";
            this.btonSelect.Size = new System.Drawing.Size(112, 34);
            this.btonSelect.TabIndex = 0;
            this.btonSelect.Text = "Seç";
            this.btonSelect.UseVisualStyleBackColor = true;
            this.btonSelect.Click += new System.EventHandler(this.btonSelect_Click);
            // 
            // ofdSec
            // 
            this.ofdSec.FileName = "openFileDialog1";
            // 
            // frmSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 238);
            this.Controls.Add(this.btonSelect);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmSec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSec";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btonSelect;
        private System.Windows.Forms.OpenFileDialog ofdSec;
    }
}