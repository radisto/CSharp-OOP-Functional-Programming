using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        PublicListOfStudents s = new PublicListOfStudents();
        List<Student> students = s.Students;
        var studentsByPhone = from student in students
                               where student.Phone.Substring(0, 2) == ("02") || 
                                     student.Phone.Substring(0, 5) == ("+3592") ||
                                     student.Phone.Substring(0, 6) == ("+359 2")
                               select student;
        studentsByPhone.ToList().ForEach(x => Console.WriteLine(x));
    }
}