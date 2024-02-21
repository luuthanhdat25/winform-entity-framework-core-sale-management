using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformLayer.View
{
    public partial class FormAthu : Form
    {
        public FormAthu()
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
                if (emailBox.Text.Equals(emailAdmin) && passwordBox.Text.Equals(passAdmin)){
                    MessageBox.Show("You area admin", "Email");
                }
                
            }
            else
            {
                MessageBox.Show("Không thể tải cài đặt hoặc không có thông tin tài khoản admin.", "Lỗi");
            }
        }
    }
}
