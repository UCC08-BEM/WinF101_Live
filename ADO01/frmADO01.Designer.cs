namespace ADO01
{
    partial class frmADO01
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
            this.dgrdCustomers = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btonAdd = new System.Windows.Forms.Button();
            this.btonDelete = new System.Windows.Forms.Button();
            this.btonUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // btonExit
            // 
            this.btonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btonExit.Location = new System.Drawing.Point(779, 599);
            this.btonExit.Name = "btonExit";
            this.btonExit.Size = new System.Drawing.Size(90, 47);
            this.btonExit.TabIndex = 0;
            this.btonExit.Text = "Çıkış";
            this.btonExit.UseVisualStyleBackColor = true;
            this.btonExit.Click += new System.EventHandler(this.btonExit_Click);
            // 
            // dgrdCustomers
            // 
            this.dgrdCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdCustomers.Location = new System.Drawing.Point(27, 75);
            this.dgrdCustomers.Name = "dgrdCustomers";
            this.dgrdCustomers.Size = new System.Drawing.Size(842, 451);
            this.dgrdCustomers.TabIndex = 1;
            this.dgrdCustomers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrdCustomers_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customers Data";
            // 
            // btonAdd
            // 
            this.btonAdd.Location = new System.Drawing.Point(27, 547);
            this.btonAdd.Name = "btonAdd";
            this.btonAdd.Size = new System.Drawing.Size(88, 45);
            this.btonAdd.TabIndex = 3;
            this.btonAdd.Text = "Ekle";
            this.btonAdd.UseVisualStyleBackColor = true;
            this.btonAdd.Click += new System.EventHandler(this.btonAdd_Click);
            // 
            // btonDelete
            // 
            this.btonDelete.Location = new System.Drawing.Point(266, 547);
            this.btonDelete.Name = "btonDelete";
            this.btonDelete.Size = new System.Drawing.Size(88, 45);
            this.btonDelete.TabIndex = 4;
            this.btonDelete.Text = "Sil";
            this.btonDelete.UseVisualStyleBackColor = true;
            this.btonDelete.Click += new System.EventHandler(this.btonDelete_Click);
            // 
            // btonUpdate
            // 
            this.btonUpdate.Location = new System.Drawing.Point(131, 547);
            this.btonUpdate.Name = "btonUpdate";
            this.btonUpdate.Size = new System.Drawing.Size(112, 45);
            this.btonUpdate.TabIndex = 5;
            this.btonUpdate.Text = "Güncelle";
            this.btonUpdate.UseVisualStyleBackColor = true;
            this.btonUpdate.Click += new System.EventHandler(this.btonUpdate_Click);
            // 
            // frmADO01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 658);
            this.Controls.Add(this.btonUpdate);
            this.Controls.Add(this.btonDelete);
            this.Controls.Add(this.btonAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgrdCustomers);
            this.Controls.Add(this.btonExit);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmADO01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Northwin Customers Data";
            this.Load += new System.EventHandler(this.frmADO01_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrdCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btonExit;
        private System.Windows.Forms.DataGridView dgrdCustomers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btonAdd;
        private System.Windows.Forms.Button btonDelete;
        private System.Windows.Forms.Button btonUpdate;
    }
}

