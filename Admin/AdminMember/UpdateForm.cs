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
    public partial class UpdateForm : Form
    {
        private BLMember blMember = new BLMember();
        private BLTeam blTeam = new BLTeam();
        private Guid Id;
        public UpdateForm(Guid id)
        {
            this.Id = id;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Member member = blMember.Get(Id);

            //team.Id = Guid.Parse(txtId.Text);
            member.MemberName = txtMemberName.Text.Trim();
            member.StudentCode = txtStudentCode.Text.Trim();
            member.PhoneNumber = txtPhoneNumber.Text.Trim();
            member.TeamId = Guid.Parse(cboTeam.SelectedValue.ToString());

            blMember.Update(member);
            this.Close();
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            cboTeam.DataSource = blTeam.GetAll();
            cboTeam.DisplayMember = "TeamName";
            cboTeam.ValueMember = "Id";

            Member member = blMember.Get(Id);

            txtId.Text = member.Id.ToString();
            txtMemberName.Text = member.MemberName;
            txtPhoneNumber.Text = member.PhoneNumber;
            txtStudentCode.Text = member.StudentCode;

        }
    }
}
