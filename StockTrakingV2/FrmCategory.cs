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
    public partial class FrmCategory : Form
    {
        CategoryBLL bll = new CategoryBLL();

        public bool isUpdate = false;
        public CategoryDetailDTO detail = new CategoryDetailDTO();

        public FrmCategory()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FrmCategory_Load(object sender, EventArgs e)
        {
            if (isUpdate)
                txtCategoryName.Text = detail.CategoryName;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCategoryName.Text.Trim() == "")
                MessageBox.Show("Pleace fill Catgory name");
            else
            {
                if (!isUpdate)
                {
                    CategoryDetailDTO catgory = new CategoryDetailDTO();
                    catgory.CategoryName = txtCategoryName.Text;
                    if (bll.Insert(catgory))
                    {
                        MessageBox.Show("Catgory was added");
                        txtCategoryName.Clear();
                    }
                }
                else if (isUpdate)
                {
                    detail.CategoryName = txtCategoryName.Text;
                    if (bll.Update(detail))
                    {
                        MessageBox.Show("category update");
                        this.Close();
                    }
                }
            }
        }

    }
}
