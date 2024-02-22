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
            validationLabel = new Label();
            SaveBtn = new Button();
            HiringDateDateTimePicker = new DateTimePicker();
            HDlabel = new Label();
            BirthDateDateTimePicker = new DateTimePicker();
            BDlabel = new Label();
            Salarylabel = new Label();
            SalarytextBox = new TextBox();
            Mobilelabel = new Label();
            MobileNomaskedTextBox = new MaskedTextBox();
            EmailtextBox = new TextBox();
            Emaillabel = new Label();
            passwordTextBox = new TextBox();
            passwordlabel = new Label();
            nametextBox = new TextBox();
            namelbl = new Label();
            TeacherRegisterLabel = new Label();
            tabPage1 = new TabPage();
            adminSearchTeacherGV = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            NameCol = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            HiringDate = new DataGridViewTextBoxColumn();
            MobileNo = new DataGridViewTextBoxColumn();
            CRUDoptions = new DataGridViewTextBoxColumn();
            comboBox1 = new ComboBox();
            SearchtextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            teacherSearchLbl = new Label();
            AdminTeacherCRUDTab.SuspendLayout();
            AddTeacher.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)adminSearchTeacherGV).BeginInit();
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
            AddTeacher.Controls.Add(SaveBtn);
            AddTeacher.Controls.Add(HiringDateDateTimePicker);
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
            // SaveBtn
            // 
            SaveBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SaveBtn.BackColor = Color.FromArgb(39, 55, 77);
            SaveBtn.FlatAppearance.BorderSize = 0;
            SaveBtn.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveBtn.ForeColor = Color.White;
            SaveBtn.Location = new Point(135, 390);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(106, 50);
            SaveBtn.TabIndex = 8;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += submitBtn_Click;
            // 
            // HiringDateDateTimePicker
            // 
            HiringDateDateTimePicker.CalendarMonthBackground = Color.White;
            HiringDateDateTimePicker.CalendarTitleBackColor = Color.DarkGray;
            HiringDateDateTimePicker.CalendarTrailingForeColor = Color.DarkGray;
            HiringDateDateTimePicker.Format = DateTimePickerFormat.Short;
            HiringDateDateTimePicker.Location = new Point(534, 284);
            HiringDateDateTimePicker.MaxDate = new DateTime(2024, 2, 22, 0, 0, 0, 0);
            HiringDateDateTimePicker.MinDate = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            HiringDateDateTimePicker.Name = "HiringDateDateTimePicker";
            HiringDateDateTimePicker.Size = new Size(270, 32);
            HiringDateDateTimePicker.TabIndex = 6;
            HiringDateDateTimePicker.Value = new DateTime(2024, 2, 22, 0, 0, 0, 0);
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
            BirthDateDateTimePicker.TabIndex = 5;
            BirthDateDateTimePicker.Value = new DateTime(2024, 2, 22, 0, 0, 0, 0);
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
            // SalarytextBox
            // 
            SalarytextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SalarytextBox.BackColor = Color.White;
            SalarytextBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SalarytextBox.ForeColor = Color.Black;
            SalarytextBox.Location = new Point(534, 379);
            SalarytextBox.MaxLength = 6;
            SalarytextBox.Name = "SalarytextBox";
            SalarytextBox.Size = new Size(270, 32);
            SalarytextBox.TabIndex = 7;
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
            // MobileNomaskedTextBox
            // 
            MobileNomaskedTextBox.BackColor = Color.White;
            MobileNomaskedTextBox.ForeColor = Color.Black;
            MobileNomaskedTextBox.Location = new Point(534, 102);
            MobileNomaskedTextBox.Mask = "000 000000000";
            MobileNomaskedTextBox.Name = "MobileNomaskedTextBox";
            MobileNomaskedTextBox.Size = new Size(270, 32);
            MobileNomaskedTextBox.TabIndex = 4;
            MobileNomaskedTextBox.Text = "000000000000";
            MobileNomaskedTextBox.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // EmailtextBox
            // 
            EmailtextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            EmailtextBox.BackColor = Color.White;
            EmailtextBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmailtextBox.ForeColor = Color.Black;
            EmailtextBox.Location = new Point(135, 190);
            EmailtextBox.MaxLength = 50;
            EmailtextBox.Name = "EmailtextBox";
            EmailtextBox.PlaceholderText = "omar@gmail.com";
            EmailtextBox.Size = new Size(270, 32);
            EmailtextBox.TabIndex = 2;
            EmailtextBox.TextChanged += textBox2_TextChanged;
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
            // passwordTextBox
            // 
            passwordTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            passwordTextBox.BackColor = Color.White;
            passwordTextBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTextBox.ForeColor = Color.Black;
            passwordTextBox.Location = new Point(133, 284);
            passwordTextBox.MaxLength = 50;
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PlaceholderText = "xxxxxxxx";
            passwordTextBox.Size = new Size(270, 32);
            passwordTextBox.TabIndex = 3;
            passwordTextBox.TextChanged += passwordTextBox_TextChanged;
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
            // nametextBox
            // 
            nametextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nametextBox.BackColor = SystemColors.Window;
            nametextBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nametextBox.ForeColor = Color.Black;
            nametextBox.Location = new Point(135, 100);
            nametextBox.MaxLength = 30;
            nametextBox.Name = "nametextBox";
            nametextBox.PlaceholderText = "omar";
            nametextBox.Size = new Size(270, 32);
            nametextBox.TabIndex = 1;
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
            // tabPage1
            // 
            tabPage1.Controls.Add(adminSearchTeacherGV);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(SearchtextBox);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(teacherSearchLbl);
            tabPage1.Location = new Point(4, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(934, 465);
            tabPage1.TabIndex = 1;
            tabPage1.Text = "Get Teacher";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // adminSearchTeacherGV
            // 
            adminSearchTeacherGV.BackgroundColor = Color.White;
            adminSearchTeacherGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            adminSearchTeacherGV.Columns.AddRange(new DataGridViewColumn[] { ID, NameCol, Email, HiringDate, MobileNo, CRUDoptions });
            adminSearchTeacherGV.Location = new Point(20, 124);
            adminSearchTeacherGV.Name = "adminSearchTeacherGV";
            adminSearchTeacherGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            adminSearchTeacherGV.RowHeadersWidth = 50;
            adminSearchTeacherGV.ScrollBars = ScrollBars.Vertical;
            adminSearchTeacherGV.Size = new Size(893, 335);
            adminSearchTeacherGV.TabIndex = 6;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 125;
            // 
            // NameCol
            // 
            NameCol.HeaderText = "Name";
            NameCol.MinimumWidth = 6;
            NameCol.Name = "NameCol";
            NameCol.Width = 125;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.Width = 200;
            // 
            // HiringDate
            // 
            HiringDate.HeaderText = "HiringDate";
            HiringDate.MinimumWidth = 6;
            HiringDate.Name = "HiringDate";
            HiringDate.Width = 150;
            // 
            // MobileNo
            // 
            MobileNo.HeaderText = "Mobile No.";
            MobileNo.MinimumWidth = 6;
            MobileNo.Name = "MobileNo";
            MobileNo.Width = 150;
            // 
            // CRUDoptions
            // 
            CRUDoptions.HeaderText = "";
            CRUDoptions.MinimumWidth = 6;
            CRUDoptions.Name = "CRUDoptions";
            CRUDoptions.Width = 125;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(542, 87);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(173, 31);
            comboBox1.TabIndex = 5;
            // 
            // SearchtextBox
            // 
            SearchtextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SearchtextBox.ForeColor = Color.FromArgb(39, 55, 77);
            SearchtextBox.Location = new Point(171, 86);
            SearchtextBox.MaxLength = 50;
            SearchtextBox.Name = "SearchtextBox";
            SearchtextBox.Size = new Size(234, 32);
            SearchtextBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 13.8F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(39, 55, 77);
            label2.Location = new Point(542, 44);
            label2.Name = "label2";
            label2.Size = new Size(131, 28);
            label2.TabIndex = 3;
            label2.Text = "Search By:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 13.8F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(39, 55, 77);
            label1.Location = new Point(171, 44);
            label1.Name = "label1";
            label1.Size = new Size(95, 28);
            label1.TabIndex = 2;
            label1.Text = "Search:";
            // 
            // teacherSearchLbl
            // 
            teacherSearchLbl.AutoSize = true;
            teacherSearchLbl.Font = new Font("Rockwell", 13.8F, FontStyle.Bold);
            teacherSearchLbl.ForeColor = Color.FromArgb(39, 55, 77);
            teacherSearchLbl.Location = new Point(0, 0);
            teacherSearchLbl.Name = "teacherSearchLbl";
            teacherSearchLbl.Size = new Size(185, 28);
            teacherSearchLbl.TabIndex = 1;
            teacherSearchLbl.Text = "Teacher Search";
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
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)adminSearchTeacherGV).EndInit();
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
        private DateTimePicker HiringDateDateTimePicker;
        private Label HDlabel;
        private Button SaveBtn;
        private Label validationLabel;
        private TabPage tabPage1;
        private Label label2;
        private Label label1;
        private Label teacherSearchLbl;
        private ComboBox comboBox1;
        private TextBox SearchtextBox;
        private DataGridView adminSearchTeacherGV;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NameCol;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn HiringDate;
        private DataGridViewTextBoxColumn MobileNo;
        private DataGridViewTextBoxColumn CRUDoptions;
    }
}
