namespace WinformLayer.ViewForm
{
    partial class FormOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            dateTimePickerOrder = new DateTimePicker();
            dateTimePickerRequired = new DateTimePicker();
            dateTimePickerShipped = new DateTimePicker();
            textBoxMember = new TextBox();
            textBoxFreight = new TextBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 22);
            label1.Name = "label1";
            label1.Size = new Size(101, 19);
            label1.TabIndex = 0;
            label1.Text = "Member Order";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 67);
            label2.Name = "label2";
            label2.Size = new Size(78, 19);
            label2.TabIndex = 0;
            label2.Text = "Order Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 117);
            label3.Name = "label3";
            label3.Size = new Size(96, 19);
            label3.TabIndex = 0;
            label3.Text = "Required Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 167);
            label4.Name = "label4";
            label4.Size = new Size(91, 19);
            label4.TabIndex = 0;
            label4.Text = "Shipped Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 220);
            label5.Name = "label5";
            label5.Size = new Size(52, 19);
            label5.TabIndex = 0;
            label5.Text = "Freight";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // dateTimePickerOrder
            // 
            dateTimePickerOrder.Location = new Point(142, 61);
            dateTimePickerOrder.Name = "dateTimePickerOrder";
            dateTimePickerOrder.Size = new Size(200, 26);
            dateTimePickerOrder.TabIndex = 1;
            // 
            // dateTimePickerReqired
            // 
            dateTimePickerRequired.Location = new Point(142, 111);
            dateTimePickerRequired.Name = "dateTimePickerReqired";
            dateTimePickerRequired.Size = new Size(200, 26);
            dateTimePickerRequired.TabIndex = 1;
            // 
            // dateTimePickerShipped
            // 
            dateTimePickerShipped.Location = new Point(142, 161);
            dateTimePickerShipped.Name = "dateTimePickerShipped";
            dateTimePickerShipped.Size = new Size(200, 26);
            dateTimePickerShipped.TabIndex = 1;
            // 
            // textBoxMember
            // 
            textBoxMember.Location = new Point(142, 19);
            textBoxMember.Name = "textBoxMember";
            textBoxMember.Size = new Size(202, 26);
            textBoxMember.TabIndex = 2;
            // 
            // textBoxFreight
            // 
            textBoxFreight.Location = new Point(140, 217);
            textBoxFreight.Name = "textBoxFreight";
            textBoxFreight.Size = new Size(202, 26);
            textBoxFreight.TabIndex = 2;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(33, 256);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(78, 30);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(117, 256);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(78, 30);
            buttonCancel.TabIndex = 3;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // FormOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 329);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(textBoxFreight);
            Controls.Add(textBoxMember);
            Controls.Add(dateTimePickerShipped);
            Controls.Add(dateTimePickerRequired);
            Controls.Add(dateTimePickerOrder);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormOrder";
            Text = "FormProduct";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private DateTimePicker dateTimePickerOrder;
        private DateTimePicker dateTimePickerRequired;
        private DateTimePicker dateTimePickerShipped;
        private TextBox textBoxMember;
        private TextBox textBoxFreight;
        private Button buttonSave;
        private Button buttonCancel;
    }
}