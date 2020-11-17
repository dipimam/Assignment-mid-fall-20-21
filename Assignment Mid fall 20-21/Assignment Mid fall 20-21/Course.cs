using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Mid_fall_20_21
{
    class Course
    {
        private string courseName { set; get; }
        private string courseId { set; get; }

        Section[] sectionName = new Section[100];
        private int countSection = 0;


        public Course(string courseName, string courseId)
        {
            this.courseName = courseName;
            this.courseId = courseId;
        }

        public void addSection(Section sectionName)

        {

            this.sectionName[countSection++] = sectionName;
        }
        public void showSectionAndTeacher()
        {
            foreach(Section i in sectionName)
            {
                i.showDetails();
            }
        }
    }
}
