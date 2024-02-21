namespace Attendance_Management_System.Forms
{
    partial class UserControlAddStudent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabAddStudent = new TabControl();
            addStudentTabPage = new TabPage();
            errorMsg = new Label();
            addStudentBtn = new Button();
            trackComboBox = new ComboBox();
            passwordInput = new TextBox();
            panel2 = new Panel();
            passwordLabel = new Label();
            panel3 = new Panel();
            trackLabel = new Label();
            emailInput = new TextBox();
            panel1 = new Panel();
            emailLabel = new Label();
            StudentNameInput = new TextBox();
            namePanel = new Panel();
            nameLabel = new Label();
            addStudentHeading = new Label();
            searchStudent = new TabPage();
            updateAndDeleteStudent = new TabPage();
            tabAddStudent.SuspendLayout();
            addStudentTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // tabAddStudent
            // 
            tabAddStudent.Alignment = TabAlignment.Bottom;
            tabAddStudent.Controls.Add(addStudentTabPage);
            tabAddStudent.Controls.Add(searchStudent);
            tabAddStudent.Controls.Add(updateAndDeleteStudent);
            tabAddStudent.Dock = DockStyle.Fill;
            tabAddStudent.Location = new Point(0, 0);
            tabAddStudent.Name = "tabAddStudent";
            tabAddStudent.SelectedIndex = 0;
            tabAddStudent.Size = new Size(1277, 548);
            tabAddStudent.TabIndex = 0;
            // 
            // addStudentTabPage
            // 
            addStudentTabPage.Controls.Add(errorMsg);
            addStudentTabPage.Controls.Add(addStudentBtn);
            addStudentTabPage.Controls.Add(trackComboBox);
            addStudentTabPage.Controls.Add(passwordInput);
            addStudentTabPage.Controls.Add(panel2);
            addStudentTabPage.Controls.Add(passwordLabel);
            addStudentTabPage.Controls.Add(panel3);
            addStudentTabPage.Controls.Add(trackLabel);
            addStudentTabPage.Controls.Add(emailInput);
            addStudentTabPage.Controls.Add(panel1);
            addStudentTabPage.Controls.Add(emailLabel);
            addStudentTabPage.Controls.Add(StudentNameInput);
            addStudentTabPage.Controls.Add(namePanel);
            addStudentTabPage.Controls.Add(nameLabel);
            addStudentTabPage.Controls.Add(addStudentHeading);
            addStudentTabPage.Font = new Font("Rockwell", 16.2F);
            addStudentTabPage.ForeColor = Color.FromArgb(39, 55, 77);
            addStudentTabPage.Location = new Point(4, 4);
            addStudentTabPage.Name = "addStudentTabPage";
            addStudentTabPage.Padding = new Padding(5);
            addStudentTabPage.Size = new Size(1269, 515);
            addStudentTabPage.TabIndex = 0;
            addStudentTabPage.Text = "add student";
            addStudentTabPage.UseVisualStyleBackColor = true;
            // 
            // errorMsg
            // 
            errorMsg.AutoSize = true;
            errorMsg.BackColor = Color.LightGray;
            errorMsg.Font = new Font("Rockwell", 12F);
            errorMsg.ForeColor = Color.Red;
            errorMsg.Location = new Point(559, 358);
            errorMsg.Name = "errorMsg";
            errorMsg.Size = new Size(151, 22);
            errorMsg.TabIndex = 19;
            errorMsg.Text = "email not found";
            errorMsg.Visible = false;
            // 
            // addStudentBtn
            // 
            addStudentBtn.BackColor = Color.FromArgb(39, 55, 77);
            addStudentBtn.FlatAppearance.BorderSize = 0;
            addStudentBtn.FlatStyle = FlatStyle.Flat;
            addStudentBtn.Font = new Font("Rockwell", 16.2F);
            addStudentBtn.ForeColor = Color.AliceBlue;
            addStudentBtn.Location = new Point(521, 426);
            addStudentBtn.Name = "addStudentBtn";
            addStudentBtn.Size = new Size(226, 56);
            addStudentBtn.TabIndex = 18;
            addStudentBtn.Text = "Add Student";
            addStudentBtn.UseVisualStyleBackColor = false;
            addStudentBtn.Click += addStudentBtn_Click;
            // 
            // trackComboBox
            // 
            trackComboBox.Font = new Font("Rockwell", 16.2F);
            trackComboBox.ForeColor = Color.FromArgb(39, 55, 77);
            trackComboBox.FormattingEnabled = true;
            trackComboBox.Items.AddRange(new object[] { "--Select Track--" });
            trackComboBox.Location = new Point(142, 258);
            trackComboBox.Name = "trackComboBox";
            trackComboBox.Size = new Size(337, 39);
            trackComboBox.TabIndex = 17;
            // 
            // passwordInput
            // 
            passwordInput.BorderStyle = BorderStyle.None;
            passwordInput.Font = new Font("Rockwell Condensed", 16F);
            passwordInput.ForeColor = Color.FromArgb(38, 80, 115);
            passwordInput.Location = new Point(790, 263);
            passwordInput.Name = "passwordInput";
            passwordInput.Size = new Size(335, 32);
            passwordInput.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Window;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(790, 297);
            panel2.Name = "panel2";
            panel2.Size = new Size(337, 2);
            panel2.TabIndex = 16;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Rockwell", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordLabel.ForeColor = Color.FromArgb(39, 55, 77);
            passwordLabel.Location = new Point(792, 217);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(147, 31);
            passwordLabel.TabIndex = 14;
            passwordLabel.Text = "Password:";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Window;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Location = new Point(142, 297);
            panel3.Name = "panel3";
            panel3.Size = new Size(337, 2);
            panel3.TabIndex = 13;
            // 
            // trackLabel
            // 
            trackLabel.AutoSize = true;
            trackLabel.Font = new Font("Rockwell", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            trackLabel.ForeColor = Color.FromArgb(39, 55, 77);
            trackLabel.Location = new Point(144, 217);
            trackLabel.Name = "trackLabel";
            trackLabel.Size = new Size(96, 31);
            trackLabel.TabIndex = 11;
            trackLabel.Text = "Track:";
            // 
            // emailInput
            // 
            emailInput.BorderStyle = BorderStyle.None;
            emailInput.Font = new Font("Rockwell Condensed", 16F);
            emailInput.ForeColor = Color.FromArgb(38, 80, 115);
            emailInput.Location = new Point(783, 166);
            emailInput.Name = "emailInput";
            emailInput.Size = new Size(335, 32);
            emailInput.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(783, 200);
            panel1.Name = "panel1";
            panel1.Size = new Size(337, 2);
            panel1.TabIndex = 10;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Rockwell", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailLabel.ForeColor = Color.FromArgb(39, 55, 77);
            emailLabel.Location = new Point(785, 120);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(95, 31);
            emailLabel.TabIndex = 8;
            emailLabel.Text = "Email:";
            // 
            // StudentNameInput
            // 
            StudentNameInput.BorderStyle = BorderStyle.None;
            StudentNameInput.Font = new Font("Rockwell Condensed", 16F);
            StudentNameInput.ForeColor = Color.FromArgb(38, 80, 115);
            StudentNameInput.Location = new Point(135, 166);
            StudentNameInput.Name = "StudentNameInput";
            StudentNameInput.Size = new Size(335, 32);
            StudentNameInput.TabIndex = 2;
            // 
            // namePanel
            // 
            namePanel.BackColor = SystemColors.Window;
            namePanel.BorderStyle = BorderStyle.FixedSingle;
            namePanel.Location = new Point(135, 200);
            namePanel.Name = "namePanel";
            namePanel.Size = new Size(337, 2);
            namePanel.TabIndex = 7;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Rockwell", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameLabel.ForeColor = Color.FromArgb(39, 55, 77);
            nameLabel.Location = new Point(137, 120);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(97, 31);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Name:";
            // 
            // addStudentHeading
            // 
            addStudentHeading.AutoSize = true;
            addStudentHeading.Font = new Font("Rockwell", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addStudentHeading.ForeColor = Color.FromArgb(39, 55, 77);
            addStudentHeading.Location = new Point(5, 5);
            addStudentHeading.Name = "addStudentHeading";
            addStudentHeading.Size = new Size(186, 35);
            addStudentHeading.TabIndex = 0;
            addStudentHeading.Text = "Add Student";
            // 
            // searchStudent
            // 
            searchStudent.Font = new Font("Rockwell", 16.2F);
            searchStudent.ForeColor = Color.FromArgb(39, 55, 77);
            searchStudent.Location = new Point(4, 4);
            searchStudent.Name = "searchStudent";
            searchStudent.Padding = new Padding(3);
            searchStudent.Size = new Size(1269, 515);
            searchStudent.TabIndex = 1;
            searchStudent.Text = "search student";
            searchStudent.UseVisualStyleBackColor = true;
            // 
            // updateAndDeleteStudent
            // 
            updateAndDeleteStudent.BackColor = Color.Transparent;
            updateAndDeleteStudent.Font = new Font("Rockwell", 16.2F);
            updateAndDeleteStudent.ForeColor = Color.FromArgb(39, 55, 77);
            updateAndDeleteStudent.Location = new Point(4, 4);
            updateAndDeleteStudent.Name = "updateAndDeleteStudent";
            updateAndDeleteStudent.Size = new Size(1269, 515);
            updateAndDeleteStudent.TabIndex = 2;
            updateAndDeleteStudent.Text = "update and delete student";
            // 
            // UserControlAddStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabAddStudent);
            Name = "UserControlAddStudent";
            Size = new Size(1277, 548);
            tabAddStudent.ResumeLayout(false);
            addStudentTabPage.ResumeLayout(false);
            addStudentTabPage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabAddStudent;
        private TabPage addStudentTabPage;
        private TabPage searchStudent;
        private Label addStudentHeading;
        private Label nameLabel;
        private TextBox StudentNameInput;
        private Panel namePanel;
        private TextBox passwordInput;
        private Panel panel2;
        private Label passwordLabel;
        private Panel panel3;
        private Label trackLabel;
        private TextBox emailInput;
        private Panel panel1;
        private Label emailLabel;
        private Button addStudentBtn;
        private ComboBox trackComboBox;
        private TabPage updateAndDeleteStudent;
        private Label errorMsg;
    }
}
