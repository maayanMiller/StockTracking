namespace StockTrakingV2
{
    partial class FrmMain
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.btnCatgory = new System.Windows.Forms.Button();
            this.btnDeleted = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(222, 391);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(161, 149);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddStock
            // 
            this.btnAddStock.Location = new System.Drawing.Point(27, 211);
            this.btnAddStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(161, 149);
            this.btnAddStock.TabIndex = 2;
            this.btnAddStock.Text = "Add Stock";
            this.btnAddStock.UseVisualStyleBackColor = true;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // btnCatgory
            // 
            this.btnCatgory.Location = new System.Drawing.Point(222, 211);
            this.btnCatgory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCatgory.Name = "btnCatgory";
            this.btnCatgory.Size = new System.Drawing.Size(161, 149);
            this.btnCatgory.TabIndex = 3;
            this.btnCatgory.Text = "Catgory";
            this.btnCatgory.UseVisualStyleBackColor = true;
            this.btnCatgory.Click += new System.EventHandler(this.btnCatgory_Click);
            // 
            // btnDeleted
            // 
            this.btnDeleted.Location = new System.Drawing.Point(414, 211);
            this.btnDeleted.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleted.Name = "btnDeleted";
            this.btnDeleted.Size = new System.Drawing.Size(161, 149);
            this.btnDeleted.TabIndex = 4;
            this.btnDeleted.Text = "Deleted";
            this.btnDeleted.UseVisualStyleBackColor = true;
            this.btnDeleted.Click += new System.EventHandler(this.btnDeleted_Click);
            // 
            // btnSales
            // 
            this.btnSales.Location = new System.Drawing.Point(414, 30);
            this.btnSales.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(161, 149);
            this.btnSales.TabIndex = 5;
            this.btnSales.Text = "Sales";
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click_1);
            // 
            // btnProduct
            // 
            this.btnProduct.Location = new System.Drawing.Point(222, 30);
            this.btnProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(161, 149);
            this.btnProduct.TabIndex = 6;
            this.btnProduct.Text = "Product";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(34, 30);
            this.btnCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(161, 149);
            this.btnCustomer.TabIndex = 7;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 547);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddStock);
            this.Controls.Add(this.btnCatgory);
            this.Controls.Add(this.btnDeleted);
            this.Controls.Add(this.btnSales);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.btnCustomer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddStock;
        private System.Windows.Forms.Button btnCatgory;
        private System.Windows.Forms.Button btnDeleted;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnCustomer;
    }
}