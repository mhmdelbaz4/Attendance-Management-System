namespace Attendance_Management_System.UserControls
{
    partial class AdminTeacherCRUD
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
            AdminTeacherCRUDTab = new TabControl();
            AddTeacher = new TabPage();
            TeacherRegisterLabel = new Label();
            nametextBox = new TextBox();
            namelbl = new Label();
            passwordlabel = new Label();
            passwordTextBox = new TextBox();
            Emaillabel = new Label();
            EmailtextBox = new TextBox();
            MobileNomaskedTextBox = new MaskedTextBox();
            Mobilelabel = new Label();
            SalarytextBox = new TextBox();
            Salarylabel = new Label();
            BDlabel = new Label();
            BirthDateDateTimePicker = new DateTimePicker();
            HDlabel = new Label();
            birthDateTimePicker = new DateTimePicker();
            submitBtn = new Button();
            validationLabel = new Label();
            tabPage1 = new TabPage();
            AdminTeacherCRUDTab.SuspendLayout();
            AddTeacher.SuspendLayout();
            SuspendLayout();
            // 
            // AdminTeacherCRUDTab
            // 
            AdminTeacherCRUDTab.Alignment = TabAlignment.Bottom;
            AdminTeacherCRUDTab.Anchor = AnchorStyles.None;
            AdminTeacherCRUDTab.Controls.Add(AddTeacher);
            AdminTeacherCRUDTab.Controls.Add(tabPage1);
            AdminTeacherCRUDTab.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AdminTeacherCRUDTab.Location = new Point(0, 0);
            AdminTeacherCRUDTab.Name = "AdminTeacherCRUDTab";
            AdminTeacherCRUDTab.SelectedIndex = 0;
            AdminTeacherCRUDTab.Size = new Size(942, 501);
            AdminTeacherCRUDTab.TabIndex = 1;
            // 
            // AddTeacher
            // 
            AddTeacher.BackColor = Color.White;
            AddTeacher.Controls.Add(validationLabel);
            AddTeacher.Controls.Add(submitBtn);
            AddTeacher.Controls.Add(birthDateTimePicker);
            AddTeacher.Controls.Add(HDlabel);
            AddTeacher.Controls.Add(BirthDateDateTimePicker);
            AddTeacher.Controls.Add(BDlabel);
            AddTeacher.Controls.Add(Salarylabel);
            AddTeacher.Controls.Add(SalarytextBox);
            AddTeacher.Controls.Add(Mobilelabel);
            AddTeacher.Controls.Add(MobileNomaskedTextBox);
            AddTeacher.Controls.Add(EmailtextBox);
            AddTeacher.Controls.Add(Emaillabel);
            AddTeacher.Controls.Add(passwordTextBox);
            AddTeacher.Controls.Add(passwordlabel);
            AddTeacher.Controls.Add(nametextBox);
            AddTeacher.Controls.Add(namelbl);
            AddTeacher.Controls.Add(TeacherRegisterLabel);
            AddTeacher.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddTeacher.Location = new Point(4, 4);
            AddTeacher.Name = "AddTeacher";
            AddTeacher.Padding = new Padding(3);
            AddTeacher.Size = new Size(934, 465);
            AddTeacher.TabIndex = 0;
            AddTeacher.Text = "Add Teacher";
            // 
            // TeacherRegisterLabel
            // 
            TeacherRegisterLabel.AutoSize = true;
            TeacherRegisterLabel.Font = new Font("Rockwell", 13.8F, FontStyle.Bold);
            TeacherRegisterLabel.ForeColor = Color.FromArgb(39, 55, 77);
            TeacherRegisterLabel.Location = new Point(3, 3);
            TeacherRegisterLabel.Name = "TeacherRegisterLabel";
            TeacherRegisterLabel.Size = new Size(205, 28);
            TeacherRegisterLabel.TabIndex = 0;
            TeacherRegisterLabel.Text = "Teacher Register";
            // 
            // nametextBox
            // 
            nametextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nametextBox.BackColor = Color.White;
            nametextBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nametextBox.ForeColor = Color.White;
            nametextBox.Location = new Point(135, 100);
            nametextBox.MaxLength = 50;
            nametextBox.Name = "nametextBox";
            nametextBox.PlaceholderText = "omar";
            nametextBox.Size = new Size(270, 32);
            nametextBox.TabIndex = 2;
            // 
            // namelbl
            // 
            namelbl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            namelbl.BackColor = Color.White;
            namelbl.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            namelbl.ForeColor = Color.Black;
            namelbl.Location = new Point(133, 60);
            namelbl.Name = "namelbl";
            namelbl.Size = new Size(75, 40);
            namelbl.TabIndex = 3;
            namelbl.Text = "Name";
            // 
            // passwordlabel
            // 
            passwordlabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            passwordlabel.BackColor = Color.White;
            passwordlabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordlabel.ForeColor = Color.Black;
            passwordlabel.Location = new Point(135, 243);
            passwordlabel.Name = "passwordlabel";
            passwordlabel.Size = new Size(184, 29);
            passwordlabel.TabIndex = 5;
            passwordlabel.Text = "Password";
            passwordlabel.Click += label2_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            passwordTextBox.BackColor = Color.White;
            passwordTextBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTextBox.ForeColor = Color.White;
            passwordTextBox.Location = new Point(133, 284);
            passwordTextBox.MaxLength = 50;
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PlaceholderText = "xxxxxxxx";
            passwordTextBox.Size = new Size(270, 32);
            passwordTextBox.TabIndex = 6;
            passwordTextBox.TextChanged += passwordTextBox_TextChanged;
            // 
            // Emaillabel
            // 
            Emaillabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Emaillabel.BackColor = Color.White;
            Emaillabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Emaillabel.ForeColor = Color.Black;
            Emaillabel.Location = new Point(135, 147);
            Emaillabel.Name = "Emaillabel";
            Emaillabel.Size = new Size(75, 40);
            Emaillabel.TabIndex = 7;
            Emaillabel.Text = "Email";
            // 
            // EmailtextBox
            // 
            EmailtextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            EmailtextBox.BackColor = Color.White;
            EmailtextBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmailtextBox.ForeColor = Color.White;
            EmailtextBox.Location = new Point(135, 190);
            EmailtextBox.MaxLength = 50;
            EmailtextBox.Name = "EmailtextBox";
            EmailtextBox.PlaceholderText = "omar@gmail.com";
            EmailtextBox.Size = new Size(270, 32);
            EmailtextBox.TabIndex = 8;
            EmailtextBox.TextChanged += textBox2_TextChanged;
            // 
            // MobileNomaskedTextBox
            // 
            MobileNomaskedTextBox.BackColor = Color.White;
            MobileNomaskedTextBox.ForeColor = Color.DarkGray;
            MobileNomaskedTextBox.Location = new Point(534, 102);
            MobileNomaskedTextBox.Mask = "000 000000000";
            MobileNomaskedTextBox.Name = "MobileNomaskedTextBox";
            MobileNomaskedTextBox.Size = new Size(270, 32);
            MobileNomaskedTextBox.TabIndex = 9;
            MobileNomaskedTextBox.Text = "000000000000";
            MobileNomaskedTextBox.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // Mobilelabel
            // 
            Mobilelabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Mobilelabel.BackColor = Color.White;
            Mobilelabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Mobilelabel.ForeColor = Color.Black;
            Mobilelabel.Location = new Point(534, 60);
            Mobilelabel.Name = "Mobilelabel";
            Mobilelabel.Size = new Size(184, 29);
            Mobilelabel.TabIndex = 10;
            Mobilelabel.Text = "Mobile No";
            // 
            // SalarytextBox
            // 
            SalarytextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SalarytextBox.BackColor = Color.White;
            SalarytextBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SalarytextBox.ForeColor = Color.White;
            SalarytextBox.Location = new Point(534, 379);
            SalarytextBox.MaxLength = 6;
            SalarytextBox.Name = "SalarytextBox";
            SalarytextBox.Size = new Size(270, 32);
            SalarytextBox.TabIndex = 11;
            // 
            // Salarylabel
            // 
            Salarylabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Salarylabel.BackColor = Color.White;
            Salarylabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Salarylabel.ForeColor = Color.Black;
            Salarylabel.Location = new Point(534, 336);
            Salarylabel.Name = "Salarylabel";
            Salarylabel.Size = new Size(75, 40);
            Salarylabel.TabIndex = 12;
            Salarylabel.Text = "Salary";
            // 
            // BDlabel
            // 
            BDlabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BDlabel.BackColor = Color.White;
            BDlabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BDlabel.ForeColor = Color.Black;
            BDlabel.Location = new Point(534, 147);
            BDlabel.Name = "BDlabel";
            BDlabel.Size = new Size(139, 40);
            BDlabel.TabIndex = 13;
            BDlabel.Text = "BirthDate";
            // 
            // BirthDateDateTimePicker
            // 
            BirthDateDateTimePicker.CalendarMonthBackground = Color.White;
            BirthDateDateTimePicker.CalendarTitleBackColor = Color.DarkGray;
            BirthDateDateTimePicker.CalendarTrailingForeColor = Color.DarkGray;
            BirthDateDateTimePicker.Format = DateTimePickerFormat.Short;
            BirthDateDateTimePicker.Location = new Point(534, 190);
            BirthDateDateTimePicker.MaxDate = new DateTime(2024, 2, 22, 0, 0, 0, 0);
            BirthDateDateTimePicker.MinDate = new DateTime(1950, 1, 1, 0, 0, 0, 0);
            BirthDateDateTimePicker.Name = "BirthDateDateTimePicker";
            BirthDateDateTimePicker.Size = new Size(270, 32);
            BirthDateDateTimePicker.TabIndex = 15;
            BirthDateDateTimePicker.Value = new DateTime(2024, 2, 22, 0, 0, 0, 0);
            // 
            // HDlabel
            // 
            HDlabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            HDlabel.BackColor = Color.White;
            HDlabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HDlabel.ForeColor = Color.Black;
            HDlabel.Location = new Point(534, 243);
            HDlabel.Name = "HDlabel";
            HDlabel.Size = new Size(139, 40);
            HDlabel.TabIndex = 16;
            HDlabel.Text = "Hiring Date";
            // 
            // birthDateTimePicker
            // 
            birthDateTimePicker.CalendarMonthBackground = Color.White;
            birthDateTimePicker.CalendarTitleBackColor = Color.DarkGray;
            birthDateTimePicker.CalendarTrailingForeColor = Color.DarkGray;
            birthDateTimePicker.Format = DateTimePickerFormat.Short;
            birthDateTimePicker.Location = new Point(534, 284);
            birthDateTimePicker.MaxDate = new DateTime(2024, 2, 22, 0, 0, 0, 0);
            birthDateTimePicker.MinDate = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            birthDateTimePicker.Name = "birthDateTimePicker";
            birthDateTimePicker.Size = new Size(270, 32);
            birthDateTimePicker.TabIndex = 17;
            birthDateTimePicker.Value = new DateTime(2024, 2, 22, 0, 0, 0, 0);
            // 
            // submitBtn
            // 
            submitBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            submitBtn.BackColor = Color.FromArgb(39, 55, 77);
            submitBtn.FlatAppearance.BorderSize = 0;
            submitBtn.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            submitBtn.ForeColor = Color.White;
            submitBtn.Location = new Point(135, 390);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(106, 50);
            submitBtn.TabIndex = 18;
            submitBtn.Text = "Submit";
            submitBtn.TextAlign = ContentAlignment.MiddleLeft;
            submitBtn.UseVisualStyleBackColor = false;
            // 
            // validationLabel
            // 
            validationLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            validationLabel.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            validationLabel.ForeColor = Color.Red;
            validationLabel.Location = new Point(133, 353);
            validationLabel.Name = "validationLabel";
            validationLabel.Size = new Size(372, 23);
            validationLabel.TabIndex = 19;
            validationLabel.Text = "msg";
            validationLabel.Visible = false;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(934, 465);
            tabPage1.TabIndex = 1;
            tabPage1.Text = "Get Teacher";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // AdminTeacherCRUD
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(AdminTeacherCRUDTab);
            Font = new Font("Century Gothic", 12F);
            Margin = new Padding(6, 5, 6, 5);
            Name = "AdminTeacherCRUD";
            Size = new Size(942, 501);
            AdminTeacherCRUDTab.ResumeLayout(false);
            AddTeacher.ResumeLayout(false);
            AddTeacher.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl AdminTeacherCRUDTab;
        private TabPage AddTeacher;
        private Label TeacherRegisterLabel;
        private TextBox nametextBox;
        private Label namelbl;
        private Label passwordlabel;
        private TextBox passwordTextBox;
        private TextBox EmailtextBox;
        private Label Emaillabel;
        private MaskedTextBox MobileNomaskedTextBox;
        private Label Mobilelabel;
        private Label Salarylabel;
        private TextBox SalarytextBox;
        private Label BDlabel;
        private DateTimePicker BirthDateDateTimePicker;
        private DateTimePicker birthDateTimePicker;
        private Label HDlabel;
        private Button submitBtn;
        private Label validationLabel;
        private TabPage tabPage1;
    }
}
