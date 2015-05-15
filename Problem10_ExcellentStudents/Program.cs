using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        PublicListOfStudents s = new PublicListOfStudents();
        List<Student> students = s.Students;
        var excellentStudents = from student in students
                               where student.Marks.Contains(6)
                               select new
                               {
                                   FullName = student.FirstName + ' ' + student.LastName,
                                   Marks = student.Marks
                               };
        excellentStudents.ToList().ForEach(x => 
        {
            Console.Write(x.FullName + ' ');
            Console.Write(string.Join(", ", x.Marks.ToArray()));
            Console.WriteLine();
        });
    }
}