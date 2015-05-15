using System.Collections.Generic;

public class PublicListOfStudents
{
    public List<Student> Students
    {
        get
        {
            return new List<Student>()
            {
                new Student("Peter", "Vasilev", 17, "NX021365", "+3592 6062230", "pvasilev@abv.bg", new List<int>(){2, 3, 4}, "0"),
                new Student("Georgi", "Ivanov", 24, "NX021451", "+359876543210", "goshoivanov@abv.bg", new List<int>() { 6, 5, 5 }, "0"),
                new Student("Peter", "Petrov", 22, "NX021542", "02 702 50 30", "ppetrov@gmail.com", new List<int>() { 4, 6, 5 }, "0"),
                new Student("Ivan", "Mihailov", 20, "NX021433", "+44 553 220 928", "ivanmihailov@abv.bg", new List<int>() { 2, 3, 2 }, "0"),
                new Student("Vasil", "Georgiev", 27, "NX021354", "+359 23495120", "vgeorgiev@gmail.com", new List<int>() { 3, 2, 5 }, "0")
            };
        }
    }
}