using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        PublicListOfStudents s = new PublicListOfStudents();
        List<Student> students = s.Students;
        var sortedByNames = students.OrderBy(x => x.FirstName).ThenBy(x => x.LastName).ToList();
        sortedByNames.ForEach(x => Console.WriteLine(x));
    }
}