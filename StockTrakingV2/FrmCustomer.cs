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
    public partial class FrmCustomer : Form
    {
        CustomerBLL bll = new CustomerBLL();

        public bool isUpdate=false;
        public CustomerDetailDTO detail = new CustomerDetailDTO();

        public FrmCustomer()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            if (isUpdate)
                txtCustomerName.Text = detail.CustomerName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCustomerName.Text.Trim() == "")
                MessageBox.Show("Pleace fill Customer name");
            else
            {
              if (!isUpdate)
                {
                    CustomerDetailDTO customer = new CustomerDetailDTO();
                    customer.CustomerName = txtCustomerName.Text;
                    if (bll.Insert(customer))
                    {
                        MessageBox.Show("Customer was added");
                        txtCustomerName.Clear();
                    }
                }else if (isUpdate)
                {
                    detail.CustomerName = txtCustomerName.Text;
                    if (bll.Update(detail))
                    {
                        MessageBox.Show("customer was updated");
                        this.Close();
                    }
                }
            }
        }
    }
}
