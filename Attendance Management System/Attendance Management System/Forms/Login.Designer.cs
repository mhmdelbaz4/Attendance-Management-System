namespace Attendance_Management_System.Forms
{
    partial class Login
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
            emailLBL = new Label();
            PasswordLBL = new Label();
            passwordInput = new TextBox();
            emailInput = new TextBox();
            loginBTN = new Button();
            ExitBTN = new Button();
            passwordMsgLBL = new Label();
            emailMsgLBL = new Label();
            SuspendLayout();
            // 
            // emailLBL
            // 
            emailLBL.AutoSize = true;
            emailLBL.Location = new Point(177, 113);
            emailLBL.Name = "emailLBL";
            emailLBL.Size = new Size(46, 20);
            emailLBL.TabIndex = 0;
            emailLBL.Text = "Email";
            // 
            // PasswordLBL
            // 
            PasswordLBL.AutoSize = true;
            PasswordLBL.Location = new Point(177, 191);
            PasswordLBL.Name = "PasswordLBL";
            PasswordLBL.Size = new Size(72, 20);
            PasswordLBL.TabIndex = 1;
            PasswordLBL.Text = "password";
            // 
            // passwordInput
            // 
            passwordInput.Location = new Point(316, 184);
            passwordInput.Name = "passwordInput";
            passwordInput.Size = new Size(125, 27);
            passwordInput.TabIndex = 2;
            // 
            // emailInput
            // 
            emailInput.Location = new Point(316, 110);
            emailInput.Name = "emailInput";
            emailInput.Size = new Size(125, 27);
            emailInput.TabIndex = 3;
            // 
            // loginBTN
            // 
            loginBTN.Location = new Point(377, 339);
            loginBTN.Name = "loginBTN";
            loginBTN.Size = new Size(94, 29);
            loginBTN.TabIndex = 4;
            loginBTN.Text = "Login";
            loginBTN.UseVisualStyleBackColor = true;
            loginBTN.Click += loginBTN_Click;
            // 
            // ExitBTN
            // 
            ExitBTN.Location = new Point(148, 339);
            ExitBTN.Name = "ExitBTN";
            ExitBTN.Size = new Size(94, 29);
            ExitBTN.TabIndex = 5;
            ExitBTN.Text = "Exit";
            ExitBTN.UseVisualStyleBackColor = true;
            // 
            // passwordMsgLBL
            // 
            passwordMsgLBL.AutoSize = true;
            passwordMsgLBL.Location = new Point(316, 237);
            passwordMsgLBL.Name = "passwordMsgLBL";
            passwordMsgLBL.Size = new Size(0, 20);
            passwordMsgLBL.TabIndex = 6;
            // 
            // emailMsgLBL
            // 
            emailMsgLBL.AutoSize = true;
            emailMsgLBL.BackColor = Color.Red;
            emailMsgLBL.Location = new Point(316, 152);
            emailMsgLBL.Name = "emailMsgLBL";
            emailMsgLBL.Size = new Size(0, 20);
            emailMsgLBL.TabIndex = 7;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(emailMsgLBL);
            Controls.Add(passwordMsgLBL);
            Controls.Add(ExitBTN);
            Controls.Add(loginBTN);
            Controls.Add(emailInput);
            Controls.Add(passwordInput);
            Controls.Add(PasswordLBL);
            Controls.Add(emailLBL);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label emailLBL;
        private Label PasswordLBL;
        private TextBox passwordInput;
        private TextBox emailInput;
        private Button loginBTN;
        private Button ExitBTN;
        private Label passwordMsgLBL;
        private Label emailMsgLBL;
        
    }
}