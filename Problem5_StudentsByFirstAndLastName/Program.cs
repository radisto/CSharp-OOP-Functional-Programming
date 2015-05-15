using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        PublicListOfStudents s = new PublicListOfStudents();
        List<Student> students = s.Students;
        var sortedByNames = from student in students
                           orderby student.LastName
                           orderby student.FirstName
                           select student;
        sortedByNames.ToList().ForEach(x => Console.WriteLine(x));
    }
}