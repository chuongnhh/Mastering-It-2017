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
    public partial class InsertForm : Form
    {
        private BLGame blGame = new BLGame();
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
            string gameName = txtGameName.Text.Trim();
            int gameTime = (int)nudGameTime.Value;

            Game game = new Game
            {
                GameName = gameName,
                GameTime = gameTime,
                LevelId = levelId
            };
            blGame.Insert(game);
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
