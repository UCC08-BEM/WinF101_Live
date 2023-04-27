namespace LİstBox01
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
            this.label2 = new System.Windows.Forms.Label();
            this.tboxAdet = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btonSayilar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lboxSayilar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(36, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 31);
            this.label2.TabIndex = 11;
            this.label2.Text = "Adet";
            // 
            // tboxAdet
            // 
            this.tboxAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tboxAdet.Location = new System.Drawing.Point(139, 71);
            this.tboxAdet.Name = "tboxAdet";
            this.tboxAdet.Size = new System.Drawing.Size(100, 38);
            this.tboxAdet.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(358, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Çıkış";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btonSayilar
            // 
            this.btonSayilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btonSayilar.Location = new System.Drawing.Point(139, 124);
            this.btonSayilar.Name = "btonSayilar";
            this.btonSayilar.Size = new System.Drawing.Size(220, 58);
            this.btonSayilar.TabIndex = 8;
            this.btonSayilar.Text = "Listeyi oluştur";
            this.btonSayilar.UseVisualStyleBackColor = true;
            this.btonSayilar.Click += new System.EventHandler(this.btonSayilar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(36, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sayılar";
            // 
            // lboxSayilar
            // 
            this.lboxSayilar.FormattingEnabled = true;
            this.lboxSayilar.Location = new System.Drawing.Point(139, 207);
            this.lboxSayilar.Name = "lboxSayilar";
            this.lboxSayilar.Size = new System.Drawing.Size(202, 173);
            this.lboxSayilar.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 450);
            this.Controls.Add(this.lboxSayilar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tboxAdet);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btonSayilar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxAdet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btonSayilar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lboxSayilar;
    }
}

