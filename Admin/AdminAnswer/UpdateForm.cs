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
            var an = (new BLAnswer()).Get(id);
            comboBox1.Text = an.AnswerLabel;
            txtQuestonName.Text = an.AnswerName;
            checkBox1.Checked = an.IsTrue;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            var an = (new BLAnswer()).Get(id);

            an.AnswerLabel = comboBox1.Text;
            an.AnswerName = txtQuestonName.Text;
            an.IsTrue = checkBox1.Checked;

            (new BLAnswer()).Update(an);
            this.Close();
        }
    }
}
