namespace Winform.View.Member
{
    partial class FormMemberUpdateProfile
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
            textBoxEmail = new TextBox();
            textBoxCompany = new TextBox();
            textBoxCity = new TextBox();
            textBoxCountry = new TextBox();
            saveUpdate = new Button();
            cancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(41, 19);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 58);
            label2.Name = "label2";
            label2.Size = new Size(108, 19);
            label2.TabIndex = 0;
            label2.Text = "Company Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 106);
            label3.Name = "label3";
            label3.Size = new Size(33, 19);
            label3.TabIndex = 0;
            label3.Text = "City";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 150);
            label4.Name = "label4";
            label4.Size = new Size(59, 19);
            label4.TabIndex = 0;
            label4.Text = "Country";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(130, 12);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(256, 26);
            textBoxEmail.TabIndex = 1;
            // 
            // textBoxCompany
            // 
            textBoxCompany.Location = new Point(130, 55);
            textBoxCompany.Name = "textBoxCompany";
            textBoxCompany.Size = new Size(256, 26);
            textBoxCompany.TabIndex = 1;
            // 
            // textBoxCity
            // 
            textBoxCity.Location = new Point(130, 103);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(256, 26);
            textBoxCity.TabIndex = 1;
            // 
            // textBoxCountry
            // 
            textBoxCountry.Location = new Point(130, 147);
            textBoxCountry.Name = "textBoxCountry";
            textBoxCountry.Size = new Size(256, 26);
            textBoxCountry.TabIndex = 1;
            // 
            // saveUpdate
            // 
            saveUpdate.Location = new Point(28, 194);
            saveUpdate.Name = "saveUpdate";
            saveUpdate.Size = new Size(92, 28);
            saveUpdate.TabIndex = 2;
            saveUpdate.Text = "Save";
            saveUpdate.UseVisualStyleBackColor = true;
            saveUpdate.Click += saveUpdate_Click;
            // 
            // cancel
            // 
            cancel.Location = new Point(187, 194);
            cancel.Name = "cancel";
            cancel.Size = new Size(92, 28);
            cancel.TabIndex = 2;
            cancel.Text = "Cancel";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // FormMemberUpdateProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 236);
            Controls.Add(cancel);
            Controls.Add(saveUpdate);
            Controls.Add(textBoxCountry);
            Controls.Add(textBoxCity);
            Controls.Add(textBoxCompany);
            Controls.Add(textBoxEmail);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormMemberUpdateProfile";
            Text = "FormMemberUpdateProfile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxEmail;
        private TextBox textBoxCompany;
        private TextBox textBoxCity;
        private TextBox textBoxCountry;
        private Button saveUpdate;
        private Button cancel;
    }
}