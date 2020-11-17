using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Mid_fall_20_21
{
    class Department
    {
        private string departmentName { set; get; }
        Course[] courseName = new Course[100];
        private int countCourse = 0;

        public Department(string departmentName)
        {
            this.departmentName = departmentName;
        }

        public void showInfo()
        {
            Console.WriteLine(departmentName);
        }
        public void addCourse(Course courseName)
        {
            this.courseName[countCourse++] = courseName;
        }
    }
}
