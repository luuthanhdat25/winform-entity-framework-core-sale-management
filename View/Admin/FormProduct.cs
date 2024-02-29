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

namespace Winform.View.Admin
{
    public partial class FormProduct : Form
    {
        private FormMainAdmin _formMainAdmin;
        private IRepository<Product, Int32> _productrRepository = new ProductRepository();
        private Product _product;

        public FormProduct(FormMainAdmin formMainAdmin, Product product)
        {
            _formMainAdmin = formMainAdmin;
            this._product = product;
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            if (!IsUpdate()) return;
            textBoxCategory.Text = _product.CategoryId.ToString();
            textBoxProductName.Text = _product.ProductName;
            textBoxUnitInStock.Text = _product.UnitInStock.ToString();
            textBoxUnitPrice.Text = _product.UnitPrice.ToString();
            textBoxWeight.Text = _product.Weight;
        }

        private bool IsUpdate() => _product != null;

        private void buttonSave_Click(object sender, EventArgs e)
        {
            bool isUpdate = IsUpdate();
            if (!isUpdate) _product = new Product();

            _product.CategoryId = int.Parse(textBoxCategory.Text);
            _product.ProductName = textBoxProductName.Text;    
            _product.Weight = textBoxWeight.Text;
            _product.UnitPrice = decimal.Parse( textBoxUnitPrice.Text);
            _product.UnitInStock = int.Parse(textBoxUnitInStock.Text);

            if (!isUpdate) _productrRepository.InsertObject(_product);
            else
            {
                bool updte = _productrRepository.UpdateByObject(_product);
                MessageBox.Show(updte.ToString());
            }
            MessageBox.Show("Save successfully!");
            _formMainAdmin.LoadProductList();
            this.Close();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
