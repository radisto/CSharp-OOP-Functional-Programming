using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        PublicListOfStudents s = new PublicListOfStudents();
        List<Student> students = s.Students;
        var weakStudents = from student in students
                                where student.Marks.ContainsTwo(2)
                                select new
                                {
                                    FullName = student.FirstName + ' ' + student.LastName,
                                    Marks = student.Marks
                                };
        weakStudents.ToList().ForEach(x =>
        {
            Console.Write(x.FullName + ' ');
            Console.Write(string.Join(", ", x.Marks.ToArray()));
            Console.WriteLine();
        });
    }
}