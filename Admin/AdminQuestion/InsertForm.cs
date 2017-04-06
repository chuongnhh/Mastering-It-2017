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

namespace Admin.AdminQuestion
{
    public partial class InsertForm : Form
    {
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
            Guid gameId = Guid.Parse(cboGame.SelectedValue.ToString());
            string questionLabel = comboBox1.Text;
            string questionName = txtQuestonName.Text;

            (new BLQuestion()).Insert(new DatabaseObject.Entities.Question
            {
                GameId = gameId,
                QuestionLabel = questionLabel,
                QuestionName = questionName
            });
            this.Close();
        }

        private void InsertForm_Load(object sender, EventArgs e)
        {
            cboGame.DataSource = (new BLGame()).GetAll();
            cboGame.ValueMember = "Id";
            cboGame.DisplayMember = "GameName";
        }
    }
}
