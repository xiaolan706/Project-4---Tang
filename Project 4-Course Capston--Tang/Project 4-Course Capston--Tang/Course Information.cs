using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_4_Course_Capston__Tang
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'course_InformationDataSet.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.course_InformationDataSet.Course);
            // TODO: This line of code loads data into the 'course_InformationDataSet.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.course_InformationDataSet.Course);

        }

        private void courseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.courseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.course_InformationDataSet);

        }

        private void courseBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.courseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.course_InformationDataSet);

        }

        // Create a custom exception
        public class OverRangeException : Exception
        {
            public OverRangeException()
            { }
            public OverRangeException(string message)
                : base(message)
            { }
            public OverRangeException(string message, Exception inner)
                : base(message, inner)
            { }
        }

        // Create a custom class for CustomClassOne 
        Course1 c1 = new Course1();

        // declear a variable to track the click number of the Set button
        int changeCount = 0;

        // check if a strig contains just letters.
        private bool isAllLetters(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsLetter(c))
                    return false;
            }
            return true;
        }

        private void btnSet_Click(object sender, EventArgs e)
        {

            // Handle the exceptions of courseNumber
            try
            {
                short x = 0;
                bool res = Int16.TryParse(txtCoursesNumber1.Text, out x);
                if (res == false)
                    throw new FormatException("Course's Number should enter an integer");
                if (x < 1 || x > 7)
                    throw new OverRangeException("Number must be in range 1 to 7");
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message + "\n\n"
                    + "Please enter an integer in the Course's Number field", "Entry Error");
                return;
            }
            catch (OverRangeException ex)
            {
                MessageBox.Show(ex.Message + "\n\n"
                    + "Please enter a number between 1 to 7", "Entry Error");
                return;
            }


            // Save values from textboxes to variables
            int coursesNumber = Convert.ToInt16(txtCoursesNumber1.Text);
            string studentsName = txtStudentsName1.Text;
            string meetingDate = cdrMeetingDate1.SelectionRange.Start.ToShortDateString();
            string courseSubject = courseComboBox.Text;
            RadioButton selectedButton = null;
            if (rdoHybrid.Checked == true)
            {
                selectedButton = rdoHybrid;
            }
            else if (rdoOnline.Checked == true)
            {
                selectedButton = rdoOnline;
            }
            string courseSection = selectedButton.Text;


            // Check the name components
            // Split a string delimited by characters and return all non-empty elements.
            string[] stringSeparators = new string[] { " " };
            string[] names = studentsName.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);
            // Check how many components user enter
            // If it's not 2 components(first name and last name), a message box will show up.
            int length = names.GetLength(0);
            if (length != 2)
            {
                MessageBox.Show("Student's Name must be the first name and last name."+"\n\n"
                    + "For example: 'Tom Ford'.", "Format Entry Error");
                return;
            }
            // Check if the name components are all letters. If not, a message box will show up. 
            foreach (var name in names)
            {
                bool isAllLetters = this.isAllLetters(name);
                if (isAllLetters == false)
                {
                    MessageBox.Show("Only letter will be accepted in Student's Name field." + "\n\n"
                    + "For example: 'Tom Ford'.", "Entry Error");
                    return;
                }
            }
            

            // Track the number of clicks on the Set button.
            // If the numbers of clicks is more than 1 time, and tracking a value changed,
            // a message box will show up
            if (changeCount != 0)
            {
                // Create variables for the old value
                int oldCoursesNumber = 0;
                string oldStudentsName = "";
                string oldMeetingDate = "";
                string oldCourseSubject = "";
                string oldCourseSection = "";

                // Get old values from CustomClassOne
                c1.getVariables(ref oldCoursesNumber, ref oldStudentsName, ref oldMeetingDate,
                    ref oldCourseSubject, ref oldCourseSection);

                // compare the old value and the new value, if it changed, a message box will show up.
                if (oldCoursesNumber != coursesNumber)
                {
                    MessageBox.Show("Course's Number has changed" + "\n\n"
                    + "The new value is '" + coursesNumber + "'.", "Message Change Warning");
                }
                else if (oldStudentsName != studentsName)
                {
                    MessageBox.Show("Student's Name value has changed" + "\n\n"
                    + "The new value is '" + studentsName + "'.", "Message Change Warning");
                }
                else if (oldMeetingDate != meetingDate)
                {
                    MessageBox.Show("Meeting Date value has changed" + "\n\n"
                    + "The new value is '" + meetingDate + "'.", "Message Change Warning");
                }
                else if (oldCourseSubject != courseSubject)
                {
                    MessageBox.Show("Course Subject value has changed" + "\n\n"
                    + "The new value is '" + courseSubject + "'.", "Message Change Warning");
                }
                else if (oldCourseSection != courseSection)
                {
                    MessageBox.Show("Meeting Date value has changed" + "\n\n"
                    + "The new value is '" + courseSection + "'.", "Message Change Warning");
                }
            }
            changeCount++;

            // Save values to CustomClassOne
            c1.setVariables(coursesNumber, studentsName, meetingDate, courseSubject, courseSection);
            

        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            // declear variables to save values from CustomClassOne
            int coursesNumber = 0;
            string studentsName = "";
            string meetingDate = "";
            string courseSubject = "";
            string courseSection = "";

            // use CustomClassOne interface to get value from CustomClassTwo
            c1.getVariables(ref coursesNumber, ref studentsName, ref meetingDate,
                ref courseSubject, ref courseSection);

            // display values in the course information on the form
            txtCoursesNumber2.Text = Convert.ToString(coursesNumber);
            txtStudentsName2.Text = studentsName;
            txtMeetingDate.Text = meetingDate;
            txtCourseSubject.Text = courseSubject;
            txtCourseSection.Text = courseSection;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // close the form
            this.Close();
        }
    }
};
