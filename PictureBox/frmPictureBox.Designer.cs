namespace PictureBox
{
    partial class frmPictureBox
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
            this.pboxPicture = new System.Windows.Forms.PictureBox();
            this.lbelFileName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // pboxPicture
            // 
            this.pboxPicture.Location = new System.Drawing.Point(109, 24);
            this.pboxPicture.Name = "pboxPicture";
            this.pboxPicture.Size = new System.Drawing.Size(209, 168);
            this.pboxPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pboxPicture.TabIndex = 0;
            this.pboxPicture.TabStop = false;
            // 
            // lbelFileName
            // 
            this.lbelFileName.AutoSize = true;
            this.lbelFileName.Location = new System.Drawing.Point(12, 428);
            this.lbelFileName.Name = "lbelFileName";
            this.lbelFileName.Size = new System.Drawing.Size(35, 13);
            this.lbelFileName.TabIndex = 1;
            this.lbelFileName.Text = "label1";
            // 
            // frmPictureBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 450);
            this.Controls.Add(this.lbelFileName);
            this.Controls.Add(this.pboxPicture);
            this.Name = "frmPictureBox";
            this.Text = "Picture Box";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pboxPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxPicture;
        private System.Windows.Forms.Label lbelFileName;
    }
}

