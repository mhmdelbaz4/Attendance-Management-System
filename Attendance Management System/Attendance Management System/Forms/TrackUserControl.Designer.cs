namespace Attendance_Management_System.Forms
{
    partial class TrackUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrackUserControl));
            tabTrack = new TabControl();
            addStudentTabPage = new TabPage();
            addTrackBtn = new Button();
            TrackNameInput = new TextBox();
            namePanel = new Panel();
            nameLabel = new Label();
            addStudentHeading = new Label();
            panel2 = new Panel();
            passwordLabel = new Label();
            emailInput = new TextBox();
            panel1 = new Panel();
            searchStudent = new TabPage();
            pictureBox1 = new PictureBox();
            searchInput = new TextBox();
            panel4 = new Panel();
            searchLabel = new Label();
            dataGridTrack = new DataGridView();
            NameCol = new DataGridViewTextBoxColumn();
            NoStudents = new DataGridViewTextBoxColumn();
            NoTeachers = new DataGridViewTextBoxColumn();
            searchByComboBox = new ComboBox();
            panel5 = new Panel();
            searchBy = new Label();
            updateAndDeleteStudent = new TabPage();
            deleteBtn = new Button();
            updateBtn = new Button();
            trackNameEditInput = new TextBox();
            panel9 = new Panel();
            nameEditLabel = new Label();
            tabTrack.SuspendLayout();
            addStudentTabPage.SuspendLayout();
            searchStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridTrack).BeginInit();
            updateAndDeleteStudent.SuspendLayout();
            SuspendLayout();
            // 
            // tabTrack
            // 
            tabTrack.Alignment = TabAlignment.Bottom;
            tabTrack.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tabTrack.Controls.Add(addStudentTabPage);
            tabTrack.Controls.Add(searchStudent);
            tabTrack.Controls.Add(updateAndDeleteStudent);
            tabTrack.Cursor = Cursors.Hand;
            tabTrack.Font = new Font("Rockwell", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabTrack.Location = new Point(0, 39);
            tabTrack.Name = "tabTrack";
            tabTrack.SelectedIndex = 0;
            tabTrack.Size = new Size(1288, 662);
            tabTrack.TabIndex = 1;
            tabTrack.SelectedIndexChanged += handleSwitchTabsInTracks;
            // 
            // addStudentTabPage
            // 
            addStudentTabPage.Controls.Add(addTrackBtn);
            addStudentTabPage.Controls.Add(TrackNameInput);
            addStudentTabPage.Controls.Add(namePanel);
            addStudentTabPage.Controls.Add(nameLabel);
            addStudentTabPage.Controls.Add(addStudentHeading);
            addStudentTabPage.Controls.Add(panel2);
            addStudentTabPage.Controls.Add(passwordLabel);
            addStudentTabPage.Controls.Add(emailInput);
            addStudentTabPage.Controls.Add(panel1);
            addStudentTabPage.Font = new Font("Rockwell", 16.2F);
            addStudentTabPage.ForeColor = Color.FromArgb(39, 55, 77);
            addStudentTabPage.Location = new Point(4, 4);
            addStudentTabPage.Name = "addStudentTabPage";
            addStudentTabPage.Padding = new Padding(5);
            addStudentTabPage.Size = new Size(1280, 618);
            addStudentTabPage.TabIndex = 0;
            addStudentTabPage.Text = "   ➕";
            addStudentTabPage.UseVisualStyleBackColor = true;
            // 
            // addTrackBtn
            // 
            addTrackBtn.Anchor = AnchorStyles.Top;
            addTrackBtn.BackColor = Color.FromArgb(39, 55, 77);
            addTrackBtn.FlatAppearance.BorderSize = 0;
            addTrackBtn.FlatStyle = FlatStyle.Flat;
            addTrackBtn.Font = new Font("Rockwell", 16.2F);
            addTrackBtn.ForeColor = Color.AliceBlue;
            addTrackBtn.Location = new Point(878, 355);
            addTrackBtn.Name = "addTrackBtn";
            addTrackBtn.Size = new Size(226, 56);
            addTrackBtn.TabIndex = 33;
            addTrackBtn.Text = "Add Track";
            addTrackBtn.UseVisualStyleBackColor = false;
            addTrackBtn.Click += addTrackBtn_Click;
            // 
            // TrackNameInput
            // 
            TrackNameInput.Anchor = AnchorStyles.Top;
            TrackNameInput.BorderStyle = BorderStyle.None;
            TrackNameInput.Font = new Font("Rockwell Condensed", 16F);
            TrackNameInput.ForeColor = Color.FromArgb(38, 80, 115);
            TrackNameInput.Location = new Point(306, 368);
            TrackNameInput.Name = "TrackNameInput";
            TrackNameInput.PlaceholderText = "Name";
            TrackNameInput.Size = new Size(335, 32);
            TrackNameInput.TabIndex = 22;
            // 
            // namePanel
            // 
            namePanel.Anchor = AnchorStyles.Top;
            namePanel.BackColor = SystemColors.Window;
            namePanel.BorderStyle = BorderStyle.FixedSingle;
            namePanel.Location = new Point(306, 402);
            namePanel.Name = "namePanel";
            namePanel.Size = new Size(337, 2);
            namePanel.TabIndex = 23;
            // 
            // nameLabel
            // 
            nameLabel.Anchor = AnchorStyles.Top;
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Rockwell", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameLabel.ForeColor = Color.FromArgb(39, 55, 77);
            nameLabel.Location = new Point(308, 322);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(178, 31);
            nameLabel.TabIndex = 21;
            nameLabel.Text = "Track Name:";
            // 
            // addStudentHeading
            // 
            addStudentHeading.Anchor = AnchorStyles.Top;
            addStudentHeading.AutoSize = true;
            addStudentHeading.Font = new Font("Rockwell", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addStudentHeading.ForeColor = Color.FromArgb(39, 55, 77);
            addStudentHeading.Location = new Point(39, 47);
            addStudentHeading.Name = "addStudentHeading";
            addStudentHeading.Size = new Size(161, 35);
            addStudentHeading.TabIndex = 20;
            addStudentHeading.Text = "Add Track";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.BackColor = SystemColors.Window;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(1336, 302);
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
            passwordLabel.Location = new Point(1338, 222);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(147, 31);
            passwordLabel.TabIndex = 14;
            passwordLabel.Text = "Password:";
            // 
            // emailInput
            // 
            emailInput.Anchor = AnchorStyles.Top;
            emailInput.BorderStyle = BorderStyle.None;
            emailInput.Font = new Font("Rockwell Condensed", 16F);
            emailInput.ForeColor = Color.FromArgb(38, 80, 115);
            emailInput.Location = new Point(1329, 171);
            emailInput.Name = "emailInput";
            emailInput.PlaceholderText = "email@gmail.com";
            emailInput.Size = new Size(335, 32);
            emailInput.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = SystemColors.Window;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(1329, 205);
            panel1.Name = "panel1";
            panel1.Size = new Size(337, 2);
            panel1.TabIndex = 10;
            // 
            // searchStudent
            // 
            searchStudent.Controls.Add(pictureBox1);
            searchStudent.Controls.Add(searchInput);
            searchStudent.Controls.Add(panel4);
            searchStudent.Controls.Add(searchLabel);
            searchStudent.Controls.Add(dataGridTrack);
            searchStudent.Controls.Add(searchByComboBox);
            searchStudent.Controls.Add(panel5);
            searchStudent.Controls.Add(searchBy);
            searchStudent.Font = new Font("Rockwell", 16.2F);
            searchStudent.ForeColor = Color.FromArgb(39, 55, 77);
            searchStudent.Location = new Point(4, 4);
            searchStudent.Name = "searchStudent";
            searchStudent.Padding = new Padding(3);
            searchStudent.Size = new Size(1280, 618);
            searchStudent.TabIndex = 1;
            searchStudent.Text = "   🔍";
            searchStudent.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(362, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // searchInput
            // 
            searchInput.Anchor = AnchorStyles.Top;
            searchInput.BorderStyle = BorderStyle.None;
            searchInput.Font = new Font("Rockwell Condensed", 16F);
            searchInput.ForeColor = Color.FromArgb(38, 80, 115);
            searchInput.Location = new Point(70, 82);
            searchInput.Name = "searchInput";
            searchInput.Size = new Size(335, 32);
            searchInput.TabIndex = 24;
            searchInput.TextChanged += searchInput_TextChanged;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top;
            panel4.BackColor = SystemColors.Window;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Location = new Point(70, 116);
            panel4.Name = "panel4";
            panel4.Size = new Size(337, 2);
            panel4.TabIndex = 25;
            // 
            // searchLabel
            // 
            searchLabel.Anchor = AnchorStyles.Top;
            searchLabel.AutoSize = true;
            searchLabel.Font = new Font("Rockwell", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchLabel.ForeColor = Color.FromArgb(39, 55, 77);
            searchLabel.Location = new Point(72, 36);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(232, 31);
            searchLabel.TabIndex = 23;
            searchLabel.Text = "Search By Name:";
            // 
            // dataGridTrack
            // 
            dataGridTrack.AllowUserToAddRows = false;
            dataGridTrack.AllowUserToDeleteRows = false;
            dataGridTrack.AllowUserToResizeColumns = false;
            dataGridTrack.AllowUserToResizeRows = false;
            dataGridTrack.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dataGridTrack.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridTrack.BackgroundColor = Color.White;
            dataGridTrack.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridTrack.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridTrack.Columns.AddRange(new DataGridViewColumn[] { NameCol, NoStudents, NoTeachers });
            dataGridTrack.Location = new Point(12, 140);
            dataGridTrack.Name = "dataGridTrack";
            dataGridTrack.ReadOnly = true;
            dataGridTrack.RowHeadersWidth = 51;
            dataGridTrack.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridTrack.ShowCellErrors = false;
            dataGridTrack.ShowEditingIcon = false;
            dataGridTrack.ShowRowErrors = false;
            dataGridTrack.Size = new Size(1257, 444);
            dataGridTrack.TabIndex = 22;
            dataGridTrack.CellClick += editTrack_cellClick;
            // 
            // NameCol
            // 
            NameCol.HeaderText = "Track Name";
            NameCol.MinimumWidth = 6;
            NameCol.Name = "NameCol";
            NameCol.ReadOnly = true;
            // 
            // NoStudents
            // 
            NoStudents.HeaderText = "Number of Students";
            NoStudents.MinimumWidth = 6;
            NoStudents.Name = "NoStudents";
            NoStudents.ReadOnly = true;
            // 
            // NoTeachers
            // 
            NoTeachers.HeaderText = "Number of Teachers";
            NoTeachers.MinimumWidth = 6;
            NoTeachers.Name = "NoTeachers";
            NoTeachers.ReadOnly = true;
            // 
            // searchByComboBox
            // 
            searchByComboBox.Anchor = AnchorStyles.Top;
            searchByComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            searchByComboBox.Font = new Font("Rockwell", 16.2F);
            searchByComboBox.ForeColor = Color.FromArgb(39, 55, 77);
            searchByComboBox.FormattingEnabled = true;
            searchByComboBox.Items.AddRange(new object[] { "id", "name", "email", "track" });
            searchByComboBox.Location = new Point(1380, 96);
            searchByComboBox.Name = "searchByComboBox";
            searchByComboBox.Size = new Size(337, 39);
            searchByComboBox.TabIndex = 20;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top;
            panel5.BackColor = SystemColors.Window;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Location = new Point(1380, 135);
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
            searchBy.Location = new Point(1382, 55);
            searchBy.Name = "searchBy";
            searchBy.Size = new Size(150, 31);
            searchBy.TabIndex = 18;
            searchBy.Text = "Search By:";
            // 
            // updateAndDeleteStudent
            // 
            updateAndDeleteStudent.BackColor = Color.Transparent;
            updateAndDeleteStudent.Controls.Add(deleteBtn);
            updateAndDeleteStudent.Controls.Add(updateBtn);
            updateAndDeleteStudent.Controls.Add(trackNameEditInput);
            updateAndDeleteStudent.Controls.Add(panel9);
            updateAndDeleteStudent.Controls.Add(nameEditLabel);
            updateAndDeleteStudent.Font = new Font("Rockwell", 16.2F);
            updateAndDeleteStudent.ForeColor = Color.FromArgb(39, 55, 77);
            updateAndDeleteStudent.Location = new Point(4, 4);
            updateAndDeleteStudent.Name = "updateAndDeleteStudent";
            updateAndDeleteStudent.Size = new Size(1280, 618);
            updateAndDeleteStudent.TabIndex = 2;
            updateAndDeleteStudent.Text = "♻️| 🗑️ ";
            // 
            // deleteBtn
            // 
            deleteBtn.Anchor = AnchorStyles.Top;
            deleteBtn.BackColor = Color.FromArgb(218, 12, 12);
            deleteBtn.FlatAppearance.BorderSize = 0;
            deleteBtn.FlatStyle = FlatStyle.Flat;
            deleteBtn.Font = new Font("Rockwell", 16.2F);
            deleteBtn.ForeColor = Color.AliceBlue;
            deleteBtn.Location = new Point(796, 277);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(226, 56);
            deleteBtn.TabIndex = 50;
            deleteBtn.Text = "Delete Track";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Anchor = AnchorStyles.Top;
            updateBtn.BackColor = Color.FromArgb(92, 131, 116);
            updateBtn.FlatAppearance.BorderSize = 0;
            updateBtn.FlatStyle = FlatStyle.Flat;
            updateBtn.Font = new Font("Rockwell", 16.2F);
            updateBtn.ForeColor = Color.AliceBlue;
            updateBtn.Location = new Point(511, 277);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(226, 56);
            updateBtn.TabIndex = 48;
            updateBtn.Text = "Update Track";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // trackNameEditInput
            // 
            trackNameEditInput.Anchor = AnchorStyles.Top;
            trackNameEditInput.BorderStyle = BorderStyle.None;
            trackNameEditInput.Font = new Font("Rockwell Condensed", 16F);
            trackNameEditInput.ForeColor = Color.FromArgb(38, 80, 115);
            trackNameEditInput.Location = new Point(76, 290);
            trackNameEditInput.Name = "trackNameEditInput";
            trackNameEditInput.PlaceholderText = "Track Name";
            trackNameEditInput.Size = new Size(335, 32);
            trackNameEditInput.TabIndex = 37;
            // 
            // panel9
            // 
            panel9.Anchor = AnchorStyles.Top;
            panel9.BackColor = SystemColors.Window;
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Location = new Point(76, 324);
            panel9.Name = "panel9";
            panel9.Size = new Size(337, 2);
            panel9.TabIndex = 38;
            // 
            // nameEditLabel
            // 
            nameEditLabel.Anchor = AnchorStyles.Top;
            nameEditLabel.AutoSize = true;
            nameEditLabel.Font = new Font("Rockwell", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameEditLabel.ForeColor = Color.FromArgb(39, 55, 77);
            nameEditLabel.Location = new Point(78, 244);
            nameEditLabel.Name = "nameEditLabel";
            nameEditLabel.Size = new Size(178, 31);
            nameEditLabel.TabIndex = 36;
            nameEditLabel.Text = "Track Name:";
            // 
            // TrackUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 230, 237);
            Controls.Add(tabTrack);
            Name = "TrackUserControl";
            Size = new Size(1288, 740);
            tabTrack.ResumeLayout(false);
            addStudentTabPage.ResumeLayout(false);
            addStudentTabPage.PerformLayout();
            searchStudent.ResumeLayout(false);
            searchStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridTrack).EndInit();
            updateAndDeleteStudent.ResumeLayout(false);
            updateAndDeleteStudent.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        public string selectedTrackName = "";
        private TabControl tabTrack;
        private TabPage addStudentTabPage;
        private Panel panel2;
        private Label passwordLabel;
        private TextBox emailInput;
        private Panel panel1;
        private TabPage searchStudent;
        public ComboBox searchByComboBox;
        private Panel panel5;
        private Label searchBy;
        private Button addTrackBtn;
        private TextBox TrackNameInput;
        private Panel namePanel;
        private Label nameLabel;
        private Label addStudentHeading;
        private PictureBox pictureBox1;
        private TextBox searchInput;
        private Panel panel4;
        private Label searchLabel;
        private DataGridView dataGridTrack;
        private TabPage updateAndDeleteStudent;
        private DataGridViewTextBoxColumn NameCol;
        private DataGridViewTextBoxColumn NoStudents;
        private DataGridViewTextBoxColumn NoTeachers;
        private Button deleteBtn;
        private Button updateBtn;
        private TextBox trackNameEditInput;
        private Panel panel9;
        private Label nameEditLabel;
    }
}
