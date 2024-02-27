using AutomobileWinform.Repository;
using System.Data;
using System.Windows.Forms;
using Winform.Model;
using Winform.Repository;
using WinformLayer.View;

namespace Winform.View.Member
{
    public partial class FormMemberMain : Form
    {
        private IRepository<Order, Int32> _orderRepository = new OrderRepository();
        private DataGridViewRow _selectedRow;
        private Model.Member _member;

        public FormMemberMain(Model.Member member)
        {
            InitializeComponent();
            this._member = member;
            LoadProfile(member);
            LoadOrderList();
        }

        public void LoadProfile(Model.Member member)
        {
            emailLable.Text = member.Email;
            companyNameLable.Text = member.CompanyName;
            cityLable.Text = member.City;
            countryLable.Text = member.Country;
        }

        public void LoadOrderList()
        {
            List<Order> orders = (List<Order>)_orderRepository.ListAll(); ;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("OrderID", typeof(int));
            dataTable.Columns.Add("OrderDate", typeof(DateTime));
            dataTable.Columns.Add("RequiredDate", typeof(DateTime));
            dataTable.Columns.Add("ShippedDate", typeof(DateTime));
            dataTable.Columns.Add("Freight", typeof(decimal));

            foreach (var order in orders)
            {
                DataRow newRow = dataTable.NewRow();

                newRow["OrderID"] = order.OrderId;
                newRow["OrderDate"] = order.OrderDate;
                newRow["RequiredDate"] = order.RequiredDate;
                newRow["ShippedDate"] = order.ShippedDate == null ? DBNull.Value : order.ShippedDate;
                newRow["Freight"] = order.Freight;

                dataTable.Rows.Add(newRow);
            }
            orderDataGridView.DataSource = dataTable;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void countryLable_Click(object sender, EventArgs e)
        {

        }

        private void updateProfileBtn_Click(object sender, EventArgs e)
        {
            FormMemberUpdateProfile formMemberUpdateProfile = new FormMemberUpdateProfile(this._member, this);
            formMemberUpdateProfile.ShowDialog();
        }

        private void changePasswordBtn_Click(object sender, EventArgs e)
        {
            FormMemberChagePassword formMemberUpdateProfile = new FormMemberChagePassword(this._member, this);
            formMemberUpdateProfile.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormAthe formAthe = new FormAthe();
            formAthe.Show();
            this.Hide(); 
        }
    }
}
