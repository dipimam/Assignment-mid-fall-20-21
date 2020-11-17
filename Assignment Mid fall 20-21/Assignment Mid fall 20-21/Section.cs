using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Mid_fall_20_21
{
    class Section
    {
        private string sectionName { get; set; }
        Teacher teacherName;

        public Section(string sectionName)
        {
            this.sectionName = sectionName;
        }

        public void addTeacher(Teacher teacherName)
        {
            if (teacherName.totalHoursOfClass < 21)
            {
                this.teacherName = teacherName;
            }
            else
            {
                Console.WriteLine("Can not add another course");
            }
        
        }

        public void showDetails()
        {
            Console.WriteLine("Section name is " + sectionName);
            teacherName.showTeacherDetails();
        }
    }
}
