

namespace SaleManagementWinform
{
    partial class FormMainAdmin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewMember = new DataGridView();
            dataGridViewProduct = new DataGridView();
            dataGridViewOrder = new DataGridView();
            buttonCreateMem = new Button();
            buttonCreatePro = new Button();
            buttonCreateOrder = new Button();
            buttonDeleteMem = new Button();
            buttonDeletePro = new Button();
            buttonDeleteOrder = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMember).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrder).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewMember
            // 
            dataGridViewMember.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMember.Location = new Point(12, 12);
            dataGridViewMember.Name = "dataGridViewMember";
            dataGridViewMember.Size = new Size(662, 178);
            dataGridViewMember.TabIndex = 0;
            dataGridViewMember.CellContentClick += dataGridViewMember_CellContentClick;
            dataGridViewMember.CellContentDoubleClick += dataGridViewMember_CellContentDoubleClick;
            // 
            // dataGridViewProduct
            // 
            dataGridViewProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProduct.Location = new Point(12, 206);
            dataGridViewProduct.Name = "dataGridViewProduct";
            dataGridViewProduct.Size = new Size(662, 199);
            dataGridViewProduct.TabIndex = 0;
            dataGridViewProduct.CellContentClick += dataGridViewProduct_CellContentClick;
            dataGridViewProduct.CellContentDoubleClick += dataGridViewProduct_CellContentDoubleClick;
            // 
            // dataGridViewOrder
            // 
            dataGridViewOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrder.Location = new Point(12, 421);
            dataGridViewOrder.Name = "dataGridViewOrder";
            dataGridViewOrder.Size = new Size(662, 199);
            dataGridViewOrder.TabIndex = 0;
            dataGridViewOrder.CellContentClick += dataGridViewOrder_CellContentClick;
            dataGridViewOrder.CellContentDoubleClick += dataGridViewOrder_CellContentDoubleClick;
            // 
            // buttonCreateMem
            // 
            buttonCreateMem.Location = new Point(696, 12);
            buttonCreateMem.Name = "buttonCreateMem";
            buttonCreateMem.Size = new Size(135, 64);
            buttonCreateMem.TabIndex = 1;
            buttonCreateMem.Text = "Create Member";
            buttonCreateMem.UseVisualStyleBackColor = true;
            buttonCreateMem.Click += create_member_Click;
            // 
            // buttonCreatePro
            // 
            buttonCreatePro.Location = new Point(696, 206);
            buttonCreatePro.Name = "buttonCreatePro";
            buttonCreatePro.Size = new Size(135, 66);
            buttonCreatePro.TabIndex = 1;
            buttonCreatePro.Text = "Create Product";
            buttonCreatePro.UseVisualStyleBackColor = true;
            buttonCreatePro.Click += create_Product;
            // 
            // buttonCreateOrder
            // 
            buttonCreateOrder.Location = new Point(696, 421);
            buttonCreateOrder.Name = "buttonCreateOrder";
            buttonCreateOrder.Size = new Size(135, 69);
            buttonCreateOrder.TabIndex = 1;
            buttonCreateOrder.Text = "Create Order";
            buttonCreateOrder.UseVisualStyleBackColor = true;
            buttonCreateOrder.Click += create_Order_Click;
            // 
            // buttonDeleteMem
            // 
            buttonDeleteMem.Location = new Point(696, 94);
            buttonDeleteMem.Name = "buttonDeleteMem";
            buttonDeleteMem.Size = new Size(135, 64);
            buttonDeleteMem.TabIndex = 1;
            buttonDeleteMem.Text = "Delete Member";
            buttonDeleteMem.UseVisualStyleBackColor = true;
            buttonDeleteMem.Click += deleteMember_Click;
            // 
            // buttonDeletePro
            // 
            buttonDeletePro.Location = new Point(696, 295);
            buttonDeletePro.Name = "buttonDeletePro";
            buttonDeletePro.Size = new Size(135, 64);
            buttonDeletePro.TabIndex = 1;
            buttonDeletePro.Text = "Delete Product";
            buttonDeletePro.UseVisualStyleBackColor = true;
            buttonDeletePro.Click += delete_Product_Click;
            // 
            // buttonDeleteOrder
            // 
            buttonDeleteOrder.Location = new Point(696, 507);
            buttonDeleteOrder.Name = "buttonDeleteOrder";
            buttonDeleteOrder.Size = new Size(135, 60);
            buttonDeleteOrder.TabIndex = 1;
            buttonDeleteOrder.Text = "Delete Order";
            buttonDeleteOrder.UseVisualStyleBackColor = true;
            buttonDeleteOrder.Click += delete_Order_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDark;
            button1.Location = new Point(728, 584);
            button1.Name = "button1";
            button1.Size = new Size(103, 36);
            button1.TabIndex = 2;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = false;
            button1.Click += logout_Click;
            // 
            // FormMainAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 709);
            Controls.Add(button1);
            Controls.Add(buttonDeleteOrder);
            Controls.Add(buttonCreateOrder);
            Controls.Add(buttonDeletePro);
            Controls.Add(buttonCreatePro);
            Controls.Add(buttonDeleteMem);
            Controls.Add(buttonCreateMem);
            Controls.Add(dataGridViewOrder);
            Controls.Add(dataGridViewProduct);
            Controls.Add(dataGridViewMember);
            Name = "FormMainAdmin";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMember).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrder).EndInit();
            ResumeLayout(false);
        }





        #endregion

        private DataGridView dataGridViewMember;
        private DataGridView dataGridViewProduct;
        private DataGridView dataGridViewOrder;
        private Button buttonCreateMem;
        private Button buttonCreatePro;
        private Button buttonCreateOrder;
        private Button buttonDeleteMem;
        private Button buttonDeletePro;
        private Button buttonDeleteOrder;
        private Button button1;
    }
}
