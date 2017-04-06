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

namespace Admin.AdminAnswer
{
    public partial class ListForm : Form
    {
        private BindingSource bs = new BindingSource();
        private Guid questionId;

        public ListForm(Guid questionId)
        {
            this.questionId = questionId;
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            bs.DataSource = (new BLAnswer()).GetAll(questionId);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            (new AdminAnswer.InsertForm(questionId)).ShowDialog();
            bs.DataSource = (new BLAnswer()).GetAll(questionId);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            string x = dataGridView1.Rows[rowIndex].Cells["dgvAnswerId"].Value.ToString();
            Guid id = Guid.Parse(x);
            if (MessageBox.Show("Bạn muốn xóa đáp án này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                (new BLAnswer()).Delete(id);
                bs.DataSource = (new BLAnswer()).GetAll(questionId);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            string x = dataGridView1.Rows[rowIndex].Cells["dgvAnswerId"].Value.ToString();
            Guid id = Guid.Parse(x);
            (new AdminAnswer.UpdateForm(id)).ShowDialog();
            bs.DataSource = (new BLAnswer()).GetAll(questionId);
        }

        private void ListForm_Load(object sender, EventArgs e)
        {
            bs.DataSource = (new BLAnswer()).GetAll(questionId);
            dataGridView1.DataSource = bs;
        }
    }
}
