namespace WinFormsApp1
{
    partial class Login
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
            label1 = new Label();
            label2 = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            label3 = new Label();
            label4 = new Label();
            chkShowPass = new CheckBox();
            btnLogin = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Script", 27.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(261, 9);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(257, 58);
            label1.TabIndex = 0;
            label1.Text = "proDESKtor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(361, 67);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(64, 30);
            label2.TabIndex = 1;
            label2.Text = "Login";
            label2.Click += label2_Click;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(351, 150);
            txtUserName.Name = "txtUserName";
            txtUserName.RightToLeft = RightToLeft.No;
            txtUserName.Size = new Size(100, 23);
            txtUserName.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(351, 214);
            txtPassword.Name = "txtPassword";
            txtPassword.RightToLeft = RightToLeft.No;
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(351, 132);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(60, 15);
            label3.TabIndex = 4;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(351, 196);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(57, 15);
            label4.TabIndex = 5;
            label4.Text = "Password";
            // 
            // chkShowPass
            // 
            chkShowPass.AutoSize = true;
            chkShowPass.Location = new Point(351, 243);
            chkShowPass.Name = "chkShowPass";
            chkShowPass.RightToLeft = RightToLeft.No;
            chkShowPass.Size = new Size(108, 19);
            chkShowPass.TabIndex = 6;
            chkShowPass.Text = "Show Password";
            chkShowPass.UseVisualStyleBackColor = true;
            chkShowPass.CheckedChanged += chkShowPass_CheckedChanged;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(320, 284);
            btnLogin.Name = "btnLogin";
            btnLogin.RightToLeft = RightToLeft.No;
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(401, 284);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(chkShowPass);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Label label3;
        private Label label4;
        private CheckBox chkShowPass;
        private Button btnLogin;
        private Button btnExit;
    }
}
