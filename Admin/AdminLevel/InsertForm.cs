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
    public partial class InsertForm : Form
    {
        private BLLevel blLevel = new BLLevel();

        public InsertForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Level level = new Level();
            level.LevelName = txtLevelName.Text.Trim();
            blLevel.Insert(level);
        }
    }
}
