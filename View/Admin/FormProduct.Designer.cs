namespace Winform.View.Admin
{
    partial class FormProduct
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
            textBoxCategory = new TextBox();
            textBoxProductName = new TextBox();
            textBoxWeight = new TextBox();
            textBoxUnitPrice = new TextBox();
            textBoxUnitInStock = new TextBox();
            buttonSave = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 26);
            label1.Name = "label1";
            label1.Size = new Size(81, 19);
            label1.TabIndex = 0;
            label1.Text = "Category Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 79);
            label2.Name = "label2";
            label2.Size = new Size(97, 19);
            label2.TabIndex = 0;
            label2.Text = "Product Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 131);
            label3.Name = "label3";
            label3.Size = new Size(52, 19);
            label3.TabIndex = 0;
            label3.Text = "Weight";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 185);
            label4.Name = "label4";
            label4.Size = new Size(68, 19);
            label4.TabIndex = 0;
            label4.Text = "Unit Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 229);
            label5.Name = "label5";
            label5.Size = new Size(88, 19);
            label5.TabIndex = 0;
            label5.Text = "Unit In Stock";
            // 
            // textBoxCategory
            // 
            textBoxCategory.Location = new Point(163, 23);
            textBoxCategory.Name = "textBoxCategory";
            textBoxCategory.Size = new Size(290, 26);
            textBoxCategory.TabIndex = 1;
            // 
            // textBoxProductName
            // 
            textBoxProductName.Location = new Point(163, 76);
            textBoxProductName.Name = "textBoxProductName";
            textBoxProductName.Size = new Size(290, 26);
            textBoxProductName.TabIndex = 1;
            // 
            // textBoxWeight
            // 
            textBoxWeight.Location = new Point(163, 128);
            textBoxWeight.Name = "textBoxWeight";
            textBoxWeight.Size = new Size(290, 26);
            textBoxWeight.TabIndex = 1;
            // 
            // textBoxUnitPrice
            // 
            textBoxUnitPrice.Location = new Point(163, 182);
            textBoxUnitPrice.Name = "textBoxUnitPrice";
            textBoxUnitPrice.Size = new Size(290, 26);
            textBoxUnitPrice.TabIndex = 1;
            // 
            // textBoxUnitInStock
            // 
            textBoxUnitInStock.Location = new Point(163, 226);
            textBoxUnitInStock.Name = "textBoxUnitInStock";
            textBoxUnitInStock.Size = new Size(290, 26);
            textBoxUnitInStock.TabIndex = 1;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(21, 277);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(91, 36);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // button2
            // 
            button2.Location = new Point(130, 277);
            button2.Name = "button2";
            button2.Size = new Size(91, 36);
            button2.TabIndex = 2;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FormProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 332);
            Controls.Add(button2);
            Controls.Add(buttonSave);
            Controls.Add(textBoxUnitInStock);
            Controls.Add(textBoxUnitPrice);
            Controls.Add(textBoxWeight);
            Controls.Add(textBoxProductName);
            Controls.Add(textBoxCategory);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormProduct";
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
        private TextBox textBoxCategory;
        private TextBox textBoxProductName;
        private TextBox textBoxWeight;
        private TextBox textBoxUnitPrice;
        private TextBox textBoxUnitInStock;
        private Button buttonSave;
        private Button button2;
    }
}