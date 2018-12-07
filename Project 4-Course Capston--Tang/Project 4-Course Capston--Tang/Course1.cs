using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_4_Course_Capston__Tang
{
    public class Course1
    {
        // Create a custom class for CustomClassTwo 
        GetCourse2 get2 = new GetCourse2();

        // Provide an interface to the form, calling the interface in CustomClassTwo to save values.
        public void setVariables(int coursesNumber, string studentsName, string meetingDate,
            string courseSubject, string courseSection)
        {
            get2.setVariables(coursesNumber, studentsName, meetingDate, courseSubject, courseSection);
        }

        // Provide an interface to the form to get values from the CustomClassTwo
        public void getVariables(ref int coursesNumber, ref string studentsName, ref string meetingDate,
            ref string courseSubject, ref string courseSection)
        {
           get2.getVariables(ref coursesNumber, ref studentsName, ref meetingDate,
                ref courseSubject, ref courseSection);
        }


    }
}
