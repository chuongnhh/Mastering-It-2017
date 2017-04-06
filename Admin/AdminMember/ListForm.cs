using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin.AdminMember
{
    public partial class ListForm : Form
    {

        private BindingSource bs = new BindingSource();
        public ListForm()
        {
            InitializeComponent();
        }

        private void ListForm_Load(object sender, EventArgs e)
        {
            bs.DataSource = (new BLMember()).GetAll();
            dataGridView1.DataSource = bs;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            string x = dataGridView1.Rows[rowIndex].Cells["dgvMemberId"].Value.ToString();
            Guid id = Guid.Parse(x);
            if (MessageBox.Show("Bạn muốn xóa thành viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                (new BLMember()).Delete(id);
                bs.DataSource = (new BLMember()).GetAll();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            (new AdminMember.InsertForm()).ShowDialog();
            bs.DataSource = (new BLMember()).GetAll();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            string x = dataGridView1.Rows[rowIndex].Cells["dgvMemberId"].Value.ToString();
            Guid id = Guid.Parse(x);
            (new AdminMember.UpdateForm(id)).ShowDialog();
            bs.DataSource = (new BLMember()).GetAll();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            bs.DataSource = (new BLMember()).GetAll();
        }
    }
}
