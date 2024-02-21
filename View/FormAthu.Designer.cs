namespace WinformLayer.View
{
    partial class FormAthu
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
            emailBox = new TextBox();
            passwordBox = new TextBox();
            signInBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 42);
            label1.Name = "label1";
            label1.Size = new Size(41, 19);
            label1.TabIndex = 0;
            label1.Text = "Email";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 120);
            label2.Name = "label2";
            label2.Size = new Size(67, 19);
            label2.TabIndex = 0;
            label2.Text = "Password";
            // 
            // emailBox
            // 
            emailBox.Location = new Point(99, 39);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(228, 26);
            emailBox.TabIndex = 1;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(99, 117);
            passwordBox.Name = "passwordBox";
            passwordBox.PasswordChar = '*';
            passwordBox.Size = new Size(228, 26);
            passwordBox.TabIndex = 1;
            // 
            // signInBtn
            // 
            signInBtn.Location = new Point(99, 175);
            signInBtn.Name = "signInBtn";
            signInBtn.Size = new Size(99, 38);
            signInBtn.TabIndex = 2;
            signInBtn.Text = "Sign in";
            signInBtn.UseVisualStyleBackColor = true;
            signInBtn.Click += SignInBtn_Click;
            // 
            // FormAthu
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 239);
            Controls.Add(signInBtn);
            Controls.Add(passwordBox);
            Controls.Add(emailBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormAthu";
            Text = "FormAthu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox emailBox;
        private TextBox passwordBox;
        private Button signInBtn;
    }
}