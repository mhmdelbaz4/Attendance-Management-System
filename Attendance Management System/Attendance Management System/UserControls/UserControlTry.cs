using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Attendance_Management_System.Repos;
using Attendance_Management_System.Models;
using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.html;
using Attendance_Management_System.Forms;
using System.Xml;

namespace Attendance_Management_System.UserControls
{
    public partial class UserControlTry : UserControl
    {
        public TabControl tabControlReport = new TabControl();

        public UserControlTry()
        {
            InitializeComponent();
            PopulateTeacherComboBox();// get all teachers id 
            PopulateStudentComboBox();// get all student ids in xml file
        }
        // Method to populate the ComboBox with teacher IDs
        private void PopulateTeacherComboBox()
        {
            // Get teacher IDs from the XML
            List<string> teacherIds = GetTeacherIds();

            // Clear existing items from the combobox
            comboBoxTeachers.Items.Clear();
            comboBoxTeachers_students.Items.Clear();

            // Add teacher IDs to the ComboBox
            foreach (string id in teacherIds)
            {
                
                comboBoxTeachers.Items.Add(id);
                comboBoxTeachers_students.Items.Add(id);
            }
        }

        // Method to retrieve teacher IDs from the XML
        private List<string> GetTeacherIds()
        {
            List<string> teacherIds = new List<string>();

            string path = @"../../../../../xml/attendance.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(path);

            // Select all <id> elements under <teacher>
            XmlNodeList teacherIdNodes = doc.SelectNodes("//teachers/teacher/id");
            foreach (XmlNode node in teacherIdNodes)
            {
                // Add the inner text of the <id> node (as string) to the list
                teacherIds.Add(node.InnerText);
                
            }

            return teacherIds;
        }
        private void PopulateStudentComboBox()
        {
            // Get student IDs from the XML
            List<string> studentIds = GetStudentIds();

            // Clear existing items from the combobox
            comboBox_Student.Items.Clear();

            // Add student IDs to the ComboBox
            foreach (string id in studentIds)
            {
                comboBox_Student.Items.Add(id);// for student id in student tab
            }
        }

        // Method to retrieve student IDs from the XML
        private List<string> GetStudentIds()
        {
            List<string> studentIds = new List<string>();

            string path = @"../../../../../xml/attendance.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(path);

            // Select all <id> elements under <student>
            XmlNodeList studentIdNodes = doc.SelectNodes("//users/students/student/id");
            foreach (XmlNode node in studentIdNodes)
            {
                // Add the inner text of the <id> node (as string) to the list
                studentIds.Add(node.InnerText);
            }

            return studentIds;
        }



        // to choose excute any tab
        public void ExecuteTab()
        {
            if (tabControlReport.SelectedTab == tabp_TReports)
            {
                
                firstTab();
            }
            else if (tabControlReport.SelectedTab == tabPS_Reports)
            {
               
                student_Tab();
            }
        }
        public void firstTab()
        {
            tabControlReport.SelectedTab = tabp_TReports; // Select the desired tab

            // Load students based on selected track, teacher, and date
            LoadStudentsBasedOnTrackAndTeacher();
        }

        private void LoadStudentsBasedOnTrackAndTeacher()
        {
            // Check if both track and teacher are selected
            if (comboBox_tRACK.SelectedItem != null && comboBoxTeachers.SelectedItem != null)
            {
                // Get the selected track, teacher, and date
                string selectedTrack = comboBox_tRACK.SelectedItem?.ToString();
                // Assuming teacher IDs are integers
                DateOnly selectedDate = new DateOnly(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day);

                string selectedTeacher = comboBoxTeachers.SelectedItem?.ToString(); // Convert selected teacher to string

                // Load student data based on the selected track, teacher, and date
                LoadStudents(selectedTrack, selectedDate, selectedTeacher);
               
            }
            else
            {
                // Handle the case where either track or teacher is not selected
                MessageBox.Show("Please select both a track and a teacher.");
            }
        }

   

        private void LoadStudents(string trackName, DateOnly date, string teacherId)
        {
            // Load the students based on the selected track, teacher, and date
            string path = @"../../../../../xml/attendance.xml"; // Assuming this is the correct path
            var students = StudentsRepo.GetStudents(path);
        

            // Filter the students based on the selected track, teacher, and date
            List<Student> filteredStudents = FilterStudentsByTrackAndDateAndTeacher(students, trackName, date, teacherId);

            // Display the filtered students
            DisplayStudents(filteredStudents, teacherId, date);
        }

       
        private List<Student> FilterStudentsByTrackAndDateAndTeacher(List<Student> students, string trackName, DateOnly date, string teacherId)
        {
            List<Student> filteredStudents = new List<Student>();

            foreach (Student student in students)
            {
                // Check if the student is enrolled in the selected track
                if (student.TrackName == trackName)
                {
                    // Check if the student has any attendance records matching the selected teacher ID and date
                    bool hasMatchingAttendance = student.AttendaceHistory.Any(attendance =>
                        attendance.TeacherID == int.Parse(teacherId) && attendance.Date == date);

                    if (hasMatchingAttendance)
                    {
                        filteredStudents.Add(student);
                    }
                }
            }

            return filteredStudents;
        }


        private void DisplayStudents(List<Student> students, string selectedTeacherId, DateOnly selectedDate)
        {
            dataGridView_reports.Rows.Clear();
       

            foreach (var student in students)
            {
                // Filter the attendance items for the current student by selected teacher ID and date
                var filteredAttendance = student.AttendaceHistory.Where(attendance =>
                    attendance.TeacherID == int.Parse(selectedTeacherId) && attendance.Date == selectedDate);
         

                // If there are no attendance items for this student with the selected teacher ID and date, continue to the next student
                if (filteredAttendance.Count() == 0)
                {

                    continue;
                }


                // Take the first (and only) attendance item for this student with the selected teacher ID and date
                var attendanceItem = filteredAttendance.First();
            
                // Add a row to the DataGridView with student information and the attendance item
                dataGridView_reports.Rows.Add(student.ID, student.Name, student.TrackName, attendanceItem.TeacherID, attendanceItem.Date, attendanceItem.State);
              

            }
        }

        // Event handler for ComboBox SelectedIndexChanged event to reload data when track is changed
        private void comboBoxTrack_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadStudentsBasedOnTrackAndTeacher();
        }

        // Event handler for ComboBox SelectedIndexChanged event to reload data when teacher is changed
        private void comboBoxTeachers_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadStudentsBasedOnTrackAndTeacher();
        }

        // Event handler for the DateTimePicker ValueChanged event to reload data when date is changed
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            LoadStudentsBasedOnTrackAndTeacher();
        }

        // print to pdf in first tab
        private void pictureBox_PRINT_Click(object sender, EventArgs e)
        {
            if (dataGridView_reports.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = "Result.pdf";
                bool ErrorMessage = false;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {
                            ErrorMessage = true;
                            MessageBox.Show("Unable to write data to disk: " + ex.Message);
                        }
                    }
                    if (!ErrorMessage)
                    {
                        try
                        {
                            // Creating Document instance
                            Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);

                            // Open the document
                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                            {
                                PdfWriter.GetInstance(document, fileStream);
                                document.Open();

                                // Add HTML content
                                // Add image
                                string imagePath = "../../../../assets/universty 2.png";
                                iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(imagePath);
                                image.Alignment = Element.ALIGN_CENTER;
                                document.Add(image);

                                document.Add(new Paragraph(""));
                               
                                string trackName = comboBox_tRACK.SelectedItem?.ToString();
                                StyleSheet styles = new StyleSheet();

                                document.Add(new Paragraph(""));
                                // Add data table
                                PdfPTable pTable = new PdfPTable(dataGridView_reports.Columns.Count);
                                pTable.DefaultCell.Padding = 2;
                                pTable.WidthPercentage = 100;
                                pTable.HorizontalAlignment = Element.ALIGN_LEFT;

                                // Add headers to PDF table
                                foreach (DataGridViewColumn col in dataGridView_reports.Columns)
                                {
                                    PdfPCell headerCell = new PdfPCell(new Phrase(col.HeaderText));
                                    pTable.AddCell(headerCell);
                                }

                                int totalStudents = 0; // Variable to store the total number of students

                                // Add data rows to PDF table
                                foreach (DataGridViewRow viewRow in dataGridView_reports.Rows)
                                {
                                    foreach (DataGridViewCell dcell in viewRow.Cells)
                                    {
                                        if (dcell.Value != null)
                                        {
                                            pTable.AddCell(dcell.Value.ToString());
                                        }
                                        else
                                        {
                                            pTable.AddCell("Student"); // or any default value you prefer
                                        }
                                    }

                                    // Increment the total number of students for each row processed
                                    totalStudents++;
                                }

                                document.Add(pTable);



                                // Close the document
                                document.Close();

                                MessageBox.Show("Data Exported Successfully", "Info");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error while exporting data: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Records Found", "Info");
            }
        }

        public void student_Tab()
        {
            tabControlReport.SelectedTab = tabPS_Reports; // Select the desired tab

            if (comboBox_Student.SelectedItem != null)
            {
                string selectedStudentId = comboBox_Student.SelectedItem.ToString();
                DateOnly selectedDate = new DateOnly(dateTimePicker2.Value.Year, dateTimePicker2.Value.Month, dateTimePicker2.Value.Day);
                string selectedTeacherId = comboBoxTeachers_students.SelectedItem?.ToString();

                if (!string.IsNullOrEmpty(selectedTeacherId))
                {
                    LoadStudentsByID(selectedStudentId, selectedTeacherId, selectedDate);
                }
                else
                {
                    MessageBox.Show("Please select a teacher.");
                }
            }
            else
            {
                MessageBox.Show("Please select a student.");
            }
        }

        private void LoadStudentsByID(string studentId, string teacherId, DateOnly date)
        {
            string path = @"../../../../../xml/attendance.xml"; // Assuming this is the correct path
            var students = StudentsRepo.GetStudents(path);

            List<Student> filteredStudents = FilterStudentsByStudentIDAndTeacherID(students, studentId, teacherId, date);

            DisplayStudentsById(filteredStudents, teacherId, date);
        }

        private List<Student> FilterStudentsByStudentIDAndTeacherID(List<Student> students, string studentId, string teacherId, DateOnly date)
        {
            List<Student> filteredStudents = new List<Student>();

            foreach (Student student in students)
            {
                bool foundMatchingAttendance = false;

                if (student.ID == int.Parse(studentId))
                {
                    foreach (AttendanceItem attendance in student.AttendaceHistory)
                    {
                        if (attendance.Date == date && attendance.TeacherID == int.Parse(teacherId))
                        {
                            foundMatchingAttendance = true;
                            break; // No need to continue checking attendance for this student once a match is found
                        }
                    }

                    if (foundMatchingAttendance)
                    {
                        filteredStudents.Add(student);
                    }
                }
            }

            return filteredStudents;
        }


        private void DisplayStudentsById(List<Student> students, string selectedTeacherId, DateOnly selectedDate)
        {
            dataGridView1_Students.Rows.Clear();

            foreach (var student in students)
            {
                foreach (var attendanceItem in student.AttendaceHistory)
                {
                    if (attendanceItem.Date == selectedDate && attendanceItem.TeacherID == int.Parse(selectedTeacherId))
                    {
                        dataGridView1_Students.Rows.Add(student.Name, student.TrackName, attendanceItem.TeacherID, attendanceItem.Date, attendanceItem.State);


                    }

                }
            }
        }

        private void comboBoxTeachers_students_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedStudentId = comboBox_Student.SelectedItem?.ToString();
            string selectedTeacherId = comboBoxTeachers_students.SelectedItem?.ToString();
            DateOnly selectedDate = new DateOnly(dateTimePicker2.Value.Year, dateTimePicker2.Value.Month, dateTimePicker2.Value.Day);

            if (!string.IsNullOrEmpty(selectedStudentId) && !string.IsNullOrEmpty(selectedTeacherId))
            {
                LoadStudentsByID(selectedStudentId, selectedTeacherId, selectedDate);
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            string selectedStudentId = comboBox_Student.SelectedItem?.ToString();
            string selectedTeacherId = comboBoxTeachers_students.SelectedItem?.ToString();
            DateOnly selectedDate = new DateOnly(dateTimePicker2.Value.Year, dateTimePicker2.Value.Month, dateTimePicker2.Value.Day);

            if (!string.IsNullOrEmpty(selectedStudentId) && !string.IsNullOrEmpty(selectedTeacherId))
            {
                LoadStudentsByID(selectedStudentId, selectedTeacherId, selectedDate);
            }
        }

        private void comboBox_Student_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedStudentId = comboBox_Student.SelectedItem?.ToString();
            string selectedTeacherId = comboBoxTeachers_students.SelectedItem?.ToString();
            DateOnly selectedDate = new DateOnly(dateTimePicker2.Value.Year, dateTimePicker2.Value.Month, dateTimePicker2.Value.Day);

            if (!string.IsNullOrEmpty(selectedStudentId) && !string.IsNullOrEmpty(selectedTeacherId))
            {
                LoadStudentsByID(selectedStudentId, selectedTeacherId, selectedDate);
            }
        }



        private void pictureBox_print2_Click(object sender, EventArgs e)
        {
            if (dataGridView1_Students.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = "Result.pdf";
                bool ErrorMessage = false;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {
                            ErrorMessage = true;
                            MessageBox.Show("Unable to write data to disk: " + ex.Message);
                        }
                    }
                    if (!ErrorMessage)
                    {
                        try
                        {
                            // Creating Document instance
                            Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);

                            // Open the document
                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                            {
                                PdfWriter.GetInstance(document, fileStream);
                                document.Open();

                                // Add HTML content
                                // Add image
                                string imagePath = "../../../../assets/report_Student.png";
                                iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(imagePath);
                                image.Alignment = Element.ALIGN_CENTER;
                                document.Add(image);

                                string StudentID = comboBox_Student.SelectedItem?.ToString();

                                document.Add(new Paragraph(""));
                                document.Add(new Paragraph(""));


                                // Add data table
                                PdfPTable pTable = new PdfPTable(dataGridView1_Students.Columns.Count);
                                pTable.DefaultCell.Padding = 2;
                                pTable.WidthPercentage = 100;
                                pTable.HorizontalAlignment = Element.ALIGN_LEFT;

                                // Add headers to PDF table
                                foreach (DataGridViewColumn col in dataGridView1_Students.Columns)
                                {
                                    PdfPCell headerCell = new PdfPCell(new Phrase(col.HeaderText));
                                    pTable.AddCell(headerCell);
                                }


                                // Add data rows to PDF table
                                foreach (DataGridViewRow viewRow in dataGridView1_Students.Rows)
                                {
                                    foreach (DataGridViewCell dcell in viewRow.Cells)
                                    {
                                        if (dcell.Value != null)
                                        {
                                            pTable.AddCell(dcell.Value.ToString());
                                        }
                                        else
                                        {
                                            pTable.AddCell("student"); // or any default value you prefer
                                        }
                                    }

                                }

                                document.Add(pTable);

                                // Close the document
                                document.Close();

                                MessageBox.Show("Data Exported Successfully", "Info");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error while exporting data: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Records Found", "Info");
            }

        }





    }
}


