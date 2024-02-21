namespace WinformLayer.View
{
    partial class FormMemberMain
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
            emailLable = new Label();
            countryLable = new Label();
            companyNameLable = new Label();
            cityLable = new Label();
            orderHistoryBtn = new Button();
            updateProfileBtn = new Button();
            button3 = new Button();
            changePasswordBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(150, 16);
            label1.Name = "label1";
            label1.Size = new Size(41, 19);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(150, 58);
            label2.Name = "label2";
            label2.Size = new Size(108, 19);
            label2.TabIndex = 0;
            label2.Text = "Company Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(150, 107);
            label3.Name = "label3";
            label3.Size = new Size(33, 19);
            label3.TabIndex = 0;
            label3.Text = "City";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(150, 154);
            label4.Name = "label4";
            label4.Size = new Size(59, 19);
            label4.TabIndex = 0;
            label4.Text = "Country";
            // 
            // emailLable
            // 
            emailLable.AutoSize = true;
            emailLable.Location = new Point(272, 16);
            emailLable.Name = "emailLable";
            emailLable.Size = new Size(45, 19);
            emailLable.TabIndex = 0;
            emailLable.Text = "label1";
            // 
            // countryLable
            // 
            countryLable.AutoSize = true;
            countryLable.Location = new Point(272, 154);
            countryLable.Name = "countryLable";
            countryLable.Size = new Size(45, 19);
            countryLable.TabIndex = 0;
            countryLable.Text = "label1";
            // 
            // companyNameLable
            // 
            companyNameLable.AutoSize = true;
            companyNameLable.Location = new Point(272, 58);
            companyNameLable.Name = "companyNameLable";
            companyNameLable.Size = new Size(45, 19);
            companyNameLable.TabIndex = 0;
            companyNameLable.Text = "label1";
            // 
            // cityLable
            // 
            cityLable.AutoSize = true;
            cityLable.Location = new Point(272, 107);
            cityLable.Name = "cityLable";
            cityLable.Size = new Size(45, 19);
            cityLable.TabIndex = 0;
            cityLable.Text = "label1";
            // 
            // orderHistoryBtn
            // 
            orderHistoryBtn.Location = new Point(12, 12);
            orderHistoryBtn.Name = "orderHistoryBtn";
            orderHistoryBtn.Size = new Size(109, 36);
            orderHistoryBtn.TabIndex = 1;
            orderHistoryBtn.Text = "Order History";
            orderHistoryBtn.UseVisualStyleBackColor = true;
            orderHistoryBtn.Click += this.ViewOrderHistory;
            // 
            // updateProfileBtn
            // 
            updateProfileBtn.Location = new Point(12, 54);
            updateProfileBtn.Name = "updateProfileBtn";
            updateProfileBtn.Size = new Size(109, 34);
            updateProfileBtn.TabIndex = 1;
            updateProfileBtn.Text = "Update Profile";
            updateProfileBtn.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.AppWorkspace;
            button3.Location = new Point(12, 176);
            button3.Name = "button3";
            button3.Size = new Size(109, 34);
            button3.TabIndex = 1;
            button3.Text = "Log out";
            button3.UseVisualStyleBackColor = false;
            // 
            // changePasswordBtn
            // 
            changePasswordBtn.Location = new Point(12, 94);
            changePasswordBtn.Name = "changePasswordBtn";
            changePasswordBtn.Size = new Size(109, 55);
            changePasswordBtn.TabIndex = 1;
            changePasswordBtn.Text = "Change Password";
            changePasswordBtn.UseVisualStyleBackColor = true;
            // 
            // FormMainMember
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 222);
            Controls.Add(button3);
            Controls.Add(changePasswordBtn);
            Controls.Add(updateProfileBtn);
            Controls.Add(orderHistoryBtn);
            Controls.Add(countryLable);
            Controls.Add(label4);
            Controls.Add(cityLable);
            Controls.Add(label3);
            Controls.Add(emailLable);
            Controls.Add(companyNameLable);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormMainMember";
            Text = "FormMainMember";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label emailLable;
        private Label countryLable;
        private Label companyNameLable;
        private Label cityLable;
        private Button orderHistoryBtn;
        private Button updateProfileBtn;
        private Button button3;
        private Button changePasswordBtn;
    }
}