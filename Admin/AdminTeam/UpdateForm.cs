using BusinessLogic;
using DatabaseObject.Entities;
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
    public partial class UpdateForm : Form
    {
        private BLTeam blTeam = new BLTeam();
        private BLLevel blLevel = new BLLevel();
        private Guid Id;
        public UpdateForm(Guid id)
        {
            this.Id = id;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Team team = blTeam.Get(Id);

            //team.Id = Guid.Parse(txtId.Text);
            team.TeamName = txtTeamName.Text.Trim();
            team.LevelId = Guid.Parse(cboLevel.SelectedValue.ToString());

            blTeam.Update(team);
            this.Close();
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            cboLevel.DataSource = blLevel.GetAll();
            cboLevel.DisplayMember = "LevelName";
            cboLevel.ValueMember = "Id";

            Team team = blTeam.Get(Id);
            txtId.Text = team.Id.ToString();
            txtTeamName.Text = team.TeamName;
        }
    }
}
