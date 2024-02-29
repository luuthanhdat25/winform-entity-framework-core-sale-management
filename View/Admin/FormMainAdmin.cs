using AutomobileWinform.Repository;
using System.Data;
using Winform.Model;
using Winform.Repository;
using Winform.View.Admin;
using WinformLayer.View;
using WinformLayer.ViewForm;

namespace SaleManagementWinform
{
    public partial class FormMainAdmin : Form
    {
        private IRepository<Member, Int32> _memberRepository = new MemberRepository();
        private IRepository<Product, Int32> _productRepository = new ProductRepository();
        private IRepository<Order, Int32> _orderRepository = new OrderRepository();
        public DataGridViewRow _selectedMemberRow;
        private DataGridViewRow _selectedProductRow;
        private DataGridViewRow _selectedOrderRow;

        public FormMainAdmin()
        {
            InitializeComponent();
            LoadMemberList();
            LoadOrderList();
            LoadProductList();
        }

        public void LoadMemberList()
        {
            List<Member> productList = (List<Member>)_memberRepository.ListAll();
            LoadData(productList, dataGridViewMember);
        }

        public void LoadProductList()
        {
            List<Product> productList = (List<Product>)_productRepository.ListAll();
            LoadData(productList, dataGridViewProduct);
        }


        public void LoadOrderList()
        {
            List<Order> orderList = (List<Order>)_orderRepository.ListAll();
            LoadData(orderList, dataGridViewOrder);
        }


        public void LoadData<T>(List<T> dataList, DataGridView dataGridView) where T : class
        {
            DataTable dataTable = new DataTable();
            Type type = typeof(T);
            var properties = type.GetProperties();

            foreach (var property in properties)
            {
                dataTable.Columns.Add(property.Name, Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType);
            }

            foreach (var data in dataList)
            {
                DataRow newRow = dataTable.NewRow();
                foreach (var property in properties)
                {
                    newRow[property.Name] = property.GetValue(data) ?? DBNull.Value;
                }
                dataTable.Rows.Add(newRow);
            }

            dataGridView.DataSource = dataTable;
        }


        private void dataGridViewMember_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewMember.Rows.Count)
            {
                _selectedMemberRow = dataGridViewMember.Rows[e.RowIndex];
            }
        }

        private void dataGridViewProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewProduct.Rows.Count)
            {
                _selectedProductRow = dataGridViewProduct.Rows[e.RowIndex];
            }
        }

        private void dataGridViewOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewOrder.Rows.Count)
            {
                _selectedOrderRow = dataGridViewOrder.Rows[e.RowIndex];
            }
        }

        private void create_member_Click(object sender, EventArgs e)
        {
            FormMember formMember = new FormMember(this, null);
            formMember.ShowDialog();
        }

        private void deleteMember_Click(object sender, EventArgs e)
        {
            if (_selectedMemberRow == null) return;
            int memberId = (int)_selectedMemberRow.Cells["MemberId"].Value;
            _memberRepository.DeleteById(memberId);
            _selectedMemberRow = null;
            MessageBox.Show("Delete successfully!");
            LoadMemberList();
        }

        private void create_Product(object sender, EventArgs e)
        {
            FormProduct formProduct = new FormProduct(this, null);
            formProduct.ShowDialog();
        }

        private void delete_Product(object sender, EventArgs e)
        {

        }

        private void create_Order_Click(object sender, EventArgs e)
        {
            FormOrder formProduct = new FormOrder(this, null);
            formProduct.ShowDialog();
        }

        private void delete_Product_Click(object sender, EventArgs e)
        {
            if (_selectedProductRow == null) return;
            int productId = (int)_selectedProductRow.Cells["ProductId"].Value;
            _productRepository.DeleteById(productId);
            _selectedProductRow = null;
            MessageBox.Show("Delete successfully!");
            LoadProductList();
        }

        private void delete_Order_Click(object sender, EventArgs e)
        {
            if (_selectedOrderRow == null) return;
            int orderId = (int)_selectedOrderRow.Cells["OrderId"].Value;
            _orderRepository.DeleteById(orderId);
            _selectedOrderRow = null;
            MessageBox.Show("Delete successfully!");
            LoadOrderList();
        }

        private void dataGridViewMember_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int memberId = (int)_selectedMemberRow.Cells["MemberId"].Value;
            Member member = _memberRepository.ListAll().First(mem => mem.MemberId == memberId);
            FormMember formMember = new FormMember(this, member);
            formMember.ShowDialog();
        }

        private void dataGridViewProduct_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int productId = (int)_selectedProductRow.Cells["ProductId"].Value;
            Product product = _productRepository.ListAll().First(mem => mem.ProductId == productId);
            FormProduct formProduct = new FormProduct(this, product);
            formProduct.ShowDialog();
        }

        private void dataGridViewOrder_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)_selectedOrderRow.Cells["OrderId"].Value;
            Order order = _orderRepository.ListAll().First(o => o.OrderId == id);
            FormOrder formOrder = new FormOrder(this, order);
            formOrder.ShowDialog();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            FormAthe form = new FormAthe();
            form.Show();
            this.Hide();
        }
    }
}
