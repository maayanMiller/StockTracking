using StockTrakingV2.BLL;
using StockTrakingV2.DAL;
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
    public partial class FrmProduct : Form
    {
        public FrmProduct()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        ProductBLL bll = new ProductBLL();
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text.Trim() == "")
                MessageBox.Show("Pleace fill product name");
            else if (txtPrice.Text.Trim() == "")
            {

                MessageBox.Show("Pleace fill price");
            }
            else if (cmbCategory.SelectedIndex == -1)
            {

                MessageBox.Show("Pleace select Catgory");
            }
            else
            {
                if (!isUpdate)
                {
                    ProductDetailDTO product = new ProductDetailDTO();
                    product.ProductName = txtProductName.Text;
                    product.Price = Convert.ToInt32(txtPrice.Text);
                    product.CategoryID = Convert.ToInt32(cmbCategory.SelectedValue);
                    if (bll.Insert(product))
                    {


                        MessageBox.Show("product was added");
                        txtProductName.Clear();
                        txtPrice.Clear();
                        cmbCategory.SelectedIndex = -1;


                    }
                }
                else if (isUpdate)
                {
                    if (detail.CategoryID == Convert.ToInt32(cmbCategory.SelectedValue) &&
                            detail.ProductName == txtProductName.Text &&
                            detail.Price == Convert.ToInt32(txtPrice.Text))
                        MessageBox.Show("there is no change");
                    else
                    {
                        detail.ProductName = txtProductName.Text;
                        detail.Price = Convert.ToInt32(txtPrice.Text);
                        detail.CategoryID = Convert.ToInt32(cmbCategory.SelectedValue);
                        if (bll.Update(detail))
                        {
                            MessageBox.Show("product was updated");
                            this.Close();

                        }
                    }

                }
            }
        }
        public ProductDTO dto = new ProductDTO();

        public bool isUpdate = false;
        public ProductDetailDTO detail = new ProductDetailDTO();

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            cmbCategory.DataSource = dto.Categories;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "ID";
            cmbCategory.SelectedIndex = -1;
            if (isUpdate)
            {

                cmbCategory.SelectedValue = detail.CategoryID;
                txtProductName.Text = detail.ProductName;
                txtPrice.Text = detail.Price.ToString();
            }
        }
    }
}
