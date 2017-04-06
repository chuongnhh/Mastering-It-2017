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
    public partial class InsertForm : Form
    {
        private BLTeam blTeam = new BLTeam();
        private BLLevel blLevel = new BLLevel();
        public InsertForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Guid levelId = Guid.Parse(cboLevel.SelectedValue.ToString());
            string teamName = txtTeamName.Text.Trim();

            Team team = new Team
            {
                TeamName = teamName,
                LevelId = levelId
            };
            blTeam.Insert(team);
            this.Close();
        }

        private void InsertForm_Load(object sender, EventArgs e)
        {
            cboLevel.DataSource = blLevel.GetAll();
            cboLevel.DisplayMember = "LevelName";
            cboLevel.ValueMember = "Id";
        }
    }
}
