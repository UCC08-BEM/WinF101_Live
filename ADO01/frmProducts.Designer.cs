namespace ADO01
{
    partial class frmProducts
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
            this.btonClose = new System.Windows.Forms.Button();
            this.tabcProducts = new System.Windows.Forms.TabControl();
            this.tabpData = new System.Windows.Forms.TabPage();
            this.dgrdProducts = new System.Windows.Forms.DataGridView();
            this.grpbQuery = new System.Windows.Forms.GroupBox();
            this.btonQuery = new System.Windows.Forms.Button();
            this.cboxQSupplier = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboxQCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxQProductName = new System.Windows.Forms.TextBox();
            this.tabpDetail = new System.Windows.Forms.TabPage();
            this.btonAdd = new System.Windows.Forms.Button();
            this.btonUpdate = new System.Windows.Forms.Button();
            this.btonDelete = new System.Windows.Forms.Button();
            this.tboxProductName = new System.Windows.Forms.TextBox();
            this.cboxCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboxSupplier = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nudStockQty = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.chkbDiscontinued = new System.Windows.Forms.CheckBox();
            this.btonSave = new System.Windows.Forms.Button();
            this.tabcProducts.SuspendLayout();
            this.tabpData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdProducts)).BeginInit();
            this.grpbQuery.SuspendLayout();
            this.tabpDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockQty)).BeginInit();
            this.SuspendLayout();
            // 
            // btonClose
            // 
            this.btonClose.Location = new System.Drawing.Point(822, 650);
            this.btonClose.Margin = new System.Windows.Forms.Padding(4);
            this.btonClose.Name = "btonClose";
            this.btonClose.Size = new System.Drawing.Size(93, 45);
            this.btonClose.TabIndex = 0;
            this.btonClose.Text = "Kapat";
            this.btonClose.UseVisualStyleBackColor = true;
            this.btonClose.Click += new System.EventHandler(this.btonClose_Click);
            // 
            // tabcProducts
            // 
            this.tabcProducts.Controls.Add(this.tabpData);
            this.tabcProducts.Controls.Add(this.tabpDetail);
            this.tabcProducts.Location = new System.Drawing.Point(12, 12);
            this.tabcProducts.Name = "tabcProducts";
            this.tabcProducts.SelectedIndex = 0;
            this.tabcProducts.Size = new System.Drawing.Size(903, 631);
            this.tabcProducts.TabIndex = 1;
            // 
            // tabpData
            // 
            this.tabpData.Controls.Add(this.btonDelete);
            this.tabpData.Controls.Add(this.btonUpdate);
            this.tabpData.Controls.Add(this.btonAdd);
            this.tabpData.Controls.Add(this.dgrdProducts);
            this.tabpData.Controls.Add(this.grpbQuery);
            this.tabpData.Location = new System.Drawing.Point(4, 28);
            this.tabpData.Name = "tabpData";
            this.tabpData.Padding = new System.Windows.Forms.Padding(3);
            this.tabpData.Size = new System.Drawing.Size(895, 599);
            this.tabpData.TabIndex = 0;
            this.tabpData.Text = "General";
            this.tabpData.UseVisualStyleBackColor = true;
            // 
            // dgrdProducts
            // 
            this.dgrdProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdProducts.Location = new System.Drawing.Point(6, 269);
            this.dgrdProducts.Name = "dgrdProducts";
            this.dgrdProducts.Size = new System.Drawing.Size(883, 265);
            this.dgrdProducts.TabIndex = 1;
            this.dgrdProducts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrdProducts_CellDoubleClick);
            // 
            // grpbQuery
            // 
            this.grpbQuery.Controls.Add(this.btonQuery);
            this.grpbQuery.Controls.Add(this.cboxQSupplier);
            this.grpbQuery.Controls.Add(this.label3);
            this.grpbQuery.Controls.Add(this.cboxQCategory);
            this.grpbQuery.Controls.Add(this.label2);
            this.grpbQuery.Controls.Add(this.label1);
            this.grpbQuery.Controls.Add(this.tboxQProductName);
            this.grpbQuery.Location = new System.Drawing.Point(9, 18);
            this.grpbQuery.Name = "grpbQuery";
            this.grpbQuery.Size = new System.Drawing.Size(734, 236);
            this.grpbQuery.TabIndex = 0;
            this.grpbQuery.TabStop = false;
            this.grpbQuery.Text = "Sorgu Seçenekleri";
            // 
            // btonQuery
            // 
            this.btonQuery.Location = new System.Drawing.Point(6, 197);
            this.btonQuery.Name = "btonQuery";
            this.btonQuery.Size = new System.Drawing.Size(92, 33);
            this.btonQuery.TabIndex = 2;
            this.btonQuery.Text = "Sorgula";
            this.btonQuery.UseVisualStyleBackColor = true;
            this.btonQuery.Click += new System.EventHandler(this.btonQuery_Click);
            // 
            // cboxQSupplier
            // 
            this.cboxQSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxQSupplier.FormattingEnabled = true;
            this.cboxQSupplier.Location = new System.Drawing.Point(175, 138);
            this.cboxQSupplier.Name = "cboxQSupplier";
            this.cboxQSupplier.Size = new System.Drawing.Size(227, 27);
            this.cboxQSupplier.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tedarikçi";
            // 
            // cboxQCategory
            // 
            this.cboxQCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxQCategory.FormattingEnabled = true;
            this.cboxQCategory.Location = new System.Drawing.Point(175, 82);
            this.cboxQCategory.Name = "cboxQCategory";
            this.cboxQCategory.Size = new System.Drawing.Size(121, 27);
            this.cboxQCategory.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kategori";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Adı";
            // 
            // tboxQProductName
            // 
            this.tboxQProductName.Location = new System.Drawing.Point(175, 32);
            this.tboxQProductName.Name = "tboxQProductName";
            this.tboxQProductName.Size = new System.Drawing.Size(239, 26);
            this.tboxQProductName.TabIndex = 0;
            // 
            // tabpDetail
            // 
            this.tabpDetail.Controls.Add(this.btonSave);
            this.tabpDetail.Controls.Add(this.chkbDiscontinued);
            this.tabpDetail.Controls.Add(this.label9);
            this.tabpDetail.Controls.Add(this.nudStockQty);
            this.tabpDetail.Controls.Add(this.label8);
            this.tabpDetail.Controls.Add(this.cboxSupplier);
            this.tabpDetail.Controls.Add(this.label6);
            this.tabpDetail.Controls.Add(this.label5);
            this.tabpDetail.Controls.Add(this.label4);
            this.tabpDetail.Controls.Add(this.cboxCategory);
            this.tabpDetail.Controls.Add(this.tboxProductName);
            this.tabpDetail.Location = new System.Drawing.Point(4, 28);
            this.tabpDetail.Name = "tabpDetail";
            this.tabpDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabpDetail.Size = new System.Drawing.Size(895, 599);
            this.tabpDetail.TabIndex = 1;
            this.tabpDetail.Text = "Detail";
            this.tabpDetail.UseVisualStyleBackColor = true;
            // 
            // btonAdd
            // 
            this.btonAdd.Location = new System.Drawing.Point(9, 551);
            this.btonAdd.Name = "btonAdd";
            this.btonAdd.Size = new System.Drawing.Size(81, 24);
            this.btonAdd.TabIndex = 2;
            this.btonAdd.Text = "Ekle";
            this.btonAdd.UseVisualStyleBackColor = true;
            this.btonAdd.Click += new System.EventHandler(this.btonAdd_Click);
            // 
            // btonUpdate
            // 
            this.btonUpdate.Location = new System.Drawing.Point(107, 551);
            this.btonUpdate.Name = "btonUpdate";
            this.btonUpdate.Size = new System.Drawing.Size(81, 24);
            this.btonUpdate.TabIndex = 3;
            this.btonUpdate.Text = "Update";
            this.btonUpdate.UseVisualStyleBackColor = true;
            this.btonUpdate.Click += new System.EventHandler(this.btonUpdate_Click);
            // 
            // btonDelete
            // 
            this.btonDelete.Location = new System.Drawing.Point(213, 551);
            this.btonDelete.Name = "btonDelete";
            this.btonDelete.Size = new System.Drawing.Size(81, 24);
            this.btonDelete.TabIndex = 4;
            this.btonDelete.Text = "Sil";
            this.btonDelete.UseVisualStyleBackColor = true;
            // 
            // tboxProductName
            // 
            this.tboxProductName.Location = new System.Drawing.Point(175, 43);
            this.tboxProductName.Name = "tboxProductName";
            this.tboxProductName.Size = new System.Drawing.Size(197, 26);
            this.tboxProductName.TabIndex = 0;
            // 
            // cboxCategory
            // 
            this.cboxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCategory.FormattingEnabled = true;
            this.cboxCategory.Location = new System.Drawing.Point(175, 91);
            this.cboxCategory.Name = "cboxCategory";
            this.cboxCategory.Size = new System.Drawing.Size(141, 27);
            this.cboxCategory.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Product Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Supplier";
            // 
            // cboxSupplier
            // 
            this.cboxSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSupplier.FormattingEnabled = true;
            this.cboxSupplier.Location = new System.Drawing.Point(175, 151);
            this.cboxSupplier.Name = "cboxSupplier";
            this.cboxSupplier.Size = new System.Drawing.Size(260, 27);
            this.cboxSupplier.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 19);
            this.label8.TabIndex = 8;
            this.label8.Text = "Units In Stock";
            // 
            // nudStockQty
            // 
            this.nudStockQty.Location = new System.Drawing.Point(175, 200);
            this.nudStockQty.Name = "nudStockQty";
            this.nudStockQty.Size = new System.Drawing.Size(120, 26);
            this.nudStockQty.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 19);
            this.label9.TabIndex = 10;
            this.label9.Text = "Discontinued";
            // 
            // chkbDiscontinued
            // 
            this.chkbDiscontinued.AutoSize = true;
            this.chkbDiscontinued.Location = new System.Drawing.Point(175, 266);
            this.chkbDiscontinued.Name = "chkbDiscontinued";
            this.chkbDiscontinued.Size = new System.Drawing.Size(15, 14);
            this.chkbDiscontinued.TabIndex = 11;
            this.chkbDiscontinued.UseVisualStyleBackColor = true;
            // 
            // btonSave
            // 
            this.btonSave.Location = new System.Drawing.Point(175, 327);
            this.btonSave.Name = "btonSave";
            this.btonSave.Size = new System.Drawing.Size(90, 41);
            this.btonSave.TabIndex = 12;
            this.btonSave.Text = "Kaydet";
            this.btonSave.UseVisualStyleBackColor = true;
            this.btonSave.Click += new System.EventHandler(this.btonSave_Click);
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 708);
            this.Controls.Add(this.tabcProducts);
            this.Controls.Add(this.btonClose);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProducts";
            this.Load += new System.EventHandler(this.frmProducts_Load);
            this.tabcProducts.ResumeLayout(false);
            this.tabpData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrdProducts)).EndInit();
            this.grpbQuery.ResumeLayout(false);
            this.grpbQuery.PerformLayout();
            this.tabpDetail.ResumeLayout(false);
            this.tabpDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockQty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btonClose;
        private System.Windows.Forms.TabControl tabcProducts;
        private System.Windows.Forms.TabPage tabpData;
        private System.Windows.Forms.DataGridView dgrdProducts;
        private System.Windows.Forms.GroupBox grpbQuery;
        private System.Windows.Forms.Button btonQuery;
        private System.Windows.Forms.ComboBox cboxQSupplier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboxQCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxQProductName;
        private System.Windows.Forms.TabPage tabpDetail;
        private System.Windows.Forms.Button btonDelete;
        private System.Windows.Forms.Button btonUpdate;
        private System.Windows.Forms.Button btonAdd;
        private System.Windows.Forms.ComboBox cboxSupplier;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboxCategory;
        private System.Windows.Forms.TextBox tboxProductName;
        private System.Windows.Forms.Button btonSave;
        private System.Windows.Forms.CheckBox chkbDiscontinued;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudStockQty;
        private System.Windows.Forms.Label label8;
    }
}