using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Mid_fall_20_21
{
    class Management
    {
        public void start()
        {
            Department cse = new Department("CSE");
            Course csharp = new Course("C#", "301");
            Course java = new Course("Java", "201");
            cse.addCourse(csharp);
            cse.addCourse(java);
            Section a = new Section("A");
            Section b = new Section("B");
            csharp.addSection(a);
            csharp.addSection(b);
            Teacher tanvirAhmed = new Teacher("Tanvir Ahmed", "1987-456-451", 15.5);
            tanvirAhmed.addSection(a);
            tanvirAhmed.addSection(b);
            a.addTeacher(tanvirAhmed);
            b.addTeacher(tanvirAhmed);
            csharp.showSectionAndTeacher();
            tanvirAhmed.showSectionDetails();


            
        }

    }
}
