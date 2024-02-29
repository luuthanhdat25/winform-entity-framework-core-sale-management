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
    public partial class FormOrder : Form
    {
        private FormMainAdmin _formMainAdmin;
        private IRepository<Order, Int32> _orderRepository = new OrderRepository();
        private Order _order;

        public FormOrder(FormMainAdmin formMainAdmin, Order order)
        {
            this._formMainAdmin = formMainAdmin;
            this._order = order;
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            if (!IsUpdate()) return;
            textBoxMember.Text = _order.MemberId.ToString();
            dateTimePickerOrder.Value = _order.OrderDate;
            dateTimePickerRequired.Value = _order.RequiredDate;
            dateTimePickerShipped.Value = (DateTime)_order.ShippedDate;
            textBoxFreight.Text = _order.Freight.ToString();
        }

        private bool IsUpdate() => _order != null;

        private void buttonSave_Click(object sender, EventArgs e)
        {
            bool isUpdate = IsUpdate();
            if (!isUpdate) _order = new Order();

            _order.MemberId = Int32.Parse(textBoxMember.Text);
            _order.OrderDate = dateTimePickerOrder.Value;
            _order.RequiredDate = dateTimePickerRequired.Value;
            _order.ShippedDate = dateTimePickerShipped.Value;
            _order.Freight = decimal.Parse(textBoxFreight.Text);

            if (!isUpdate) _orderRepository.InsertObject(_order);
            else
            {
                _orderRepository.UpdateByObject(_order);
                MessageBox.Show("Update successfully!");
            }
            _formMainAdmin.LoadOrderList();
            MessageBox.Show("Save successfully!");
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
