using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        PublicListOfStudents s = new PublicListOfStudents();
        List<Student> students = s.Students;
        var newStudents = from student in students
                           where student.FacultyNumber.Substring(4, 2) == "14"
                           select student;
        newStudents.ToList().ForEach(x => Console.WriteLine(x));
    }
}