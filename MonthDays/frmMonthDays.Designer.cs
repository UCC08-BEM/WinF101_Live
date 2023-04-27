namespace MonthDays
{
    partial class frmMonthDays
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
            this.btonExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudYil = new System.Windows.Forms.NumericUpDown();
            this.cboxAy = new System.Windows.Forms.ComboBox();
            this.btonListele = new System.Windows.Forms.Button();
            this.lboxGunler = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudYil)).BeginInit();
            this.SuspendLayout();
            // 
            // btonExit
            // 
            this.btonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btonExit.Location = new System.Drawing.Point(233, 434);
            this.btonExit.Name = "btonExit";
            this.btonExit.Size = new System.Drawing.Size(100, 52);
            this.btonExit.TabIndex = 0;
            this.btonExit.Text = "Çıkış";
            this.btonExit.UseVisualStyleBackColor = true;
            this.btonExit.Click += new System.EventHandler(this.btonExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yıl";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ay";
            // 
            // nudYil
            // 
            this.nudYil.Location = new System.Drawing.Point(95, 31);
            this.nudYil.Maximum = new decimal(new int[] {
            2200,
            0,
            0,
            0});
            this.nudYil.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudYil.Name = "nudYil";
            this.nudYil.Size = new System.Drawing.Size(120, 26);
            this.nudYil.TabIndex = 3;
            this.nudYil.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // cboxAy
            // 
            this.cboxAy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxAy.FormattingEnabled = true;
            this.cboxAy.Location = new System.Drawing.Point(94, 90);
            this.cboxAy.Name = "cboxAy";
            this.cboxAy.Size = new System.Drawing.Size(121, 27);
            this.cboxAy.TabIndex = 4;
            // 
            // btonListele
            // 
            this.btonListele.Location = new System.Drawing.Point(94, 143);
            this.btonListele.Name = "btonListele";
            this.btonListele.Size = new System.Drawing.Size(81, 39);
            this.btonListele.TabIndex = 5;
            this.btonListele.Text = "Listele";
            this.btonListele.UseVisualStyleBackColor = true;
            this.btonListele.Click += new System.EventHandler(this.btonListele_Click);
            // 
            // lboxGunler
            // 
            this.lboxGunler.FormattingEnabled = true;
            this.lboxGunler.ItemHeight = 19;
            this.lboxGunler.Location = new System.Drawing.Point(95, 203);
            this.lboxGunler.Name = "lboxGunler";
            this.lboxGunler.Size = new System.Drawing.Size(199, 213);
            this.lboxGunler.TabIndex = 6;
            // 
            // frmMonthDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 498);
            this.Controls.Add(this.lboxGunler);
            this.Controls.Add(this.btonListele);
            this.Controls.Add(this.cboxAy);
            this.Controls.Add(this.nudYil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btonExit);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMonthDays";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Month Days";
            this.Load += new System.EventHandler(this.frmMonthDays_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudYil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btonExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudYil;
        private System.Windows.Forms.ComboBox cboxAy;
        private System.Windows.Forms.Button btonListele;
        private System.Windows.Forms.ListBox lboxGunler;
    }
}

