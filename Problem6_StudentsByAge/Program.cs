using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        PublicListOfStudents s = new PublicListOfStudents();
        List<Student> students = s.Students;
        var onlyNamesAndAge = from student in students
                           where student.Age >= 18 && student.Age <= 24
                           select new { student.FirstName, student.LastName, student.Age };
        List<Student> result = onlyNamesAndAge.AsEnumerable()
                          .Select(o => new Student
                          {
                              FirstName = o.FirstName,
                              LastName = o.LastName,
                              Age = o.Age
                          }).ToList();
        result.ForEach(x => Console.WriteLine(x));
    }
}