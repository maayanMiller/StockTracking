namespace StockTrakingV2
{
    partial class FrmDeleted
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
            this.cmbDeletedData = new System.Windows.Forms.ComboBox();
            this.labl1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGetback = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnClose.Location = new System.Drawing.Point(283, 17);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(124, 59);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmbDeletedData
            // 
            this.cmbDeletedData.FormattingEnabled = true;
            this.cmbDeletedData.Location = new System.Drawing.Point(198, 30);
            this.cmbDeletedData.Name = "cmbDeletedData";
            this.cmbDeletedData.Size = new System.Drawing.Size(192, 33);
            this.cmbDeletedData.TabIndex = 14;
            this.cmbDeletedData.SelectedIndexChanged += new System.EventHandler(this.cmbDeletedData_SelectedIndexChanged);
            // 
            // labl1
            // 
            this.labl1.AutoSize = true;
            this.labl1.Location = new System.Drawing.Point(37, 38);
            this.labl1.Name = "labl1";
            this.labl1.Size = new System.Drawing.Size(137, 25);
            this.labl1.TabIndex = 13;
            this.labl1.Text = "Deleted Data";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(576, 304);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnGetback);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 404);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(576, 100);
            this.panel2.TabIndex = 2;
            // 
            // btnGetback
            // 
            this.btnGetback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnGetback.Location = new System.Drawing.Point(93, 17);
            this.btnGetback.Name = "btnGetback";
            this.btnGetback.Size = new System.Drawing.Size(124, 59);
            this.btnGetback.TabIndex = 6;
            this.btnGetback.Text = "Get Back";
            this.btnGetback.UseVisualStyleBackColor = true;
            this.btnGetback.Click += new System.EventHandler(this.btnGetback_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbDeletedData);
            this.panel1.Controls.Add(this.labl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 100);
            this.panel1.TabIndex = 3;
            // 
            // FrmDeleted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 504);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmDeleted";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deleted";
            this.Load += new System.EventHandler(this.FrmDeleted_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cmbDeletedData;
        private System.Windows.Forms.Label labl1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGetback;
        private System.Windows.Forms.Panel panel1;
    }
}