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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminTeacherCRUD));
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
            getSudentTab = new TabPage();
            pictureBox1 = new PictureBox();
            dataGridTeachers = new DataGridView();
            IdCol = new DataGridViewTextBoxColumn();
            NameCol = new DataGridViewTextBoxColumn();
            EmailCol = new DataGridViewTextBoxColumn();
            MobileCol = new DataGridViewTextBoxColumn();
            optionsCol = new DataGridViewTextBoxColumn();
            searchByComboBox = new ComboBox();
            SearchtextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            teacherSearchLbl = new Label();
            AdminTeacherCRUDTab.SuspendLayout();
            AddTeacher.SuspendLayout();
            getSudentTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridTeachers).BeginInit();
            SuspendLayout();
            // 
            // AdminTeacherCRUDTab
            // 
            AdminTeacherCRUDTab.Alignment = TabAlignment.Bottom;
            AdminTeacherCRUDTab.Controls.Add(AddTeacher);
            AdminTeacherCRUDTab.Controls.Add(getSudentTab);
            AdminTeacherCRUDTab.Dock = DockStyle.Fill;
            AdminTeacherCRUDTab.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AdminTeacherCRUDTab.Location = new Point(0, 0);
            AdminTeacherCRUDTab.Name = "AdminTeacherCRUDTab";
            AdminTeacherCRUDTab.SelectedIndex = 0;
            AdminTeacherCRUDTab.Size = new Size(1288, 740);
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
            AddTeacher.Size = new Size(1280, 704);
            AddTeacher.TabIndex = 0;
            AddTeacher.Text = "Add Teacher";
            // 
            // validationLabel
            // 
            validationLabel.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            validationLabel.ForeColor = Color.Red;
            validationLabel.Location = new Point(735, 402);
            validationLabel.Name = "validationLabel";
            validationLabel.Size = new Size(300, 110);
            validationLabel.TabIndex = 19;
            validationLabel.Text = "msg";
            validationLabel.Visible = false;
            // 
            // SaveBtn
            // 
            SaveBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SaveBtn.BackColor = Color.FromArgb(39, 55, 77);
            SaveBtn.FlatAppearance.BorderSize = 0;
            SaveBtn.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveBtn.ForeColor = Color.White;
            SaveBtn.Location = new Point(141, 598);
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
            HiringDateDateTimePicker.Location = new Point(735, 339);
            HiringDateDateTimePicker.MaxDate = new DateTime(2024, 2, 22, 0, 0, 0, 0);
            HiringDateDateTimePicker.MinDate = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            HiringDateDateTimePicker.Name = "HiringDateDateTimePicker";
            HiringDateDateTimePicker.Size = new Size(300, 32);
            HiringDateDateTimePicker.TabIndex = 6;
            HiringDateDateTimePicker.Value = new DateTime(2024, 2, 22, 0, 0, 0, 0);
            // 
            // HDlabel
            // 
            HDlabel.BackColor = Color.White;
            HDlabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HDlabel.ForeColor = Color.Black;
            HDlabel.Location = new Point(735, 291);
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
            BirthDateDateTimePicker.Location = new Point(735, 229);
            BirthDateDateTimePicker.MaxDate = new DateTime(2024, 2, 22, 0, 0, 0, 0);
            BirthDateDateTimePicker.MinDate = new DateTime(1950, 1, 1, 0, 0, 0, 0);
            BirthDateDateTimePicker.Name = "BirthDateDateTimePicker";
            BirthDateDateTimePicker.Size = new Size(300, 32);
            BirthDateDateTimePicker.TabIndex = 5;
            BirthDateDateTimePicker.Value = new DateTime(2024, 2, 22, 0, 0, 0, 0);
            // 
            // BDlabel
            // 
            BDlabel.BackColor = Color.White;
            BDlabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BDlabel.ForeColor = Color.Black;
            BDlabel.Location = new Point(735, 186);
            BDlabel.Name = "BDlabel";
            BDlabel.Size = new Size(139, 40);
            BDlabel.TabIndex = 13;
            BDlabel.Text = "BirthDate";
            // 
            // Salarylabel
            // 
            Salarylabel.BackColor = Color.White;
            Salarylabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Salarylabel.ForeColor = Color.Black;
            Salarylabel.Location = new Point(141, 396);
            Salarylabel.Name = "Salarylabel";
            Salarylabel.Size = new Size(75, 40);
            Salarylabel.TabIndex = 12;
            Salarylabel.Text = "Salary";
            // 
            // SalarytextBox
            // 
            SalarytextBox.BackColor = Color.White;
            SalarytextBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SalarytextBox.ForeColor = Color.Black;
            SalarytextBox.Location = new Point(141, 439);
            SalarytextBox.MaxLength = 6;
            SalarytextBox.Name = "SalarytextBox";
            SalarytextBox.Size = new Size(270, 32);
            SalarytextBox.TabIndex = 7;
            // 
            // Mobilelabel
            // 
            Mobilelabel.BackColor = Color.White;
            Mobilelabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Mobilelabel.ForeColor = Color.Black;
            Mobilelabel.Location = new Point(735, 95);
            Mobilelabel.Name = "Mobilelabel";
            Mobilelabel.Size = new Size(184, 29);
            Mobilelabel.TabIndex = 10;
            Mobilelabel.Text = "Mobile No";
            // 
            // MobileNomaskedTextBox
            // 
            MobileNomaskedTextBox.BackColor = Color.White;
            MobileNomaskedTextBox.ForeColor = Color.Black;
            MobileNomaskedTextBox.Location = new Point(735, 138);
            MobileNomaskedTextBox.Name = "MobileNomaskedTextBox";
            MobileNomaskedTextBox.Size = new Size(300, 32);
            MobileNomaskedTextBox.TabIndex = 4;
            // 
            // EmailtextBox
            // 
            EmailtextBox.BackColor = Color.White;
            EmailtextBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmailtextBox.ForeColor = Color.Black;
            EmailtextBox.Location = new Point(141, 229);
            EmailtextBox.MaxLength = 50;
            EmailtextBox.Name = "EmailtextBox";
            EmailtextBox.PlaceholderText = "omar@gmail.com";
            EmailtextBox.Size = new Size(300, 32);
            EmailtextBox.TabIndex = 2;
            // 
            // Emaillabel
            // 
            Emaillabel.BackColor = Color.White;
            Emaillabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Emaillabel.ForeColor = Color.Black;
            Emaillabel.Location = new Point(141, 186);
            Emaillabel.Name = "Emaillabel";
            Emaillabel.Size = new Size(75, 40);
            Emaillabel.TabIndex = 7;
            Emaillabel.Text = "Email";
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = Color.White;
            passwordTextBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTextBox.ForeColor = Color.Black;
            passwordTextBox.Location = new Point(141, 339);
            passwordTextBox.MaxLength = 50;
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PlaceholderText = "xxxxxxxx";
            passwordTextBox.Size = new Size(270, 32);
            passwordTextBox.TabIndex = 3;
            // 
            // passwordlabel
            // 
            passwordlabel.BackColor = Color.White;
            passwordlabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordlabel.ForeColor = Color.Black;
            passwordlabel.Location = new Point(141, 291);
            passwordlabel.Name = "passwordlabel";
            passwordlabel.Size = new Size(184, 29);
            passwordlabel.TabIndex = 5;
            passwordlabel.Text = "Password";
            // 
            // nametextBox
            // 
            nametextBox.BackColor = SystemColors.Window;
            nametextBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nametextBox.ForeColor = Color.Black;
            nametextBox.Location = new Point(141, 138);
            nametextBox.MaxLength = 30;
            nametextBox.Name = "nametextBox";
            nametextBox.PlaceholderText = "omar";
            nametextBox.Size = new Size(300, 32);
            nametextBox.TabIndex = 1;
            // 
            // namelbl
            // 
            namelbl.BackColor = Color.White;
            namelbl.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            namelbl.ForeColor = Color.Black;
            namelbl.Location = new Point(141, 95);
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
            // getSudentTab
            // 
            getSudentTab.Controls.Add(pictureBox1);
            getSudentTab.Controls.Add(dataGridTeachers);
            getSudentTab.Controls.Add(searchByComboBox);
            getSudentTab.Controls.Add(SearchtextBox);
            getSudentTab.Controls.Add(label2);
            getSudentTab.Controls.Add(label1);
            getSudentTab.Controls.Add(teacherSearchLbl);
            getSudentTab.Location = new Point(4, 4);
            getSudentTab.Name = "getSudentTab";
            getSudentTab.Padding = new Padding(3);
            getSudentTab.Size = new Size(1280, 704);
            getSudentTab.TabIndex = 1;
            getSudentTab.Text = "Get Teacher";
            getSudentTab.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(569, 83);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            pictureBox1.Click += search;
            // 
            // dataGridTeachers
            // 
            dataGridTeachers.AllowUserToAddRows = false;
            dataGridTeachers.AllowUserToDeleteRows = false;
            dataGridTeachers.AllowUserToResizeColumns = false;
            dataGridTeachers.AllowUserToResizeRows = false;
            dataGridTeachers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dataGridTeachers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridTeachers.BackgroundColor = Color.White;
            dataGridTeachers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridTeachers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridTeachers.Columns.AddRange(new DataGridViewColumn[] { IdCol, NameCol, EmailCol, MobileCol, optionsCol });
            dataGridTeachers.Location = new Point(6, 189);
            dataGridTeachers.Name = "dataGridTeachers";
            dataGridTeachers.ReadOnly = true;
            dataGridTeachers.RowHeadersWidth = 51;
            dataGridTeachers.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridTeachers.ShowCellErrors = false;
            dataGridTeachers.ShowEditingIcon = false;
            dataGridTeachers.ShowRowErrors = false;
            dataGridTeachers.Size = new Size(1257, 455);
            dataGridTeachers.TabIndex = 6;
            // 
            // IdCol
            // 
            IdCol.FillWeight = 91.57755F;
            IdCol.HeaderText = "Id";
            IdCol.MinimumWidth = 6;
            IdCol.Name = "IdCol";
            IdCol.ReadOnly = true;
            // 
            // NameCol
            // 
            NameCol.FillWeight = 91.57755F;
            NameCol.HeaderText = "Name";
            NameCol.MinimumWidth = 6;
            NameCol.Name = "NameCol";
            NameCol.ReadOnly = true;
            // 
            // EmailCol
            // 
            EmailCol.FillWeight = 91.57755F;
            EmailCol.HeaderText = "Email";
            EmailCol.MinimumWidth = 6;
            EmailCol.Name = "EmailCol";
            EmailCol.ReadOnly = true;
            // 
            // MobileCol
            // 
            MobileCol.FillWeight = 91.57755F;
            MobileCol.HeaderText = "Mobile";
            MobileCol.MinimumWidth = 6;
            MobileCol.Name = "MobileCol";
            MobileCol.ReadOnly = true;
            // 
            // optionsCol
            // 
            optionsCol.FillWeight = 20F;
            optionsCol.HeaderText = "";
            optionsCol.MaxInputLength = 50;
            optionsCol.MinimumWidth = 6;
            optionsCol.Name = "optionsCol";
            optionsCol.ReadOnly = true;
            // 
            // searchByComboBox
            // 
            searchByComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchByComboBox.AutoCompleteCustomSource.AddRange(new string[] { "Id", "Name", "Email" });
            searchByComboBox.FormattingEnabled = true;
            searchByComboBox.Items.AddRange(new object[] { "Id", "Name", "Email", "Track" });
            searchByComboBox.Location = new Point(807, 83);
            searchByComboBox.Name = "searchByComboBox";
            searchByComboBox.Size = new Size(173, 31);
            searchByComboBox.TabIndex = 5;
            searchByComboBox.SelectedValueChanged += search;
            // 
            // SearchtextBox
            // 
            SearchtextBox.ForeColor = Color.FromArgb(39, 55, 77);
            SearchtextBox.Location = new Point(329, 83);
            SearchtextBox.MaxLength = 50;
            SearchtextBox.Name = "SearchtextBox";
            SearchtextBox.Size = new Size(234, 32);
            SearchtextBox.TabIndex = 4;
            SearchtextBox.TextChanged += search;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 13.8F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(39, 55, 77);
            label2.Location = new Point(807, 37);
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
            label1.Location = new Point(329, 37);
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
            Size = new Size(1288, 740);
            Load += AdminTeacherCRUD_Load;
            AdminTeacherCRUDTab.ResumeLayout(false);
            AddTeacher.ResumeLayout(false);
            AddTeacher.PerformLayout();
            getSudentTab.ResumeLayout(false);
            getSudentTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridTeachers).EndInit();
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
        private TabPage getSudentTab;
        private Label label2;
        private Label label1;
        private Label teacherSearchLbl;
        private ComboBox searchByComboBox;
        private TextBox SearchtextBox;
        private DataGridView dataGridTeachers;
        private DataGridViewTextBoxColumn IdCol;
        private DataGridViewTextBoxColumn NameCol;
        private DataGridViewTextBoxColumn EmailCol;
        private DataGridViewTextBoxColumn MobileCol;
        private DataGridViewTextBoxColumn optionsCol;
        private PictureBox pictureBox1;
    }
}
