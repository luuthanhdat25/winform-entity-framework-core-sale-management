using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform.Repository;

namespace Winform.View.Member
{
    public partial class FormMemberChagePassword : Form
    {
        private Model.Member _member;
        private FormMemberMain _formMemberMain;

        public FormMemberChagePassword(Model.Member member, FormMemberMain formMemberMain)
        {
            this._member = member;
            this._formMemberMain = formMemberMain;
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string oldPassword = textBoxOldPass.Text;
            string newPassword = textBoxNewPass.Text;
            string confirmPassword = textBoxConfirmPass.Text;

            if (_member.Password != oldPassword)
            {
                MessageBox.Show("Incorrect old password!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (newPassword == oldPassword)
            {
                MessageBox.Show("New password must be different from the old one!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("New password and confirm password do not match!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _member.Password = newPassword;
            MemberRepository memberRepository = new MemberRepository();
            memberRepository.UpdateByObject(_member);
            MessageBox.Show("Password updated successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            

            this.Close();
        }



        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
