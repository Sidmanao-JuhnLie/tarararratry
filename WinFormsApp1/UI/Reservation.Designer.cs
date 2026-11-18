namespace WinFormsApp1.UI
{
    partial class Reservation
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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(252, 55);
            label1.TabIndex = 1;
            label1.Text = "Reservation";
            label1.Click += label1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 183);
            button3.Name = "button3";
            button3.Size = new Size(100, 23);
            button3.TabIndex = 10;
            button3.Text = "Profile";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 140);
            button2.Name = "button2";
            button2.Size = new Size(100, 23);
            button2.TabIndex = 9;
            button2.Text = "Reservation";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(12, 99);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 8;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Reservation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Reservation";
            Text = "Reservation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}