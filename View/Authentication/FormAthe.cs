using AutomobileWinform.Repository;
using SaleManagementWinform;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform.Model;
using Winform.Repository;
using Winform.View.Member;

namespace WinformLayer.View
{
    public partial class FormAthe : Form
    {
        private IRepository<Member, Int32> _memberRepository = new MemberRepository();


        public FormAthe()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            AppSettings appSettings = AppSettings.LoadAppSettings();
            if (appSettings != null && appSettings.AdminCredentials != null)
            {
                string emailAdmin = appSettings.AdminCredentials["Email"];
                string passAdmin = appSettings.AdminCredentials["Password"];
                if (emailBox.Text.Equals(emailAdmin) && passwordBox.Text.Equals(passAdmin))
                {
                    MessageBox.Show("You area admin", "Email");
                    FormMainAdmin form = new FormMainAdmin();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    Member member = GetMemberLogin(emailBox.Text, passwordBox.Text);
                    if (member == null)
                    {
                        MessageBox.Show("Login fail");
                    }
                    else
                    {
                        MessageBox.Show("Welcome back", "Email");
                        FormMemberMain form = new FormMemberMain(member);
                        form.Show();
                        this.Hide();
                    }
                }
            }
            else
            {
                MessageBox.Show("Không thể tải cài đặt hoặc không có thông tin tài khoản admin.", "Lỗi");
            }
        }

        private Member GetMemberLogin(string email, string pass)
        {
            return _memberRepository.ListAll()
                    .FirstOrDefault(m => m.Email == email && m.Password == pass);
        }
    }
}
