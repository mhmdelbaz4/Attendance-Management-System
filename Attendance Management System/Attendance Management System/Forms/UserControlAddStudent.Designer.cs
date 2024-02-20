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
            textBox2 = new TextBox();
            panel2 = new Panel();
            studentPasswordInput = new Label();
            panel3 = new Panel();
            studentTrackInput = new Label();
            textBox1 = new TextBox();
            panel1 = new Panel();
            StudentEmailInput = new Label();
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
            addStudentTabPage.Controls.Add(textBox2);
            addStudentTabPage.Controls.Add(panel2);
            addStudentTabPage.Controls.Add(studentPasswordInput);
            addStudentTabPage.Controls.Add(panel3);
            addStudentTabPage.Controls.Add(studentTrackInput);
            addStudentTabPage.Controls.Add(textBox1);
            addStudentTabPage.Controls.Add(panel1);
            addStudentTabPage.Controls.Add(StudentEmailInput);
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
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Rockwell Condensed", 16F);
            textBox2.ForeColor = Color.FromArgb(38, 80, 115);
            textBox2.Location = new Point(790, 263);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(335, 32);
            textBox2.TabIndex = 15;
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
            // studentPasswordInput
            // 
            studentPasswordInput.AutoSize = true;
            studentPasswordInput.Font = new Font("Rockwell", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            studentPasswordInput.ForeColor = Color.FromArgb(39, 55, 77);
            studentPasswordInput.Location = new Point(792, 217);
            studentPasswordInput.Name = "studentPasswordInput";
            studentPasswordInput.Size = new Size(147, 31);
            studentPasswordInput.TabIndex = 14;
            studentPasswordInput.Text = "Password:";
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
            // studentTrackInput
            // 
            studentTrackInput.AutoSize = true;
            studentTrackInput.Font = new Font("Rockwell", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            studentTrackInput.ForeColor = Color.FromArgb(39, 55, 77);
            studentTrackInput.Location = new Point(144, 217);
            studentTrackInput.Name = "studentTrackInput";
            studentTrackInput.Size = new Size(96, 31);
            studentTrackInput.TabIndex = 11;
            studentTrackInput.Text = "Track:";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Rockwell Condensed", 16F);
            textBox1.ForeColor = Color.FromArgb(38, 80, 115);
            textBox1.Location = new Point(783, 166);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(335, 32);
            textBox1.TabIndex = 9;
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
            // StudentEmailInput
            // 
            StudentEmailInput.AutoSize = true;
            StudentEmailInput.Font = new Font("Rockwell", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StudentEmailInput.ForeColor = Color.FromArgb(39, 55, 77);
            StudentEmailInput.Location = new Point(785, 120);
            StudentEmailInput.Name = "StudentEmailInput";
            StudentEmailInput.Size = new Size(95, 31);
            StudentEmailInput.TabIndex = 8;
            StudentEmailInput.Text = "Email:";
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
        private TextBox textBox2;
        private Panel panel2;
        private Label studentPasswordInput;
        private Panel panel3;
        private Label studentTrackInput;
        private TextBox textBox1;
        private Panel panel1;
        private Label StudentEmailInput;
        private Button addStudentBtn;
        private ComboBox trackComboBox;
        private TabPage updateAndDeleteStudent;
        private Label errorMsg;
    }
}
