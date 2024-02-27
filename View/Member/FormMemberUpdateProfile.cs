using AutomobileWinform.Repository;
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

namespace Winform.View.Member
{
    public partial class FormMemberUpdateProfile : Form
    {
        private Model.Member _member;
        private FormMemberMain _formMemberMain;

        public FormMemberUpdateProfile(Model.Member member, FormMemberMain formMemberMain)
        {

            InitializeComponent();
            this._member = member;
            this._formMemberMain = formMemberMain;
            LoadDataInformation(member);
        }

        private void LoadDataInformation(Model.Member member)
        {
            textBoxEmail.Text = member.Email;
            textBoxCompany.Text = member.CompanyName;
            textBoxCity.Text = member.City;
            textBoxCountry.Text = member.Country;
        }

        private void saveUpdate_Click(object sender, EventArgs e)
        {
            _member.Email = textBoxEmail.Text;
            _member.CompanyName = textBoxCompany.Text;
            _member.City = textBoxCity.Text;
            _member.Country = textBoxCountry.Text;

            MemberRepository orderRepository = new MemberRepository();
            orderRepository.UpdateByObject(_member);

            MessageBox.Show("Update successfully!");
            _formMemberMain.LoadProfile(_member);
            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
