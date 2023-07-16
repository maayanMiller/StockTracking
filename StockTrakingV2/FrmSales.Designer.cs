namespace StockTrakingV2
{
    partial class FrmSales
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductSalesAmount = new System.Windows.Forms.TextBox();
            this.txtProductStock = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Customer = new System.Windows.Forms.GroupBox();
            this.gridCustomer = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.Product = new System.Windows.Forms.GroupBox();
            this.gridProduct = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.Customer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomer)).BeginInit();
            this.panel3.SuspendLayout();
            this.Product.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProduct)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnClose.Location = new System.Drawing.Point(318, 428);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(114, 59);
            this.btnClose.TabIndex = 33;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSave.Location = new System.Drawing.Point(114, 428);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 59);
            this.btnSave.TabIndex = 34;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 25);
            this.label6.TabIndex = 28;
            this.label6.Text = "Product Sales Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 25);
            this.label4.TabIndex = 29;
            this.label4.Text = "Product Stock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 30;
            this.label3.Text = " Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 25);
            this.label5.TabIndex = 31;
            this.label5.Text = "Customer Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "Product Name";
            // 
            // txtProductSalesAmount
            // 
            this.txtProductSalesAmount.Location = new System.Drawing.Point(260, 313);
            this.txtProductSalesAmount.Name = "txtProductSalesAmount";
            this.txtProductSalesAmount.Size = new System.Drawing.Size(221, 30);
            this.txtProductSalesAmount.TabIndex = 23;
            // 
            // txtProductStock
            // 
            this.txtProductStock.Location = new System.Drawing.Point(260, 247);
            this.txtProductStock.Name = "txtProductStock";
            this.txtProductStock.ReadOnly = true;
            this.txtProductStock.Size = new System.Drawing.Size(221, 30);
            this.txtProductStock.TabIndex = 24;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(260, 181);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(221, 30);
            this.txtPrice.TabIndex = 25;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(260, 49);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(221, 30);
            this.txtCustomerName.TabIndex = 26;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(260, 109);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.ReadOnly = true;
            this.txtProductName.Size = new System.Drawing.Size(221, 30);
            this.txtProductName.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Customer);
            this.panel1.Controls.Add(this.Product);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(526, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(616, 705);
            this.panel1.TabIndex = 22;
            // 
            // Customer
            // 
            this.Customer.Controls.Add(this.gridCustomer);
            this.Customer.Controls.Add(this.panel3);
            this.Customer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Customer.Location = new System.Drawing.Point(0, 363);
            this.Customer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Customer.Name = "Customer";
            this.Customer.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Customer.Size = new System.Drawing.Size(616, 342);
            this.Customer.TabIndex = 1;
            this.Customer.TabStop = false;
            this.Customer.Text = "Customer";
            // 
            // gridCustomer
            // 
            this.gridCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCustomer.Location = new System.Drawing.Point(4, 134);
            this.gridCustomer.Name = "gridCustomer";
            this.gridCustomer.ReadOnly = true;
            this.gridCustomer.RowHeadersWidth = 51;
            this.gridCustomer.RowTemplate.Height = 24;
            this.gridCustomer.Size = new System.Drawing.Size(608, 203);
            this.gridCustomer.TabIndex = 1;
            this.gridCustomer.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCustomer_RowEnter);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtCustomer);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(4, 28);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(608, 106);
            this.panel3.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 25);
            this.label7.TabIndex = 31;
            this.label7.Text = "Customer Name";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(20, 51);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(159, 30);
            this.txtCustomer.TabIndex = 23;
            this.txtCustomer.TextChanged += new System.EventHandler(this.txtCustomer_TextChanged);
            // 
            // Product
            // 
            this.Product.Controls.Add(this.gridProduct);
            this.Product.Controls.Add(this.panel2);
            this.Product.Dock = System.Windows.Forms.DockStyle.Top;
            this.Product.Location = new System.Drawing.Point(0, 0);
            this.Product.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Product.Name = "Product";
            this.Product.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Product.Size = new System.Drawing.Size(616, 363);
            this.Product.TabIndex = 1;
            this.Product.TabStop = false;
            this.Product.Text = "Product";
            // 
            // gridProduct
            // 
            this.gridProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridProduct.Location = new System.Drawing.Point(4, 139);
            this.gridProduct.Name = "gridProduct";
            this.gridProduct.ReadOnly = true;
            this.gridProduct.RowHeadersWidth = 51;
            this.gridProduct.RowTemplate.Height = 24;
            this.gridProduct.Size = new System.Drawing.Size(608, 219);
            this.gridProduct.TabIndex = 1;
            this.gridProduct.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProduct_RowEnter);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbCategory);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(4, 28);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(608, 111);
            this.panel2.TabIndex = 1;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(29, 52);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(178, 33);
            this.cmbCategory.TabIndex = 20;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Category";
            // 
            // FrmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 705);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProductSalesAmount);
            this.Controls.Add(this.txtProductStock);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.FrmSales_Load);
            this.panel1.ResumeLayout(false);
            this.Customer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomer)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.Product.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProduct)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductSalesAmount;
        private System.Windows.Forms.TextBox txtProductStock;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox Customer;
        private System.Windows.Forms.DataGridView gridCustomer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox Product;
        private System.Windows.Forms.DataGridView gridProduct;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCustomer;
    }
}