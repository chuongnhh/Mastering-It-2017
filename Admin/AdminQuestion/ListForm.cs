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

namespace Admin.AdminQuestion
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
            bs.DataSource = (new BLQuestion()).GetAll();
            dataGridView1.DataSource = bs;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            (new AdminQuestion.InsertForm()).ShowDialog();
            bs.DataSource = (new BLQuestion()).GetAll();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            string x = dataGridView1.Rows[rowIndex].Cells["dgvQuestionId"].Value.ToString();
            Guid id = Guid.Parse(x);
            (new AdminQuestion.UpdateForm(id)).ShowDialog();
            bs.DataSource = (new BLQuestion()).GetAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            string x = dataGridView1.Rows[rowIndex].Cells["dgvQuestionId"].Value.ToString();
            Guid id = Guid.Parse(x);
            if (MessageBox.Show("Bạn muốn xóa câu hỏi này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                (new BLQuestion()).Delete(id);
                bs.DataSource = (new BLQuestion()).GetAll();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            bs.DataSource = (new BLQuestion()).GetAll();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            Guid x = Guid.Parse(dataGridView1.Rows[rowIndex].Cells["dgvQuestionId"].Value.ToString());
            (new AdminAnswer.ListForm(x)).ShowDialog();
        }
    }
}
