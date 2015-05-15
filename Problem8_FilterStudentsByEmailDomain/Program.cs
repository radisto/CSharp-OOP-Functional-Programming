using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        PublicListOfStudents s = new PublicListOfStudents();
        List<Student> students = s.Students;
        var studentsByDomain = from student in students
                               where student.Email.Contains("@abv.bg")
                               select student;
        studentsByDomain.ToList().ForEach(x => Console.WriteLine(x));
    }
}