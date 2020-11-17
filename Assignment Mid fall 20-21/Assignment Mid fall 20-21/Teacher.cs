using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Mid_fall_20_21
{
    class Teacher
    {
        private string teacherName {set;  get; }
        private string teacherId { set; get; }
        public double totalHoursOfClass { set; get; }

        Section[] sectionName = new Section[100];
        private int countSection = 0;

        public Teacher(string teacherName, string teacherId, double totalHoursOfClass)
        {
            this.teacherName = teacherName;
            this.teacherId = teacherId;
            this.totalHoursOfClass = totalHoursOfClass;
        }

        public void addSection(Section sectionName)
        {
            this.sectionName[countSection] = sectionName;
            countSection++;
            totalHoursOfClass += 1.5;
        }

        public void showTeacherDetails()
        {
            Console.WriteLine("teacher name is " + teacherName);
            Console.WriteLine("Teacher id is " + teacherId);
        }

        public void showSectionDetails()
        {
            foreach(Section i in sectionName)
            {
                i.showDetails();
            }
        }
    }
}
