namespace Listbox02
{
    partial class frmListbox02
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
            this.tboxAdet = new System.Windows.Forms.TextBox();
            this.tboxIlk = new System.Windows.Forms.TextBox();
            this.tboxSon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btonUret = new System.Windows.Forms.Button();
            this.lboxSonuc = new System.Windows.Forms.ListBox();
            this.btonExit = new System.Windows.Forms.Button();
            this.lbelMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tboxAdet
            // 
            this.tboxAdet.Location = new System.Drawing.Point(234, 6);
            this.tboxAdet.Name = "tboxAdet";
            this.tboxAdet.Size = new System.Drawing.Size(53, 38);
            this.tboxAdet.TabIndex = 0;
            // 
            // tboxIlk
            // 
            this.tboxIlk.Location = new System.Drawing.Point(234, 56);
            this.tboxIlk.Name = "tboxIlk";
            this.tboxIlk.Size = new System.Drawing.Size(100, 38);
            this.tboxIlk.TabIndex = 1;
            // 
            // tboxSon
            // 
            this.tboxSon.Location = new System.Drawing.Point(234, 109);
            this.tboxSon.Name = "tboxSon";
            this.tboxSon.Size = new System.Drawing.Size(100, 38);
            this.tboxSon.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Üretilecek adet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Alt sınır";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Üst sınır";
            // 
            // btonUret
            // 
            this.btonUret.Location = new System.Drawing.Point(359, 12);
            this.btonUret.Name = "btonUret";
            this.btonUret.Size = new System.Drawing.Size(137, 56);
            this.btonUret.TabIndex = 6;
            this.btonUret.Text = "Üret";
            this.btonUret.UseVisualStyleBackColor = true;
            this.btonUret.Click += new System.EventHandler(this.btonUret_Click);
            // 
            // lboxSonuc
            // 
            this.lboxSonuc.FormattingEnabled = true;
            this.lboxSonuc.ItemHeight = 31;
            this.lboxSonuc.Location = new System.Drawing.Point(514, 12);
            this.lboxSonuc.Name = "lboxSonuc";
            this.lboxSonuc.Size = new System.Drawing.Size(137, 252);
            this.lboxSonuc.TabIndex = 7;
            // 
            // btonExit
            // 
            this.btonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btonExit.Location = new System.Drawing.Point(718, 222);
            this.btonExit.Name = "btonExit";
            this.btonExit.Size = new System.Drawing.Size(106, 52);
            this.btonExit.TabIndex = 8;
            this.btonExit.Text = "Çıkış";
            this.btonExit.UseVisualStyleBackColor = true;
            this.btonExit.Click += new System.EventHandler(this.btıonExit_Click);
            // 
            // lbelMessage
            // 
            this.lbelMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbelMessage.AutoSize = true;
            this.lbelMessage.Location = new System.Drawing.Point(12, 233);
            this.lbelMessage.Name = "lbelMessage";
            this.lbelMessage.Size = new System.Drawing.Size(86, 31);
            this.lbelMessage.TabIndex = 9;
            this.lbelMessage.Text = "label4";
            this.lbelMessage.Visible = false;
            // 
            // frmListbox02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 297);
            this.Controls.Add(this.lbelMessage);
            this.Controls.Add(this.btonExit);
            this.Controls.Add(this.lboxSonuc);
            this.Controls.Add(this.btonUret);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboxSon);
            this.Controls.Add(this.tboxIlk);
            this.Controls.Add(this.tboxAdet);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "frmListbox02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmListbox02_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxAdet;
        private System.Windows.Forms.TextBox tboxIlk;
        private System.Windows.Forms.TextBox tboxSon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btonUret;
        private System.Windows.Forms.ListBox lboxSonuc;
        private System.Windows.Forms.Button btonExit;
        private System.Windows.Forms.Label lbelMessage;
    }
}

