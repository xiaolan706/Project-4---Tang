using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_4_Course_Capston__Tang
{
    public class GetCourse2
    {
        // Create variables to save values
        private int coursesNumber;
        private string studentsName;
        private string meetingDate;
        private string courseSubject;
        private string courseSection;

        // Provide an interface to save values
        public void setVariables(int coursesNumber, string studentsName, string meetingDate,
            string courseSubject, string courseSection)
        {
            this.coursesNumber = coursesNumber;
            this.studentsName = studentsName;
            this.meetingDate = meetingDate;
            this.courseSubject = courseSubject;
            this.courseSection = courseSection;
        }

        // Provide an interface to get values
        public void getVariables(ref int coursesNumber, ref string studentsName, ref string meetingDate,
            ref string courseSubject, ref string courseSection)
        {
            coursesNumber = this.coursesNumber;
            studentsName = this.studentsName;
            meetingDate = this.meetingDate;
            courseSubject = this.courseSubject;
            courseSection = this.courseSection;
        }

    }
}
