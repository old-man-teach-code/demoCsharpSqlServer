namespace peeshop
{
    partial class Form1
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
            tbUserName = new TextBox();
            label2 = new Label();
            tbPassword = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(183, 74);
            label1.Name = "label1";
            label1.Size = new Size(119, 32);
            label1.TabIndex = 0;
            label1.Text = "username";
            // 
            // tbUserName
            // 
            tbUserName.Location = new Point(183, 109);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(413, 39);
            tbUserName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(183, 196);
            label2.Name = "label2";
            label2.Size = new Size(113, 32);
            label2.TabIndex = 2;
            label2.Text = "password";
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(183, 240);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(413, 39);
            tbPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(183, 336);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(413, 46);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(tbPassword);
            Controls.Add(label2);
            Controls.Add(tbUserName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbUserName;
        private Label label2;
        private TextBox tbPassword;
        private Button btnLogin;
    }
}