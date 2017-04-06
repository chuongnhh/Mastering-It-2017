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

namespace Admin.AdminLevel
{
    public partial class UpdateForm : Form
    {
        private BLLevel blLevel = new BLLevel();
        private Guid id;
        public UpdateForm(Guid id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Level level = blLevel.Get(id);

            // level.Id = Guid.Parse(txtId.Text);
            level.LevelName = txtLevelName.Text.Trim();

            blLevel.Update(level);
            this.Close();
        }

        private void UpdateLevel_Load(object sender, EventArgs e)
        {
            Level level = blLevel.Get(id);
            txtId.Text = level.Id.ToString();
            txtLevelName.Text = level.LevelName.ToString();
        }
    }
}
