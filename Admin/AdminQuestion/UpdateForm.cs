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
    public partial class UpdateForm : Form
    {
        private Guid id;

        public UpdateForm(Guid id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            cboGame.DataSource = (new BLGame()).GetAll();
            cboGame.ValueMember = "Id";
            cboGame.DisplayMember = "GameName";

            var question = (new BLQuestion()).Get(id);

            cboGame.SelectedValue = question.GameId;
            comboBox1.Text = question.QuestionLabel;
            txtQuestonName.Text = question.QuestionName;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var ques = (new BLQuestion()).Get(id);
            ques.GameId = Guid.Parse(cboGame.SelectedValue.ToString());
            ques.QuestionLabel = comboBox1.Text;

            (new BLQuestion()).Update(ques);
            this.Close();
        }
    }
}
