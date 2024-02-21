using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform.View.Member;

namespace WinformLayer.View
{
    public partial class FormMemberMain : Form
    {
        public FormMemberMain()
        {
            InitializeComponent();
        }

        public void ViewOrderHistory(object o, EventArgs e)
        {
            FormOrderHistory formOrderHistory = new FormOrderHistory();
            formOrderHistory.ShowDialog();
        }
    }
}
