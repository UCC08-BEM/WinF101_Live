namespace Menu2ndForm
{
    partial class frmAna
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
            this.menuAna = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.form2AçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.form3AçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1ProjesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listbox01ProjesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAna.SuspendLayout();
            this.SuspendLayout();
            // 
            // btonExit
            // 
            this.btonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btonExit.Location = new System.Drawing.Point(508, 484);
            this.btonExit.Margin = new System.Windows.Forms.Padding(6);
            this.btonExit.Name = "btonExit";
            this.btonExit.Size = new System.Drawing.Size(79, 44);
            this.btonExit.TabIndex = 0;
            this.btonExit.Text = "Çıkış";
            this.btonExit.UseVisualStyleBackColor = true;
            this.btonExit.Click += new System.EventHandler(this.btonExit_Click);
            // 
            // menuAna
            // 
            this.menuAna.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem});
            this.menuAna.Location = new System.Drawing.Point(0, 0);
            this.menuAna.Name = "menuAna";
            this.menuAna.Size = new System.Drawing.Size(602, 24);
            this.menuAna.TabIndex = 1;
            this.menuAna.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.form2AçToolStripMenuItem,
            this.form3AçToolStripMenuItem,
            this.mnuiExit,
            this.comboBox1ProjesiToolStripMenuItem,
            this.listbox01ProjesiToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // form2AçToolStripMenuItem
            // 
            this.form2AçToolStripMenuItem.Name = "form2AçToolStripMenuItem";
            this.form2AçToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.form2AçToolStripMenuItem.Text = "Form2 Aç";
            this.form2AçToolStripMenuItem.Click += new System.EventHandler(this.form2AçToolStripMenuItem_Click);
            // 
            // form3AçToolStripMenuItem
            // 
            this.form3AçToolStripMenuItem.Name = "form3AçToolStripMenuItem";
            this.form3AçToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.form3AçToolStripMenuItem.Text = "Form3 Aç";
            this.form3AçToolStripMenuItem.Click += new System.EventHandler(this.form3AçToolStripMenuItem_Click);
            // 
            // mnuiExit
            // 
            this.mnuiExit.Name = "mnuiExit";
            this.mnuiExit.Size = new System.Drawing.Size(178, 22);
            this.mnuiExit.Text = "Çıkış";
            this.mnuiExit.Click += new System.EventHandler(this.mnuiExit_Click);
            // 
            // comboBox1ProjesiToolStripMenuItem
            // 
            this.comboBox1ProjesiToolStripMenuItem.Name = "comboBox1ProjesiToolStripMenuItem";
            this.comboBox1ProjesiToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.comboBox1ProjesiToolStripMenuItem.Text = "ComboBox1 Projesi";
            this.comboBox1ProjesiToolStripMenuItem.Click += new System.EventHandler(this.comboBox1ProjesiToolStripMenuItem_Click);
            // 
            // listbox01ProjesiToolStripMenuItem
            // 
            this.listbox01ProjesiToolStripMenuItem.Name = "listbox01ProjesiToolStripMenuItem";
            this.listbox01ProjesiToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.listbox01ProjesiToolStripMenuItem.Text = "Listbox01 Projesi";
            this.listbox01ProjesiToolStripMenuItem.Click += new System.EventHandler(this.listbox01ProjesiToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // frmAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 543);
            this.Controls.Add(this.btonExit);
            this.Controls.Add(this.menuAna);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.menuAna;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmAna";
            this.Text = "Ana Form";
            this.Load += new System.EventHandler(this.frmAna_Load);
            this.menuAna.ResumeLayout(false);
            this.menuAna.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btonExit;
        private System.Windows.Forms.MenuStrip menuAna;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuiExit;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem form2AçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem form3AçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comboBox1ProjesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listbox01ProjesiToolStripMenuItem;
    }
}

