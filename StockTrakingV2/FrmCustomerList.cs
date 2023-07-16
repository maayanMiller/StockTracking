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
    public partial class FrmCustomerList : Form
    {
        public FrmCustomerList()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmCustomer frm = new FrmCustomer();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
            dto = bll.Select();
            dataGridView1.DataSource = dto.Customers;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        CustomerBLL bll = new CustomerBLL();
        CustomerDTO dto = new CustomerDTO();
        CustomerDetailDTO detail = new CustomerDetailDTO();
        private void FrmCustomerList_Load(object sender, EventArgs e)
        {
            dto = bll.Select();
            dataGridView1.DataSource = dto.Customers;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Customer Name";
        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {
            List<CustomerDetailDTO> list = dto.Customers;
            list = list.Where(x => x.CustomerName.Contains(txtCustomerName.Text)).ToList();
            dataGridView1.DataSource = list;
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detail.ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            detail.CustomerName = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (detail.ID == 0)
                MessageBox.Show("please select a Customer");
            else
            {
                FrmCustomer frm = new FrmCustomer();
                frm.isUpdate = true;
                frm.detail = detail;
                this.Hide();
                frm.ShowDialog();
                bll = new CustomerBLL();
                dto = bll.Select();
                dataGridView1.DataSource = dto.Customers;
                this.Visible = true;

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (detail.ID == 0)
                MessageBox.Show("please select a customer");
            else
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Warning!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (bll.Delete(detail))
                    {
                        MessageBox.Show("customer wad deleted");
                        bll = new CustomerBLL();
                        dto = bll.Select();
                        dataGridView1.DataSource = dto.Customers;
                    }

                }
            }
        }
    }
}
