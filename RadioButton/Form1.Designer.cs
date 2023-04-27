namespace RadioButton
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
            this.rbtnAzalt = new System.Windows.Forms.RadioButton();
            this.rbtnArtir = new System.Windows.Forms.RadioButton();
            this.lbelSayi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudMiktar = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btonIslem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudMiktar)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtnAzalt
            // 
            this.rbtnAzalt.AutoSize = true;
            this.rbtnAzalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnAzalt.Location = new System.Drawing.Point(79, 72);
            this.rbtnAzalt.Name = "rbtnAzalt";
            this.rbtnAzalt.Size = new System.Drawing.Size(93, 35);
            this.rbtnAzalt.TabIndex = 0;
            this.rbtnAzalt.Text = "Azalt";
            this.rbtnAzalt.UseVisualStyleBackColor = true;
            // 
            // rbtnArtir
            // 
            this.rbtnArtir.AutoSize = true;
            this.rbtnArtir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnArtir.Location = new System.Drawing.Point(79, 110);
            this.rbtnArtir.Name = "rbtnArtir";
            this.rbtnArtir.Size = new System.Drawing.Size(90, 35);
            this.rbtnArtir.TabIndex = 1;
            this.rbtnArtir.Text = "Arttır";
            this.rbtnArtir.UseVisualStyleBackColor = true;
            // 
            // lbelSayi
            // 
            this.lbelSayi.AutoSize = true;
            this.lbelSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbelSayi.Location = new System.Drawing.Point(166, 294);
            this.lbelSayi.Name = "lbelSayi";
            this.lbelSayi.Size = new System.Drawing.Size(29, 31);
            this.lbelSayi.TabIndex = 2;
            this.lbelSayi.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(28, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sonuç =";
            // 
            // nudMiktar
            // 
            this.nudMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudMiktar.Location = new System.Drawing.Point(285, 69);
            this.nudMiktar.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudMiktar.Name = "nudMiktar";
            this.nudMiktar.Size = new System.Drawing.Size(120, 38);
            this.nudMiktar.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(279, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Miktar";
            // 
            // btonIslem
            // 
            this.btonIslem.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btonIslem.Location = new System.Drawing.Point(142, 201);
            this.btonIslem.Name = "btonIslem";
            this.btonIslem.Size = new System.Drawing.Size(190, 46);
            this.btonIslem.TabIndex = 6;
            this.btonIslem.Text = "İşlem Yap";
            this.btonIslem.UseVisualStyleBackColor = true;
            this.btonIslem.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 368);
            this.Controls.Add(this.btonIslem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudMiktar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbelSayi);
            this.Controls.Add(this.rbtnArtir);
            this.Controls.Add(this.rbtnAzalt);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudMiktar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnAzalt;
        private System.Windows.Forms.RadioButton rbtnArtir;
        private System.Windows.Forms.Label lbelSayi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudMiktar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btonIslem;
    }
}

