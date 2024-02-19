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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            passwordInput = new TextBox();
            loginBtn = new Button();
            passwordMsgLBL = new Label();
            emailMsgLBL = new Label();
            panel1 = new Panel();
            label1 = new Label();
            welcome = new Label();
            panel2 = new Panel();
            errorMsg = new Label();
            panel8 = new Panel();
            label2 = new Label();
            panel5 = new Panel();
            showPasswordBtn = new PictureBox();
            panel7 = new Panel();
            panel4 = new Panel();
            panel6 = new Panel();
            emailInput = new TextBox();
            close = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)showPasswordBtn).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // passwordInput
            // 
            passwordInput.BorderStyle = BorderStyle.None;
            passwordInput.Font = new Font("Rockwell Condensed", 16F);
            passwordInput.ForeColor = Color.FromArgb(38, 80, 115);
            passwordInput.Location = new Point(55, 13);
            passwordInput.Name = "passwordInput";
            passwordInput.PasswordChar = '*';
            passwordInput.Size = new Size(329, 32);
            passwordInput.TabIndex = 2;
            passwordInput.TextChanged += passwordInput_TextChanged;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = SystemColors.ActiveCaption;
            loginBtn.Font = new Font("Rockwell Condensed", 24F);
            loginBtn.ForeColor = Color.FromArgb(38, 80, 115);
            loginBtn.Location = new Point(125, 404);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(150, 59);
            loginBtn.TabIndex = 4;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBTN_Click;
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 173, 181);
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(welcome);
            panel1.Dock = DockStyle.Left;
            panel1.Font = new Font("Segoe UI Historic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.ForeColor = Color.IndianRed;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(363, 550);
            panel1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Rockwell Condensed", 18F);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(135, 279);
            label1.Name = "label1";
            label1.Size = new Size(209, 35);
            label1.TabIndex = 1;
            label1.Text = "management system";
            // 
            // welcome
            // 
            welcome.AutoSize = true;
            welcome.BackColor = Color.Transparent;
            welcome.Font = new Font("Rockwell Condensed", 18F);
            welcome.ForeColor = SystemColors.ActiveCaption;
            welcome.Location = new Point(3, 222);
            welcome.Name = "welcome";
            welcome.Size = new Size(246, 35);
            welcome.TabIndex = 0;
            welcome.Text = "welcome to attendance ";
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(errorMsg);
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(close);
            panel2.Controls.Add(loginBtn);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(363, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(387, 550);
            panel2.TabIndex = 9;
            panel2.Paint += panel2_Paint;
            // 
            // errorMsg
            // 
            errorMsg.AutoSize = true;
            errorMsg.BackColor = Color.LightGray;
            errorMsg.Font = new Font("Rockwell", 12F);
            errorMsg.ForeColor = Color.Red;
            errorMsg.Location = new Point(109, 335);
            errorMsg.Name = "errorMsg";
            errorMsg.Size = new Size(151, 22);
            errorMsg.TabIndex = 10;
            errorMsg.Text = "email not found";
            errorMsg.Visible = false;
            errorMsg.Click += label3_Click;
            // 
            // panel8
            // 
            panel8.BackgroundImage = (Image)resources.GetObject("panel8.BackgroundImage");
            panel8.BackgroundImageLayout = ImageLayout.Zoom;
            panel8.Location = new Point(125, 33);
            panel8.Name = "panel8";
            panel8.Size = new Size(150, 97);
            panel8.TabIndex = 9;
            panel8.Paint += panel8_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Rockwell Condensed", 24F);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(145, 83);
            label2.Name = "label2";
            label2.Size = new Size(88, 47);
            label2.TabIndex = 8;
            label2.Text = "Login";
            label2.Click += label2_Click;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Window;
            panel5.Controls.Add(showPasswordBtn);
            panel5.Controls.Add(panel7);
            panel5.Controls.Add(passwordInput);
            panel5.Location = new Point(0, 250);
            panel5.Name = "panel5";
            panel5.Size = new Size(387, 48);
            panel5.TabIndex = 7;
            // 
            // showPasswordBtn
            // 
            showPasswordBtn.Image = (Image)resources.GetObject("showPasswordBtn.Image");
            showPasswordBtn.ImageLocation = "";
            showPasswordBtn.Location = new Point(355, 13);
            showPasswordBtn.Name = "showPasswordBtn";
            showPasswordBtn.Size = new Size(29, 30);
            showPasswordBtn.SizeMode = PictureBoxSizeMode.Zoom;
            showPasswordBtn.TabIndex = 11;
            showPasswordBtn.TabStop = false;
            showPasswordBtn.Click += pictureBox1_Click;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.Menu;
            panel7.BackgroundImage = (Image)resources.GetObject("panel7.BackgroundImage");
            panel7.BackgroundImageLayout = ImageLayout.Zoom;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(49, 48);
            panel7.TabIndex = 10;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Window;
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(emailInput);
            panel4.Location = new Point(0, 164);
            panel4.Name = "panel4";
            panel4.Size = new Size(387, 48);
            panel4.TabIndex = 6;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.Menu;
            panel6.BackgroundImage = (Image)resources.GetObject("panel6.BackgroundImage");
            panel6.BackgroundImageLayout = ImageLayout.Zoom;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(49, 48);
            panel6.TabIndex = 9;
            // 
            // emailInput
            // 
            emailInput.BorderStyle = BorderStyle.None;
            emailInput.Font = new Font("Rockwell Condensed", 16F);
            emailInput.ForeColor = Color.FromArgb(38, 80, 115);
            emailInput.Location = new Point(55, 13);
            emailInput.Name = "emailInput";
            emailInput.Size = new Size(329, 32);
            emailInput.TabIndex = 2;
            // 
            // close
            // 
            close.BackgroundImage = (Image)resources.GetObject("close.BackgroundImage");
            close.BackgroundImageLayout = ImageLayout.Center;
            close.Location = new Point(336, 0);
            close.Name = "close";
            close.Size = new Size(51, 52);
            close.TabIndex = 5;
            close.Paint += panel3_Paint;
            close.Click += ExitBTN_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 550);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(emailMsgLBL);
            Controls.Add(passwordMsgLBL);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)showPasswordBtn).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox passwordInput;
        private Button loginBtn;
        private Label passwordMsgLBL;
        private Label emailMsgLBL;
        private Panel panel1;
        private Panel panel2;
        private Label welcome;
        private Label label1;
        private Panel close;
        private Label label2;
        private Panel panel5;
        private TextBox emailInput;
        private Panel panel4;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Label errorMsg;
        private PictureBox showPasswordBtn;
    }
}