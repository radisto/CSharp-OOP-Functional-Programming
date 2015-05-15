using System;
using System.Linq;
using System.Collections.Generic;

static class Program
{
    static void Main()
    {
        PublicListOfStudents s = new PublicListOfStudents();
        List<Student> students = s.Students;
        var sortedByName = from student in students
                                        orderby student.FirstName
                                        select student;
        sortedByName.ToList().ForEach(x => Console.WriteLine(x));
    }
}