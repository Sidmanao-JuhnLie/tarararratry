namespace WinFormsApp1.UI
{
    partial class Profile
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
            btnReturn = new Button();
            btnDashboard = new Button();
            button3 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(293, 55);
            label1.TabIndex = 0;
            label1.Text = "Hello, Admin!";
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(28, 376);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(112, 34);
            btnReturn.TabIndex = 1;
            btnReturn.Text = "Return to Login";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(12, 105);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(100, 23);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 189);
            button3.Name = "button3";
            button3.Size = new Size(100, 23);
            button3.TabIndex = 4;
            button3.Text = "Profile";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(12, 146);
            button2.Name = "button2";
            button2.Size = new Size(100, 23);
            button2.TabIndex = 3;
            button2.Text = "Reservation";
            button2.UseVisualStyleBackColor = true;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(btnDashboard);
            Controls.Add(btnReturn);
            Controls.Add(label1);
            Name = "Profile";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnReturn;
        private Button btnDashboard;
        private Button button3;
        private Button button2;
    }
}