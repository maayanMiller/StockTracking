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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace StockTrakingV2
{
    public partial class FrmDeleted : Form
    {
        SalesDTO dto = new SalesDTO();
        SalesBLL bll = new SalesBLL();
        CategoryDetailDTO categorydetail = new CategoryDetailDTO();
        ProductDetailDTO productdetail = new ProductDetailDTO();
        CustomerDetailDTO customerdetail = new CustomerDetailDTO();
        SalesDetailDTO saledetail = new SalesDetailDTO();
        CategoryBLL categoryBLL = new CategoryBLL();
        ProductBLL productBLL = new ProductBLL();
        CustomerBLL customerBLL = new CustomerBLL();    
        SalesBLL salesBLL = new SalesBLL();  




        public FrmDeleted()
        {
            InitializeComponent();
        }

        private void FrmDeleted_Load(object sender, EventArgs e)
        {
            cmbDeletedData.Items.Add("Category");
            cmbDeletedData.Items.Add("Product");
            cmbDeletedData.Items.Add("Customer");
            cmbDeletedData.Items.Add("Select");
            dto = bll.Select(true);
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbDeletedData_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDeletedData.SelectedIndex == 0)
            {
                dataGridView1.DataSource = dto.Catgories;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "Category Name";
            }
            else if (cmbDeletedData.SelectedIndex == 1)
            {
                dataGridView1.DataSource = dto.Products;
                dataGridView1.Columns[0].HeaderText = "Product Name";
                dataGridView1.Columns[1].HeaderText = "Category Name";
                dataGridView1.Columns[2].HeaderText = "Stock Amount";
                dataGridView1.Columns[3].HeaderText = "Price";
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].Visible = false;
            }
            else if (cmbDeletedData.SelectedIndex == 2)
            {
                dataGridView1.DataSource = dto.Customers;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "Customer Name";
            }
            else if (cmbDeletedData.SelectedIndex == 3)
            {
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
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (cmbDeletedData.SelectedIndex == 0)
            {
                categorydetail.ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                categorydetail.CategoryName = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            else if (cmbDeletedData.SelectedIndex == 1)
            {
                productdetail = new ProductDetailDTO();
                productdetail.ProductID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
                productdetail.CategoryID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
                productdetail.StockAmount = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
                productdetail.Price = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
                productdetail.ProductName = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            else if (cmbDeletedData.SelectedIndex == 2)
            {
                customerdetail.ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                customerdetail.CustomerName = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            else 
            {
                saledetail = new SalesDetailDTO();
                saledetail.SalesID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[10].Value);
                saledetail.ProductID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
                saledetail.CustomerName = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                saledetail.ProductName = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                saledetail.Price = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[7].Value);
                saledetail.SalesAmount = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[6].Value);
                ProductDetailDTO product = dto.Products.First(x => x.ProductID == saledetail.ProductID);
                saledetail.StockAmount = product.StockAmount;
            }
        }

        private void btnGetback_Click(object sender, EventArgs e)
        {
            if (cmbDeletedData.SelectedIndex == 0)
            {
                if (categoryBLL.GetBack(categorydetail))
                {
                    MessageBox.Show("category was added back");
                    dto = bll.Select(true);
                    dataGridView1.DataSource = dto.Catgories;
                }
            }
            else if (cmbDeletedData.SelectedIndex == 1)
            {
                if(productBLL.GetBack(productdetail))
                {
                    MessageBox.Show("product was added back");
                    dto = bll.Select(true);
                    dataGridView1.DataSource = dto.Products;
                }
            }
            else if (cmbDeletedData.SelectedIndex == 2)
            {
                if (customerBLL.GetBack(customerdetail))
                {
                    MessageBox.Show("customer was added back");
                    dto = bll.Select(true);
                    dataGridView1.DataSource = dto.Customers;
                }
            }
            else 
            {
                if (salesBLL.GetBack(saledetail))
                {
                    MessageBox.Show("sale was added back");
                    dto = bll.Select(true);
                    dataGridView1.DataSource = dto.Sales;
                }   
            }
        }
    }
}

