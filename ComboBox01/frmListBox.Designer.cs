namespace ComboBox01
{
    partial class frmListBox
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
            this.cboxSayiLİst = new System.Windows.Forms.ComboBox();
            this.btonSayilar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tboxAdet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(29, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sayılar";
            // 
            // cboxSayiLİst
            // 
            this.cboxSayiLİst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSayiLİst.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboxSayiLİst.FormattingEnabled = true;
            this.cboxSayiLİst.Location = new System.Drawing.Point(132, 183);
            this.cboxSayiLİst.Name = "cboxSayiLİst";
            this.cboxSayiLİst.Size = new System.Drawing.Size(176, 39);
            this.cboxSayiLİst.TabIndex = 1;
            // 
            // btonSayilar
            // 
            this.btonSayilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btonSayilar.Location = new System.Drawing.Point(132, 100);
            this.btonSayilar.Name = "btonSayilar";
            this.btonSayilar.Size = new System.Drawing.Size(220, 58);
            this.btonSayilar.TabIndex = 2;
            this.btonSayilar.Text = "Listeyi oluştur";
            this.btonSayilar.UseVisualStyleBackColor = true;
            this.btonSayilar.Click += new System.EventHandler(this.btonSayilar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(351, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Çıkış";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tboxAdet
            // 
            this.tboxAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tboxAdet.Location = new System.Drawing.Point(132, 47);
            this.tboxAdet.Name = "tboxAdet";
            this.tboxAdet.Size = new System.Drawing.Size(100, 38);
            this.tboxAdet.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(29, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Adet";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 367);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tboxAdet);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btonSayilar);
            this.Controls.Add(this.cboxSayiLİst);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxSayiLİst;
        private System.Windows.Forms.Button btonSayilar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tboxAdet;
        private System.Windows.Forms.Label label2;
    }
}

