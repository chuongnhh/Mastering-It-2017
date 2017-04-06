using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            AdminLevel.ListForm level = new AdminLevel.ListForm();
            level.TopLevel = false;
            //Added form to tabpage
            tabPage1.Text = level.Text;
            level.Dock = DockStyle.Fill;
            level.Parent = tabPage1;
            level.Show();

            AdminGame.ListForm game = new AdminGame.ListForm();
            game.TopLevel = false;
            tabPage2.Text = game.Text;
            //Added form to tabpage
            game.Dock = DockStyle.Fill;
            game.Parent = tabPage2;
            game.Show();

            AdminTeam.ListForm team = new AdminTeam.ListForm();
            team.TopLevel = false;
            tabPage3.Text = team.Text;
            //Added form to tabpage
            team.Dock = DockStyle.Fill;
            team.Parent = tabPage3;
            team.Show();

            AdminMember.ListForm member = new AdminMember.ListForm();
            member.TopLevel = false;
            tabPage4.Text = member.Text;
            //Added form to tabpage
            member.Dock = DockStyle.Fill;
            member.Parent = tabPage4;
            member.Show();

            AdminQuestion.ListForm question = new AdminQuestion.ListForm();
            question.TopLevel = false;
            tabPage5.Text = question.Text;
            //Added form to tabpage
            question.Dock = DockStyle.Fill;
            question.Parent = tabPage5;
            question.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
