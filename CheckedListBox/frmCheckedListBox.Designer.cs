namespace CheckedListBox
{
    partial class frmCheckedListBox
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
            this.chlbCars = new System.Windows.Forms.CheckedListBox();
            this.lboxSelectedCars = new System.Windows.Forms.ListBox();
            this.btonAktar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btonExit
            // 
            this.btonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btonExit.Location = new System.Drawing.Point(616, 285);
            this.btonExit.Name = "btonExit";
            this.btonExit.Size = new System.Drawing.Size(84, 42);
            this.btonExit.TabIndex = 0;
            this.btonExit.Text = "Çıkış";
            this.btonExit.UseVisualStyleBackColor = true;
            this.btonExit.Click += new System.EventHandler(this.btonExit_Click);
            // 
            // chlbCars
            // 
            this.chlbCars.FormattingEnabled = true;
            this.chlbCars.Items.AddRange(new object[] {
            "Volvo XC70",
            "Volkswagen Beetle (1974)",
            "Ford Bronco",
            "Bugatti Veyron",
            "Mersedes 230.4",
            "Renault Altair"});
            this.chlbCars.Location = new System.Drawing.Point(51, 45);
            this.chlbCars.Name = "chlbCars";
            this.chlbCars.Size = new System.Drawing.Size(253, 151);
            this.chlbCars.TabIndex = 2;
            this.chlbCars.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chlbCars_ItemCheck);
            // 
            // lboxSelectedCars
            // 
            this.lboxSelectedCars.FormattingEnabled = true;
            this.lboxSelectedCars.ItemHeight = 19;
            this.lboxSelectedCars.Location = new System.Drawing.Point(424, 45);
            this.lboxSelectedCars.Name = "lboxSelectedCars";
            this.lboxSelectedCars.Size = new System.Drawing.Size(201, 156);
            this.lboxSelectedCars.TabIndex = 3;
            // 
            // btonAktar
            // 
            this.btonAktar.Location = new System.Drawing.Point(330, 108);
            this.btonAktar.Name = "btonAktar";
            this.btonAktar.Size = new System.Drawing.Size(75, 39);
            this.btonAktar.TabIndex = 4;
            this.btonAktar.Text = "Aktar";
            this.btonAktar.UseVisualStyleBackColor = true;
            this.btonAktar.Click += new System.EventHandler(this.btonAktar_Click);
            // 
            // frmCheckedListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 339);
            this.Controls.Add(this.btonAktar);
            this.Controls.Add(this.lboxSelectedCars);
            this.Controls.Add(this.chlbCars);
            this.Controls.Add(this.btonExit);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCheckedListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checked List Box";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btonExit;
        private System.Windows.Forms.CheckedListBox chlbCars;
        private System.Windows.Forms.ListBox lboxSelectedCars;
        private System.Windows.Forms.Button btonAktar;
    }
}

