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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlAddStudent));
            tabStudent = new TabControl();
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
            pictureBox1 = new PictureBox();
            searchByComboBox = new ComboBox();
            panel5 = new Panel();
            searchBy = new Label();
            searchInput = new TextBox();
            panel4 = new Panel();
            searchLabel = new Label();
            dataGridStudent = new DataGridView();
            IdCol = new DataGridViewTextBoxColumn();
            NameCol = new DataGridViewTextBoxColumn();
            EmailCol = new DataGridViewTextBoxColumn();
            TrackCol = new DataGridViewTextBoxColumn();
            updateAndDeleteStudent = new TabPage();
            deleteBtn = new Button();
            editErrorMsg = new Label();
            updateBtn = new Button();
            TrackEditComboBox = new ComboBox();
            passwordEditInput = new TextBox();
            panel6 = new Panel();
            passwordEditLabel = new Label();
            panel7 = new Panel();
            trackEditLabel = new Label();
            emailEditInputt = new TextBox();
            panel8 = new Panel();
            emailEditLabel = new Label();
            nameEditInput = new TextBox();
            panel9 = new Panel();
            nameEditLabel = new Label();
            tabStudent.SuspendLayout();
            addStudentTabPage.SuspendLayout();
            searchStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridStudent).BeginInit();
            updateAndDeleteStudent.SuspendLayout();
            SuspendLayout();
            // 
            // tabStudent
            // 
            tabStudent.Alignment = TabAlignment.Bottom;
            tabStudent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tabStudent.Controls.Add(addStudentTabPage);
            tabStudent.Controls.Add(searchStudent);
            tabStudent.Controls.Add(updateAndDeleteStudent);
            tabStudent.Location = new Point(0, 18);
            tabStudent.Name = "tabStudent";
            tabStudent.SelectedIndex = 0;
            tabStudent.Size = new Size(1288, 662);
            tabStudent.TabIndex = 0;
            tabStudent.SelectedIndexChanged += handleIndexChange;
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
            addStudentTabPage.Size = new Size(1280, 629);
            addStudentTabPage.TabIndex = 0;
            addStudentTabPage.Text = "add student";
            addStudentTabPage.UseVisualStyleBackColor = true;
            // 
            // errorMsg
            // 
            errorMsg.Anchor = AnchorStyles.Top;
            errorMsg.AutoSize = true;
            errorMsg.BackColor = Color.LightGray;
            errorMsg.Font = new Font("Rockwell", 12F);
            errorMsg.ForeColor = Color.Red;
            errorMsg.Location = new Point(565, 358);
            errorMsg.Name = "errorMsg";
            errorMsg.Size = new Size(151, 22);
            errorMsg.TabIndex = 19;
            errorMsg.Text = "email not found";
            errorMsg.Visible = false;
            // 
            // addStudentBtn
            // 
            addStudentBtn.Anchor = AnchorStyles.Top;
            addStudentBtn.BackColor = Color.FromArgb(39, 55, 77);
            addStudentBtn.FlatAppearance.BorderSize = 0;
            addStudentBtn.FlatStyle = FlatStyle.Flat;
            addStudentBtn.Font = new Font("Rockwell", 16.2F);
            addStudentBtn.ForeColor = Color.AliceBlue;
            addStudentBtn.Location = new Point(527, 426);
            addStudentBtn.Name = "addStudentBtn";
            addStudentBtn.Size = new Size(226, 56);
            addStudentBtn.TabIndex = 18;
            addStudentBtn.Text = "Add Student";
            addStudentBtn.UseVisualStyleBackColor = false;
            addStudentBtn.Click += addStudentBtn_Click;
            // 
            // trackComboBox
            // 
            trackComboBox.Anchor = AnchorStyles.Top;
            trackComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            trackComboBox.Font = new Font("Rockwell", 16.2F);
            trackComboBox.ForeColor = Color.FromArgb(39, 55, 77);
            trackComboBox.FormattingEnabled = true;
            trackComboBox.Location = new Point(148, 258);
            trackComboBox.Name = "trackComboBox";
            trackComboBox.Size = new Size(337, 39);
            trackComboBox.TabIndex = 17;
            // 
            // passwordInput
            // 
            passwordInput.Anchor = AnchorStyles.Top;
            passwordInput.BorderStyle = BorderStyle.None;
            passwordInput.Font = new Font("Rockwell Condensed", 16F);
            passwordInput.ForeColor = Color.FromArgb(38, 80, 115);
            passwordInput.Location = new Point(796, 263);
            passwordInput.Name = "passwordInput";
            passwordInput.Size = new Size(335, 32);
            passwordInput.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.BackColor = SystemColors.Window;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(796, 297);
            panel2.Name = "panel2";
            panel2.Size = new Size(337, 2);
            panel2.TabIndex = 16;
            // 
            // passwordLabel
            // 
            passwordLabel.Anchor = AnchorStyles.Top;
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Rockwell", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordLabel.ForeColor = Color.FromArgb(39, 55, 77);
            passwordLabel.Location = new Point(798, 217);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(147, 31);
            passwordLabel.TabIndex = 14;
            passwordLabel.Text = "Password:";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top;
            panel3.BackColor = SystemColors.Window;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Location = new Point(148, 297);
            panel3.Name = "panel3";
            panel3.Size = new Size(337, 2);
            panel3.TabIndex = 13;
            // 
            // trackLabel
            // 
            trackLabel.Anchor = AnchorStyles.Top;
            trackLabel.AutoSize = true;
            trackLabel.Font = new Font("Rockwell", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            trackLabel.ForeColor = Color.FromArgb(39, 55, 77);
            trackLabel.Location = new Point(150, 217);
            trackLabel.Name = "trackLabel";
            trackLabel.Size = new Size(96, 31);
            trackLabel.TabIndex = 11;
            trackLabel.Text = "Track:";
            // 
            // emailInput
            // 
            emailInput.Anchor = AnchorStyles.Top;
            emailInput.BorderStyle = BorderStyle.None;
            emailInput.Font = new Font("Rockwell Condensed", 16F);
            emailInput.ForeColor = Color.FromArgb(38, 80, 115);
            emailInput.Location = new Point(789, 166);
            emailInput.Name = "emailInput";
            emailInput.Size = new Size(335, 32);
            emailInput.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = SystemColors.Window;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(789, 200);
            panel1.Name = "panel1";
            panel1.Size = new Size(337, 2);
            panel1.TabIndex = 10;
            // 
            // emailLabel
            // 
            emailLabel.Anchor = AnchorStyles.Top;
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Rockwell", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailLabel.ForeColor = Color.FromArgb(39, 55, 77);
            emailLabel.Location = new Point(791, 120);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(95, 31);
            emailLabel.TabIndex = 8;
            emailLabel.Text = "Email:";
            // 
            // StudentNameInput
            // 
            StudentNameInput.Anchor = AnchorStyles.Top;
            StudentNameInput.BorderStyle = BorderStyle.None;
            StudentNameInput.Font = new Font("Rockwell Condensed", 16F);
            StudentNameInput.ForeColor = Color.FromArgb(38, 80, 115);
            StudentNameInput.Location = new Point(141, 166);
            StudentNameInput.Name = "StudentNameInput";
            StudentNameInput.Size = new Size(335, 32);
            StudentNameInput.TabIndex = 2;
            // 
            // namePanel
            // 
            namePanel.Anchor = AnchorStyles.Top;
            namePanel.BackColor = SystemColors.Window;
            namePanel.BorderStyle = BorderStyle.FixedSingle;
            namePanel.Location = new Point(141, 200);
            namePanel.Name = "namePanel";
            namePanel.Size = new Size(337, 2);
            namePanel.TabIndex = 7;
            // 
            // nameLabel
            // 
            nameLabel.Anchor = AnchorStyles.Top;
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Rockwell", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameLabel.ForeColor = Color.FromArgb(39, 55, 77);
            nameLabel.Location = new Point(143, 120);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(97, 31);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Name:";
            // 
            // addStudentHeading
            // 
            addStudentHeading.Anchor = AnchorStyles.Top;
            addStudentHeading.AutoSize = true;
            addStudentHeading.Font = new Font("Rockwell", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addStudentHeading.ForeColor = Color.FromArgb(39, 55, 77);
            addStudentHeading.Location = new Point(11, 5);
            addStudentHeading.Name = "addStudentHeading";
            addStudentHeading.Size = new Size(186, 35);
            addStudentHeading.TabIndex = 0;
            addStudentHeading.Text = "Add Student";
            // 
            // searchStudent
            // 
            searchStudent.Controls.Add(pictureBox1);
            searchStudent.Controls.Add(searchByComboBox);
            searchStudent.Controls.Add(panel5);
            searchStudent.Controls.Add(searchBy);
            searchStudent.Controls.Add(searchInput);
            searchStudent.Controls.Add(panel4);
            searchStudent.Controls.Add(searchLabel);
            searchStudent.Controls.Add(dataGridStudent);
            searchStudent.Font = new Font("Rockwell", 16.2F);
            searchStudent.ForeColor = Color.FromArgb(39, 55, 77);
            searchStudent.Location = new Point(4, 4);
            searchStudent.Name = "searchStudent";
            searchStudent.Padding = new Padding(3);
            searchStudent.Size = new Size(1280, 629);
            searchStudent.TabIndex = 1;
            searchStudent.Text = "search student";
            searchStudent.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(356, 98);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // searchByComboBox
            // 
            searchByComboBox.Anchor = AnchorStyles.Top;
            searchByComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            searchByComboBox.Font = new Font("Rockwell", 16.2F);
            searchByComboBox.ForeColor = Color.FromArgb(39, 55, 77);
            searchByComboBox.FormattingEnabled = true;
            searchByComboBox.Items.AddRange(new object[] { "id", "name", "email", "track" });
            searchByComboBox.Location = new Point(840, 93);
            searchByComboBox.Name = "searchByComboBox";
            searchByComboBox.Size = new Size(337, 39);
            searchByComboBox.TabIndex = 20;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top;
            panel5.BackColor = SystemColors.Window;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Location = new Point(840, 132);
            panel5.Name = "panel5";
            panel5.Size = new Size(337, 2);
            panel5.TabIndex = 19;
            // 
            // searchBy
            // 
            searchBy.Anchor = AnchorStyles.Top;
            searchBy.AutoSize = true;
            searchBy.Font = new Font("Rockwell", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBy.ForeColor = Color.FromArgb(39, 55, 77);
            searchBy.Location = new Point(842, 52);
            searchBy.Name = "searchBy";
            searchBy.Size = new Size(150, 31);
            searchBy.TabIndex = 18;
            searchBy.Text = "Search By:";
            // 
            // searchInput
            // 
            searchInput.Anchor = AnchorStyles.Top;
            searchInput.BorderStyle = BorderStyle.None;
            searchInput.Font = new Font("Rockwell Condensed", 16F);
            searchInput.ForeColor = Color.FromArgb(38, 80, 115);
            searchInput.Location = new Point(64, 100);
            searchInput.Name = "searchInput";
            searchInput.Size = new Size(335, 32);
            searchInput.TabIndex = 9;
            searchInput.TextChanged += search;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top;
            panel4.BackColor = SystemColors.Window;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Location = new Point(64, 134);
            panel4.Name = "panel4";
            panel4.Size = new Size(337, 2);
            panel4.TabIndex = 10;
            // 
            // searchLabel
            // 
            searchLabel.Anchor = AnchorStyles.Top;
            searchLabel.AutoSize = true;
            searchLabel.Font = new Font("Rockwell", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchLabel.ForeColor = Color.FromArgb(39, 55, 77);
            searchLabel.Location = new Point(66, 54);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(111, 31);
            searchLabel.TabIndex = 8;
            searchLabel.Text = "Search:";
            // 
            // dataGridStudent
            // 
            dataGridStudent.AllowUserToAddRows = false;
            dataGridStudent.AllowUserToDeleteRows = false;
            dataGridStudent.AllowUserToResizeColumns = false;
            dataGridStudent.AllowUserToResizeRows = false;
            dataGridStudent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dataGridStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridStudent.BackgroundColor = Color.White;
            dataGridStudent.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridStudent.Columns.AddRange(new DataGridViewColumn[] { IdCol, NameCol, EmailCol, TrackCol });
            dataGridStudent.Location = new Point(6, 158);
            dataGridStudent.Name = "dataGridStudent";
            dataGridStudent.ReadOnly = true;
            dataGridStudent.RowHeadersWidth = 51;
            dataGridStudent.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridStudent.ShowCellErrors = false;
            dataGridStudent.ShowEditingIcon = false;
            dataGridStudent.ShowRowErrors = false;
            dataGridStudent.Size = new Size(1257, 455);
            dataGridStudent.TabIndex = 0;
            // 
            // IdCol
            // 
            IdCol.HeaderText = "Id";
            IdCol.MinimumWidth = 6;
            IdCol.Name = "IdCol";
            IdCol.ReadOnly = true;
            // 
            // NameCol
            // 
            NameCol.HeaderText = "Name";
            NameCol.MinimumWidth = 6;
            NameCol.Name = "NameCol";
            NameCol.ReadOnly = true;
            // 
            // EmailCol
            // 
            EmailCol.HeaderText = "Email";
            EmailCol.MinimumWidth = 6;
            EmailCol.Name = "EmailCol";
            EmailCol.ReadOnly = true;
            // 
            // TrackCol
            // 
            TrackCol.HeaderText = "Track";
            TrackCol.MinimumWidth = 6;
            TrackCol.Name = "TrackCol";
            TrackCol.ReadOnly = true;
            // 
            // updateAndDeleteStudent
            // 
            updateAndDeleteStudent.BackColor = Color.Transparent;
            updateAndDeleteStudent.Controls.Add(deleteBtn);
            updateAndDeleteStudent.Controls.Add(editErrorMsg);
            updateAndDeleteStudent.Controls.Add(updateBtn);
            updateAndDeleteStudent.Controls.Add(TrackEditComboBox);
            updateAndDeleteStudent.Controls.Add(passwordEditInput);
            updateAndDeleteStudent.Controls.Add(panel6);
            updateAndDeleteStudent.Controls.Add(passwordEditLabel);
            updateAndDeleteStudent.Controls.Add(panel7);
            updateAndDeleteStudent.Controls.Add(trackEditLabel);
            updateAndDeleteStudent.Controls.Add(emailEditInputt);
            updateAndDeleteStudent.Controls.Add(panel8);
            updateAndDeleteStudent.Controls.Add(emailEditLabel);
            updateAndDeleteStudent.Controls.Add(nameEditInput);
            updateAndDeleteStudent.Controls.Add(panel9);
            updateAndDeleteStudent.Controls.Add(nameEditLabel);
            updateAndDeleteStudent.Font = new Font("Rockwell", 16.2F);
            updateAndDeleteStudent.ForeColor = Color.FromArgb(39, 55, 77);
            updateAndDeleteStudent.Location = new Point(4, 4);
            updateAndDeleteStudent.Name = "updateAndDeleteStudent";
            updateAndDeleteStudent.Size = new Size(1280, 629);
            updateAndDeleteStudent.TabIndex = 2;
            updateAndDeleteStudent.Text = "update and delete student";
            // 
            // deleteBtn
            // 
            deleteBtn.Anchor = AnchorStyles.Top;
            deleteBtn.BackColor = Color.FromArgb(218, 12, 12);
            deleteBtn.FlatAppearance.BorderSize = 0;
            deleteBtn.FlatStyle = FlatStyle.Flat;
            deleteBtn.Font = new Font("Rockwell", 16.2F);
            deleteBtn.ForeColor = Color.AliceBlue;
            deleteBtn.Location = new Point(697, 434);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(226, 56);
            deleteBtn.TabIndex = 35;
            deleteBtn.Text = "Delete Student";
            deleteBtn.UseVisualStyleBackColor = false;
            // 
            // editErrorMsg
            // 
            editErrorMsg.Anchor = AnchorStyles.Top;
            editErrorMsg.AutoSize = true;
            editErrorMsg.BackColor = Color.LightGray;
            editErrorMsg.Font = new Font("Rockwell", 12F);
            editErrorMsg.ForeColor = Color.Red;
            editErrorMsg.Location = new Point(568, 371);
            editErrorMsg.Name = "editErrorMsg";
            editErrorMsg.Size = new Size(151, 22);
            editErrorMsg.TabIndex = 34;
            editErrorMsg.Text = "email not found";
            editErrorMsg.Visible = false;
            // 
            // updateBtn
            // 
            updateBtn.Anchor = AnchorStyles.Top;
            updateBtn.BackColor = Color.FromArgb(92, 131, 116);
            updateBtn.FlatAppearance.BorderSize = 0;
            updateBtn.FlatStyle = FlatStyle.Flat;
            updateBtn.Font = new Font("Rockwell", 16.2F);
            updateBtn.ForeColor = Color.AliceBlue;
            updateBtn.Location = new Point(387, 434);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(226, 56);
            updateBtn.TabIndex = 33;
            updateBtn.Text = "Upadte Student";
            updateBtn.UseVisualStyleBackColor = false;
            // 
            // TrackEditComboBox
            // 
            TrackEditComboBox.Anchor = AnchorStyles.Top;
            TrackEditComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TrackEditComboBox.Font = new Font("Rockwell", 16.2F);
            TrackEditComboBox.ForeColor = Color.FromArgb(39, 55, 77);
            TrackEditComboBox.FormattingEnabled = true;
            TrackEditComboBox.Location = new Point(142, 269);
            TrackEditComboBox.Name = "TrackEditComboBox";
            TrackEditComboBox.Size = new Size(337, 39);
            TrackEditComboBox.TabIndex = 32;
            // 
            // passwordEditInput
            // 
            passwordEditInput.Anchor = AnchorStyles.Top;
            passwordEditInput.BorderStyle = BorderStyle.None;
            passwordEditInput.Font = new Font("Rockwell Condensed", 16F);
            passwordEditInput.ForeColor = Color.FromArgb(38, 80, 115);
            passwordEditInput.Location = new Point(799, 276);
            passwordEditInput.Name = "passwordEditInput";
            passwordEditInput.Size = new Size(335, 32);
            passwordEditInput.TabIndex = 30;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top;
            panel6.BackColor = SystemColors.Window;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Location = new Point(799, 310);
            panel6.Name = "panel6";
            panel6.Size = new Size(337, 2);
            panel6.TabIndex = 31;
            // 
            // passwordEditLabel
            // 
            passwordEditLabel.Anchor = AnchorStyles.Top;
            passwordEditLabel.AutoSize = true;
            passwordEditLabel.Font = new Font("Rockwell", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordEditLabel.ForeColor = Color.FromArgb(39, 55, 77);
            passwordEditLabel.Location = new Point(801, 230);
            passwordEditLabel.Name = "passwordEditLabel";
            passwordEditLabel.Size = new Size(147, 31);
            passwordEditLabel.TabIndex = 29;
            passwordEditLabel.Text = "Password:";
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Top;
            panel7.BackColor = SystemColors.Window;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Location = new Point(142, 308);
            panel7.Name = "panel7";
            panel7.Size = new Size(337, 2);
            panel7.TabIndex = 28;
            // 
            // trackEditLabel
            // 
            trackEditLabel.Anchor = AnchorStyles.Top;
            trackEditLabel.AutoSize = true;
            trackEditLabel.Font = new Font("Rockwell", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            trackEditLabel.ForeColor = Color.FromArgb(39, 55, 77);
            trackEditLabel.Location = new Point(142, 230);
            trackEditLabel.Name = "trackEditLabel";
            trackEditLabel.Size = new Size(96, 31);
            trackEditLabel.TabIndex = 27;
            trackEditLabel.Text = "Track:";
            // 
            // emailEditInputt
            // 
            emailEditInputt.Anchor = AnchorStyles.Top;
            emailEditInputt.BorderStyle = BorderStyle.None;
            emailEditInputt.Font = new Font("Rockwell Condensed", 16F);
            emailEditInputt.ForeColor = Color.FromArgb(38, 80, 115);
            emailEditInputt.Location = new Point(792, 179);
            emailEditInputt.Name = "emailEditInputt";
            emailEditInputt.Size = new Size(335, 32);
            emailEditInputt.TabIndex = 25;
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.Top;
            panel8.BackColor = SystemColors.Window;
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Location = new Point(792, 213);
            panel8.Name = "panel8";
            panel8.Size = new Size(337, 2);
            panel8.TabIndex = 26;
            // 
            // emailEditLabel
            // 
            emailEditLabel.Anchor = AnchorStyles.Top;
            emailEditLabel.AutoSize = true;
            emailEditLabel.Font = new Font("Rockwell", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailEditLabel.ForeColor = Color.FromArgb(39, 55, 77);
            emailEditLabel.Location = new Point(794, 133);
            emailEditLabel.Name = "emailEditLabel";
            emailEditLabel.Size = new Size(95, 31);
            emailEditLabel.TabIndex = 24;
            emailEditLabel.Text = "Email:";
            // 
            // nameEditInput
            // 
            nameEditInput.Anchor = AnchorStyles.Top;
            nameEditInput.BorderStyle = BorderStyle.None;
            nameEditInput.Font = new Font("Rockwell Condensed", 16F);
            nameEditInput.ForeColor = Color.FromArgb(38, 80, 115);
            nameEditInput.Location = new Point(144, 179);
            nameEditInput.Name = "nameEditInput";
            nameEditInput.Size = new Size(335, 32);
            nameEditInput.TabIndex = 22;
            // 
            // panel9
            // 
            panel9.Anchor = AnchorStyles.Top;
            panel9.BackColor = SystemColors.Window;
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Location = new Point(144, 213);
            panel9.Name = "panel9";
            panel9.Size = new Size(337, 2);
            panel9.TabIndex = 23;
            // 
            // nameEditLabel
            // 
            nameEditLabel.Anchor = AnchorStyles.Top;
            nameEditLabel.AutoSize = true;
            nameEditLabel.Font = new Font("Rockwell", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameEditLabel.ForeColor = Color.FromArgb(39, 55, 77);
            nameEditLabel.Location = new Point(146, 133);
            nameEditLabel.Name = "nameEditLabel";
            nameEditLabel.Size = new Size(97, 31);
            nameEditLabel.TabIndex = 21;
            nameEditLabel.Text = "Name:";
            // 
            // UserControlAddStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 230, 237);
            Controls.Add(tabStudent);
            Name = "UserControlAddStudent";
            Size = new Size(1288, 740);
            tabStudent.ResumeLayout(false);
            addStudentTabPage.ResumeLayout(false);
            addStudentTabPage.PerformLayout();
            searchStudent.ResumeLayout(false);
            searchStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridStudent).EndInit();
            updateAndDeleteStudent.ResumeLayout(false);
            updateAndDeleteStudent.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabStudent;
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
        public ComboBox trackComboBox;
        private TabPage updateAndDeleteStudent;
        private Label errorMsg;
        private DataGridView dataGridStudent;
        private DataGridViewTextBoxColumn IdCol;
        private DataGridViewTextBoxColumn NameCol;
        private DataGridViewTextBoxColumn EmailCol;
        private DataGridViewTextBoxColumn TrackCol;
        private TextBox searchInput;
        private Panel panel4;
        private Label searchLabel;
        public ComboBox searchByComboBox;
        private Panel panel5;
        private Label searchBy;
        private PictureBox pictureBox1;
        private Label editErrorMsg;
        private Button updateBtn;
        public ComboBox TrackEditComboBox;
        private TextBox passwordEditInput;
        private Panel panel6;
        private Label passwordEditLabel;
        private Panel panel7;
        private Label trackEditLabel;
        private TextBox emailEditInputt;
        private Panel panel8;
        private Label emailEditLabel;
        private TextBox nameEditInput;
        private Panel panel9;
        private Label nameEditLabel;
        private Button deleteBtn;
    }
}
