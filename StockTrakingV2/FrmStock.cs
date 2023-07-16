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
    public partial class FrmStock : Form
    {
         bool combofull = false;
        ProductBLL bll = new ProductBLL();
        ProductDTO dto = new ProductDTO();
        ProductDetailDTO detail = new ProductDetailDTO();
        public FrmStock()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtProductStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);

        }

        private void FrmStock_Load(object sender, EventArgs e)
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
            if (dto.Categories.Count > 0)
                combofull = true;
        }
        private void cmbCatgory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combofull)
            {
                List<ProductDetailDTO> list = dto.Products;
                list = list.Where(x => x.CategoryID == Convert.ToInt32(cmbCategory.SelectedValue)).ToList();
                dataGridView1.DataSource = list;
                if (list.Count == 0)
                {
                    txtProductName.Clear();
                    txtProductPrice.Clear();
                    txtProductStock.Clear();
                }

            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detail.ProductName = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtProductName.Text = detail.ProductName;
            detail.Price = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
            txtProductPrice.Text = detail.Price.ToString();
            detail.StockAmount = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            detail.ProductID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[4].Value);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text.Trim() == "")
                MessageBox.Show("pleace select a product from table");
            else if (txtProductPrice.Text.Trim() == "")
                MessageBox.Show("pleace give a stock amount");
            else
            {
                int sumStock = detail.StockAmount;
                sumStock += Convert.ToInt32(txtProductStock.Text);
                detail.StockAmount = sumStock;
                if (bll.Update(detail))
                {
                    MessageBox.Show("Stock was addes");
                    bll = new ProductBLL();
                    dto = bll.Select();
                    dataGridView1.DataSource = dto.Products;
                    txtProductStock.Clear();
                }
            }
        }
    }
}
