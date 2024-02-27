namespace Winform.View.Member
{
    partial class FormMemberChagePassword
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
            textBoxOldPass = new TextBox();
            textBoxNewPass = new TextBox();
            textBoxConfirmPass = new TextBox();
            saveBtn = new Button();
            cancelBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(93, 19);
            label1.TabIndex = 0;
            label1.Text = "Old Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 51);
            label2.Name = "label2";
            label2.Size = new Size(98, 19);
            label2.TabIndex = 0;
            label2.Text = "New Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(124, 19);
            label3.TabIndex = 0;
            label3.Text = "Comfirm Password";
            // 
            // textBoxOldPass
            // 
            textBoxOldPass.Location = new Point(156, 6);
            textBoxOldPass.Name = "textBoxOldPass";
            textBoxOldPass.PasswordChar = '*';
            textBoxOldPass.Size = new Size(232, 26);
            textBoxOldPass.TabIndex = 1;
            // 
            // textBoxNewPass
            // 
            textBoxNewPass.Location = new Point(156, 48);
            textBoxNewPass.Name = "textBoxNewPass";
            textBoxNewPass.PasswordChar = '*';
            textBoxNewPass.Size = new Size(232, 26);
            textBoxNewPass.TabIndex = 1;
            // 
            // textBoxConfirmPass
            // 
            textBoxConfirmPass.Location = new Point(156, 94);
            textBoxConfirmPass.Name = "textBoxConfirmPass";
            textBoxConfirmPass.PasswordChar = '*';
            textBoxConfirmPass.Size = new Size(232, 26);
            textBoxConfirmPass.TabIndex = 1;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(32, 130);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(78, 29);
            saveBtn.TabIndex = 2;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(177, 130);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(78, 29);
            cancelBtn.TabIndex = 2;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // FormMemberChagePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 179);
            Controls.Add(cancelBtn);
            Controls.Add(saveBtn);
            Controls.Add(textBoxConfirmPass);
            Controls.Add(textBoxNewPass);
            Controls.Add(textBoxOldPass);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormMemberChagePassword";
            Text = "FormMemberChagePassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxOldPass;
        private TextBox textBoxNewPass;
        private TextBox textBoxConfirmPass;
        private Button saveBtn;
        private Button cancelBtn;
    }
}