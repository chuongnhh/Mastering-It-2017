using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using DatabaseObject.Entities;

namespace Admin.AdminGame
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
            dgvCboGameLevel.DataSource = (new BLLevel()).GetAll();
            dgvCboGameLevel.DisplayMember = "LevelName";
            dgvCboGameLevel.ValueMember = "Id";

            bs.DataSource = (new BLGame()).GetAll();
            dataGridView1.DataSource = bs;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            (new AdminGame.InsertForm()).ShowDialog();
            bs.DataSource = (new BLGame()).GetAll();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            string x = dataGridView1.Rows[rowIndex].Cells["dgvGameId"].Value.ToString();
            Guid id = Guid.Parse(x);
            (new AdminGame.UpdateForm(id)).ShowDialog();
            bs.DataSource = (new BLGame()).GetAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            string x = dataGridView1.Rows[rowIndex].Cells["dgvGameId"].Value.ToString();
            Guid id = Guid.Parse(x);
            if (MessageBox.Show("Bạn muốn xóa trò chơi này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                (new BLGame()).Delete(id);
                bs.DataSource = (new BLGame()).GetAll();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            bs.DataSource = (new BLGame()).GetAll();
        }
    }
}
