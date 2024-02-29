namespace WinformLayer.ViewForm
{
    partial class FormMember
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
            textBoxEmail = new TextBox();
            textBoxCompany = new TextBox();
            textBoxCity = new TextBox();
            textBoxCountry = new TextBox();
            textBoxPass = new TextBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 24);
            label1.Name = "label1";
            label1.Size = new Size(41, 19);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 71);
            label2.Name = "label2";
            label2.Size = new Size(106, 19);
            label2.TabIndex = 0;
            label2.Text = "Company name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 125);
            label3.Name = "label3";
            label3.Size = new Size(33, 19);
            label3.TabIndex = 0;
            label3.Text = "City";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 177);
            label4.Name = "label4";
            label4.Size = new Size(59, 19);
            label4.TabIndex = 0;
            label4.Text = "Country";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 230);
            label5.Name = "label5";
            label5.Size = new Size(67, 19);
            label5.TabIndex = 0;
            label5.Text = "Password";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(144, 21);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(222, 26);
            textBoxEmail.TabIndex = 1;
            // 
            // textBoxCompany
            // 
            textBoxCompany.Location = new Point(144, 68);
            textBoxCompany.Name = "textBoxCompany";
            textBoxCompany.Size = new Size(222, 26);
            textBoxCompany.TabIndex = 1;
            // 
            // textBoxCity
            // 
            textBoxCity.Location = new Point(144, 122);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(222, 26);
            textBoxCity.TabIndex = 1;
            // 
            // textBoxContry
            // 
            textBoxCountry.Location = new Point(144, 174);
            textBoxCountry.Name = "textBoxContry";
            textBoxCountry.Size = new Size(222, 26);
            textBoxCountry.TabIndex = 1;
            // 
            // textBoxPass
            // 
            textBoxPass.Location = new Point(144, 227);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.PasswordChar = '*';
            textBoxPass.Size = new Size(222, 26);
            textBoxPass.TabIndex = 1;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(26, 270);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(88, 35);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += save_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(144, 270);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(88, 35);
            buttonCancel.TabIndex = 2;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // FormMember
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 330);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(textBoxPass);
            Controls.Add(textBoxCountry);
            Controls.Add(textBoxCity);
            Controls.Add(textBoxCompany);
            Controls.Add(textBoxEmail);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormMember";
            Text = "FormMember";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxEmail;
        private TextBox textBoxCompany;
        private TextBox textBoxCity;
        private TextBox textBoxCountry;
        private TextBox textBoxPass;
        private Button buttonSave;
        private Button buttonCancel;
    }
}