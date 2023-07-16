using StockTrakingV2.BLL;
using StockTrakingV2.DAL.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockTrakingV2
{
    public partial class FrmSalesList : Form
    {
        SalesDTO dto = new SalesDTO();
        SalesBLL bll = new SalesBLL();
        SalesDetailDTO detail = new SalesDetailDTO();
        public FrmSalesList()
        {
            InitializeComponent();
        }

        private void FrmSalesList_Load(object sender, EventArgs e)
        {

            dto = bll.Select();
            cmbCategory.DataSource = dto.Catgories;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "ID";
            cmbCategory.SelectedIndex = -1;
            dataGridView1.DataSource = dto.Sales;
            dataGridView1.Columns[0].HeaderText = "Customer";
            dataGridView1.Columns[1].HeaderText = "Category";
            dataGridView1.Columns[2].HeaderText = "Product";
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].HeaderText = "Sales Amount";
            dataGridView1.Columns[7].HeaderText = "Price";
            dataGridView1.Columns[8].HeaderText = "Date";
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmSales frm = new FrmSales();
            frm.dto = dto;
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
            dto = bll.Select();
            clearFilters();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void clearFilters()
        {
            txtProductName.Clear();
            txtProductPrice.Clear();
            txtCustomerName.Clear();
            txtSalesAmount.Clear();
            cmbCategory.SelectedIndex = -1;
            rbPriceEqual.Checked = false;
            rbPriceLess.Checked = false;
            rbPriceMore.Checked = false;
            rbSalesEqual.Checked = false;
            rbSalesLess.Checked = false;
            rbSalesMore.Checked = false;
            chDate.Checked = false;
            dpStart.Value = DateTime.Today;
            dpEnd.Value = DateTime.Today;
            dataGridView1.DataSource = dto.Sales;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<SalesDetailDTO> list = dto.Sales;
            if (txtProductName.Text.Trim() != null)
                list = list.Where(x => x.ProductName.Contains(txtProductName.Text)).ToList();
            if (txtCustomerName.Text.Trim() != null)
                list = list.Where(x => x.CustomerName.Contains(txtCustomerName.Text)).ToList();
            if (cmbCategory.SelectedIndex != -1)
                list = list.Where(x => x.CategoryID == Convert.ToInt32(cmbCategory.SelectedValue)).ToList();
            if (txtProductPrice.Text.Trim() != "")
            {
                if (rbPriceEqual.Checked)
                    list = list.Where(x => x.Price == Convert.ToInt32(txtProductPrice.Text)).ToList();
                else if (rbPriceMore.Checked)
                    list = list.Where(x => x.Price > Convert.ToInt32(txtProductPrice.Text)).ToList();
                else if (rbPriceLess.Checked)
                    list = list.Where(x => x.Price < Convert.ToInt32(txtProductPrice.Text)).ToList();
                else
                    MessageBox.Show("Please select a criterion from price group");
            }
            if (txtSalesAmount.Text.Trim() != "")
            {
                if (rbSalesEqual.Checked)
                    list = list.Where(x => x.StockAmount == Convert.ToInt32(txtSalesAmount.Text)).ToList();
                else if (rbSalesMore.Checked)
                    list = list.Where(x => x.StockAmount > Convert.ToInt32(txtSalesAmount.Text)).ToList();
                else if (rbSalesLess.Checked)
                    list = list.Where(x => x.StockAmount < Convert.ToInt32(txtSalesAmount.Text)).ToList();
                else
                    MessageBox.Show("Pleace select a criterion from sales amount group");
            }
            if (chDate.Checked)
                list = list.Where((x) => x.SalesDate >= dpStart.Value && x.SalesDate <= dpEnd.Value).ToList();
            dataGridView1.DataSource = list;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            clearFilters();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detail = new SalesDetailDTO();
            detail.SalesID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[10].Value);
            detail.ProductID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
            detail.CustomerName = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            detail.ProductName = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            detail.Price = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[7].Value);
            detail.SalesAmount = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[6].Value);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (detail.SalesID == 0)
                MessageBox.Show("please select a sale");
            else
            {
                FrmSales frm = new FrmSales();
                frm.isUpdate = true;
                frm.detail = detail;
                frm.dto = dto;
                this.Hide();
                frm.ShowDialog();
                bll = new SalesBLL();
                dto = bll.Select();
                dataGridView1.DataSource = dto.Sales;
                this.Visible = true;
                clearFilters();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (detail.SalesID == 0)
                MessageBox.Show("please select a sale");
            else
            {
                DialogResult result = MessageBox.Show("Are you sure?","Warning!",MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (bll.Delete(detail))
                    {
                        MessageBox.Show("Sale wad deleted");
                        bll = new SalesBLL();
                        dto = bll.Select();
                        dataGridView1.DataSource = dto.Sales;
                        clearFilters();
                    }
                }
            }

        }
    }
}
