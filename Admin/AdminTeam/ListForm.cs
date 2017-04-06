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

namespace Admin.AdminTeam
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
            dgvCboTeamLevel.DataSource = (new BLLevel()).GetAll();
            dgvCboTeamLevel.DisplayMember = "LevelName";
            dgvCboTeamLevel.ValueMember = "Id";

            bs.DataSource = (new BLTeam()).GetAll();
            dataGridView1.DataSource = bs;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            (new AdminTeam.InsertForm()).ShowDialog();
            bs.DataSource = (new BLTeam()).GetAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            string x = dataGridView1.Rows[rowIndex].Cells["dgvTeamId"].Value.ToString();
            Guid id = Guid.Parse(x);
            if (MessageBox.Show("Bạn muốn xóa đội này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                (new BLTeam()).Delete(id);
                bs.DataSource = (new BLTeam()).GetAll();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            string x = dataGridView1.Rows[rowIndex].Cells["dgvTeamId"].Value.ToString();
            Guid id = Guid.Parse(x);
            (new AdminTeam.UpdateForm(id)).ShowDialog();
            bs.DataSource = (new BLTeam()).GetAll();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            bs.DataSource = (new BLTeam()).GetAll();
        }
    }
}
