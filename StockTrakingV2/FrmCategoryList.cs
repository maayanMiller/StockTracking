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
    public partial class FrmCategoryList : Form
    {
        public FrmCategoryList()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmCategory frm = new FrmCategory();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
            dto = bll.Select();
            dataGridView1.DataSource = dto.Catgories;
        }
        CategoryDTO dto = new CategoryDTO();
        CategoryBLL bll = new CategoryBLL();
        CategoryDetailDTO detail = new CategoryDetailDTO();

        private void FrmCategoryList_Load(object sender, EventArgs e)
        {
            dto = bll.Select();
            dataGridView1.DataSource = dto.Catgories;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Category Name";

        }

        private void txtCategoryName_TextChanged(object sender, EventArgs e)
        {
            List<CategoryDetailDTO> list = dto.Catgories;
            list = list.Where(x => x.CategoryName.Contains(txtCategoryName.Text)).ToList();
            dataGridView1.DataSource = list;

        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detail.ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            detail.CategoryName = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (detail.ID == 0)
                MessageBox.Show("please select a category");
            else
            {
                FrmCategory frm = new FrmCategory();
                frm.isUpdate = true;
                frm.detail = detail;
                this.Hide();
                frm.ShowDialog();
                bll = new CategoryBLL();
                dto = bll.Select();
                dataGridView1.DataSource = dto.Catgories;
                this.Visible = true;

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (detail.ID == 0)
                MessageBox.Show("please select a category");
            else
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Warning!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (bll.Delete(detail))
                    {
                        MessageBox.Show("category wad deleted");
                        bll = new CategoryBLL();
                        dto = bll.Select();
                        dataGridView1.DataSource = dto.Catgories;
                    }

                }
            }
        }
    }
}
