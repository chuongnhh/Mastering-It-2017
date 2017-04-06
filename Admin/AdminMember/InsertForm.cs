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

namespace Admin.AdminMember
{
    public partial class InsertForm : Form
    {
        private BLTeam blTeam = new BLTeam();
        private BLMember blMember = new BLMember();

        public InsertForm()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string memberName = txtMemberName.Text.Trim();
            Guid teamId = Guid.Parse(cboTeam.SelectedValue.ToString());
            string studentCode = txtStudentCode.Text.Trim();
            string phoneNumber = txtPhoneNumber.Text.Trim();

            Member member = new Member
            {
                MemberName = memberName,
                PhoneNumber = phoneNumber,
                StudentCode = studentCode,
                TeamId = teamId
            };
            blMember.Insert(member);
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InsertFrom_Load(object sender, EventArgs e)
        {
            cboTeam.DataSource = blTeam.GetAll();
            cboTeam.ValueMember = "Id";
            cboTeam.DisplayMember = "TeamName";
        }
    }
}
