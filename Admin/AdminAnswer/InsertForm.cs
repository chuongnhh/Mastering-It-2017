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

namespace Admin.AdminAnswer
{
    public partial class InsertForm : Form
    {
        private Guid questionId;
        public InsertForm(Guid questionId)
        {
            this.questionId = questionId;
            InitializeComponent();
        }

        private void InsertForm_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string answerlabel = comboBox1.Text;
            string answerName = txtQuestonName.Text;
            bool isTrue = checkBox1.Checked;

            (new BLAnswer()).Insert(new DatabaseObject.Entities.Answer
            {
                QuestionId = questionId,
                AnswerLabel = answerlabel,
                AnswerName = answerName,
                IsTrue = isTrue
            });
            this.Close();
        }
    }
}
