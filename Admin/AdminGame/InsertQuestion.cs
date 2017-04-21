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

namespace Admin.AdminGame
{
    public partial class InsertQuestion : Form
    {
        private Guid gameId;
        public InsertQuestion(Guid gameId)
        {
            this.gameId = gameId;
            InitializeComponent();
        }

        private void InsertQuestion_Load(object sender, EventArgs e)
        {
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
