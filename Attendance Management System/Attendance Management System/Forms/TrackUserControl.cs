using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Attendance_Management_System.Models;

namespace Attendance_Management_System.Forms
{
    public partial class TrackUserControl : UserControl
    {
        public TrackUserControl()
        {
            InitializeComponent();
        }



        private void addTrackBtn_Click(object sender, EventArgs e)
        {

            // get track name
            string trackName = TrackNameInput.Text.Trim();

            // check if the track name is empty
            if (trackName == "")
            {
                MessageBox.Show("Please enter a track name");
                return;
            }

            // read the XML file
            XmlDocument doc = XMLControl.ReadAllDocument();

            // select the tracks node thats under the root node
            XmlNode tracksNode = doc.SelectSingleNode("/attendanceSystem/tracks");

            // create a new track node
            XmlNode trackNode = doc.CreateElement("track");

            // create a new name node
            XmlNode nameNode = doc.CreateElement("name");
            nameNode.InnerText = trackName;

            // create a new teachers node
            XmlNode teachersNode = doc.CreateElement("teachers");

            // append the name node to the track node
            trackNode.AppendChild(nameNode);

            // append the teachers node to the track node
            trackNode.AppendChild(teachersNode);

            // append the track node to the tracks node
            tracksNode.AppendChild(trackNode);

            // save the XML file
            doc.Save(XMLControl.GetXMLPath());

            // show success message
            MessageBox.Show("Track added successfully");

            // clear the input
            TrackNameInput.Text = "";

            // switch to search 
            tabTrack.SelectedIndex = 1;


        }

        private void handleSwitchTabsInTracks(object sender, EventArgs e)
        {
            // get the tab index
            int tabIndex = tabTrack.SelectedIndex;

            if (tabIndex == 1)
            {
                //read the xml file
                XmlDocument doc = XMLControl.ReadAllDocument();

                // get the tracks from the xml file
                XmlNodeList tracks = doc.SelectNodes("/attendanceSystem/tracks/track");

                // clear the grid view
                dataGridTrack.Rows.Clear();

                //get the number of teachers & students for each track
                foreach (XmlNode track in tracks)
                {
                    // get the track name
                    string trackName = track.SelectSingleNode("name").InnerText;

                    //teachers in the track
                    int noTeachers = track.SelectNodes("teachers/teacherID").Count;

                    //students in users by document we have
                    int noStudents = doc.SelectNodes($"//users/students/student[trackName='{trackName}']").Count;

                    // add the track to the grid view
                    dataGridTrack.Rows.Add(trackName, noStudents, noTeachers);

                }
            }

            if (tabIndex == 2)
            {
                // if no selected track from the grid view we return and show a message
                if (selectedTrackName == "")
                {
                    MessageBox.Show("Please select a track from the grid view");
                    tabTrack.SelectedIndex = 1;
                    return;
                }
                else
                {
                    // put the selected track name in the input
                    trackNameEditInput.Text = selectedTrackName;

                }
            }
        }

        private void editTrack_cellClick(object sender, DataGridViewCellEventArgs e)
        {

            // if the user clicks on the header we return
            if (e.RowIndex < 0) return;

            // get the selected track name from selected row
            selectedTrackName = dataGridTrack.Rows[e.RowIndex].Cells[0].Value.ToString();

            // switch to the edit tab
            tabTrack.SelectedIndex = 2;

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            //update track name in the xml file
            string newTrackName = trackNameEditInput.Text.Trim();

            // check if the track name is empty
            if (newTrackName == "")
            {
                MessageBox.Show("Please enter a track name");
                return;
            }

            // read the XML file
            XmlDocument doc = XMLControl.ReadAllDocument();

            // get the tracks node
            XmlNode tracksNode = doc.SelectSingleNode("/attendanceSystem/tracks");

            // get the track node that has the selected track name
            XmlNode trackNode = tracksNode.SelectSingleNode($"track[name='{selectedTrackName}']");

            // update the track name
            trackNode.SelectSingleNode("name").InnerText = newTrackName;

            // save the XML file
            doc.Save(XMLControl.GetXMLPath());

            // show success message
            MessageBox.Show("Track updated successfully");

            //clear the input
            trackNameEditInput.Text = "";

            // switch to search
            tabTrack.SelectedIndex = 1;

            // clear the selected track name
            selectedTrackName = "";
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            //make warning message
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this track?", "Warning", MessageBoxButtons.YesNo);

            // if the user clicks no we return
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            // read the XML file 
            XmlDocument doc = XMLControl.ReadAllDocument();

            // get the tracks node
            XmlNode tracksNode = doc.SelectSingleNode("/attendanceSystem/tracks");

            // get the track node that has the selected track name
            XmlNode trackNode = tracksNode.SelectSingleNode($"track[name='{selectedTrackName}']");

            // remove the track node
            tracksNode.RemoveChild(trackNode);

            //remove all students that have trackName 

            // get the students node
            XmlNode studentsNode = doc.SelectSingleNode("/attendanceSystem/users/students");

            // get the students that have the selected track name
            XmlNodeList students = studentsNode.SelectNodes($"student[trackName='{selectedTrackName}']");

            // remove the students
            foreach (XmlNode student in students)
            {
                studentsNode.RemoveChild(student);
            }
            // remove the track from teacher track 

            /**
             * <teachers>
      <teacher>
        <id>3</id>
        <name>nasr</name>
        <email>nasr@gmail.com</email>
        <password>123456a@</password>
        <birthDate>15-4-2020</birthDate>
        <mobileNo>01141600900</mobileNo>
        <hiringDate>4-7-2020</hiringDate>
        <salary>10000</salary>
        <tracks>
          <trackName>PD</trackName>
          <trackName>OS</trackName>
        </tracks>
      </teacher>
      <teacher>
        <id>4</id>
        <name>ayman</name>
        <email>ayman@gmail.com</email>
        <password>123456a@</password>
        <birthDate>15-4-2020</birthDate>
        <mobileNo>01141600901</mobileNo>
        <hiringDate>4-7-2020</hiringDate>
        <salary>10000</salary>
        <tracks>
          <trackName>PD</trackName>
          <trackName>OS</trackName>
        </tracks>
             */
            XmlNode teachersNode = doc.SelectSingleNode("/attendanceSystem/users/teachers");

            // get the teachers that have the selected track name
            XmlNodeList teachers = teachersNode.SelectNodes($"teacher/tracks[trackName='{selectedTrackName}']");

            // remove trackName node from tracks 
            foreach (XmlNode teacher in teachers)
            {
                teacher.RemoveChild(teacher.SelectSingleNode($"trackName[text()='{selectedTrackName}']"));
            }


            // save the XML file
            doc.Save(XMLControl.GetXMLPath());

            // show success message
            MessageBox.Show("Track deleted successfully", "Success");

            // switch to search
            tabTrack.SelectedIndex = 1;
        }

        private void searchInput_TextChanged(object sender, EventArgs e)
        {
            // get the search input
            string searchText = searchInput.Text.Trim();

            // read the xml file
            XmlDocument doc = XMLControl.ReadAllDocument();

            //get the tracks that match contains the search input case insensitive
            XmlNodeList tracks = doc.SelectNodes($"/attendanceSystem/tracks/track[contains(translate(name, 'ABCDEFGHIJKLMNOPQRSTUVWXYZ', 'abcdefghijklmnopqrstuvwxyz'), '{searchText.ToLower()}')]");

            // clear the grid view
            dataGridTrack.Rows.Clear();

            //get the number of teachers & students for each track
            foreach (XmlNode track in tracks)
            {
                // get the track name
                string trackName = track.SelectSingleNode("name").InnerText;

                //teachers in the track
                int noTeachers = track.SelectNodes("teachers/teacherID").Count;

                //students in users by document we have
                int noStudents = doc.SelectNodes($"//users/students/student[trackName='{trackName}']").Count;

                // add the track to the grid view
                dataGridTrack.Rows.Add(trackName, noStudents, noTeachers);

            }







        }
    }
}
