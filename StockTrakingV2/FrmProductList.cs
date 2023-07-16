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
    public partial class FrmProductList : Form
    {
        ProductBLL bll = new ProductBLL();
        ProductDTO dto = new ProductDTO();
        ProductDetailDTO detail = new ProductDetailDTO();   
        public FrmProductList()
        {
            InitializeComponent();
        }

        private void txtProductPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        private void txtProductStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmProduct frm = new FrmProduct();
            frm.dto = dto;
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
            dto = bll.Select();
            clearFilters();

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            clearFilters();
        }
      
        private void FrmProductList_Load(object sender, EventArgs e)
        {
            dto = bll.Select();
            cmbCategory.DataSource = dto.Categories;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "ID";
            cmbCategory.SelectedIndex = -1;
            dataGridView1.DataSource = dto.Products;
            dataGridView1.Columns[0].HeaderText = "Product Name";
            dataGridView1.Columns[1].HeaderText = "Category Name";
            dataGridView1.Columns[2].HeaderText = "Stock Amount";
            dataGridView1.Columns[3].HeaderText = "Price";
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<ProductDetailDTO> list = dto.Products;
            if (txtProductName.Text.Trim() != null)
                list = list.Where(x => x.ProductName.Contains(txtProductName.Text)).ToList();
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
                    MessageBox.Show("Pleace select a criterion from price group");
            }
            if (txtProductStock.Text.Trim() != "")
            {
                if (rbStockEqual.Checked)
                    list = list.Where(x => x.StockAmount == Convert.ToInt32(txtProductStock.Text)).ToList();
                else if (rbStockMore.Checked)
                    list = list.Where(x => x.StockAmount > Convert.ToInt32(txtProductStock.Text)).ToList();
                else if (rbStockLess.Checked)
                    list = list.Where(x => x.StockAmount < Convert.ToInt32(txtProductStock.Text)).ToList();
                else
                    MessageBox.Show("Please select a criterion from stock group");
            }
            dataGridView1.DataSource = list;


        }

        void clearFilters()
        {
            txtProductName.Clear();
            txtProductPrice.Clear();
            txtProductStock.Clear();
            cmbCategory.SelectedIndex = -1;
            rbPriceEqual.Checked = false;
            rbPriceLess.Checked = false;
            rbPriceMore.Checked = false;
            rbStockEqual.Checked = false;
            rbStockLess.Checked = false;
            rbStockMore.Checked = false;
            dataGridView1.DataSource = dto.Products;
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detail = new ProductDetailDTO();
            detail.ProductID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
            detail.CategoryID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
            detail.Price = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
            detail.ProductName = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (detail.ProductID == 0)
                MessageBox.Show("please select a product");
            else
            {
                FrmProduct frm = new FrmProduct();
                frm.isUpdate = true;
            frm.dto = dto;
                frm.detail = detail;
                this.Hide();
                frm.ShowDialog();
                bll = new ProductBLL();
                dto = bll.Select();
                dataGridView1.DataSource = dto.Products;
                this.Visible = true;

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (detail.ProductID == 0)
                MessageBox.Show("please select a product");
            else
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Warning!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (bll.Delete(detail))
                    {
                        MessageBox.Show("product wad deleted");
                        bll = new ProductBLL();
                        dto = bll.Select();
                        dataGridView1.DataSource = dto.Products;
                        clearFilters();
                    }
                }
            }
        }
    }
}
