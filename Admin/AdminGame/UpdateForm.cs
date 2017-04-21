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

namespace Admin.AdminGame
{
    public partial class UpdateForm : Form
    {
        private BLGame blGame = new BLGame();
        private BLLevel blLevel = new BLLevel();
        private Guid Id;
        public UpdateForm(Guid id)
        {
            this.Id = id;
            InitializeComponent();
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            cboLevel.DataSource = blLevel.GetAll();
            cboLevel.DisplayMember = "LevelName";
            cboLevel.ValueMember = "Id";

            Game game = blGame.Get(Id);
            txtGameName.Text = game.GameName;
            nudGameTime.Value = game.GameTime;
            txtId.Text = game.Id.ToString();
            nudTeamNumber.Value = game.TeamNumber;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Guid id = Guid.Parse(txtId.Text.Trim());

            Game game = blGame.Get(id);

            game.GameName = txtGameName.Text.Trim();
            game.GameTime = (int)nudGameTime.Value;
            game.LevelId = Guid.Parse(cboLevel.SelectedValue.ToString());
            game.TeamNumber = (int)nudTeamNumber.Value;
            blGame.Update(game);
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
