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

namespace WinformLayer.ViewForm
{
    public partial class FormMember : Form
    {
        private FormMainAdmin _formMainAdmin;
        private IRepository<Member, Int32> _memberRepository = new MemberRepository();
        private Member _member;

        public FormMember(FormMainAdmin formMainAdmin, Member member)
        {
            this._member = member;
            this._formMainAdmin = formMainAdmin;
            InitializeComponent();
            LoadData();
        }

        private bool IsUpdate() => _member != null;

        private void LoadData()
        {
            if (!IsUpdate()) return;
            textBoxEmail.Text = _member.Email;
            textBoxCompany.Text = _member.CompanyName;
            textBoxCity.Text = _member.City;
            textBoxCountry.Text = _member.Country;
            textBoxPass.Text = _member.Password;
        }

        private void save_Click(object sender, EventArgs e)
        {
            bool isUpdate = IsUpdate();
            if (!isUpdate) _member = new Member();

            _member.Email = textBoxEmail.Text;
            _member.CompanyName = textBoxCompany.Text;
            _member.City = textBoxCity.Text;
            _member.Country = textBoxCountry.Text;
            _member.Password = textBoxPass.Text;
            
            if(!isUpdate) _memberRepository.InsertObject(_member);
            else _memberRepository.UpdateByObject(_member);
            
            MessageBox.Show("Save successfully!");
            _formMainAdmin.LoadMemberList();
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e) => this.Close();
    }
}
