﻿using System.Collections.Generic;

public class Student
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public int Age { get; set; }

    public string FacultyNumber { get; set; }

    public string Phone { get; set; }

    public string Email { get; set; }

    public IList<int> Marks { get; set; }

    public string GroupNumber { get; set; }

    public Student()
    {

    }

    public Student(string firstName, string lastName, int age, string facultyNumber, string phone, string email, IList<int> marks, string groupNumber)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
        this.FacultyNumber = facultyNumber;
        this.Phone = phone;
        this.Email = email;
        this.Marks = marks;
        this.GroupNumber = groupNumber;
    }

    public override string ToString()
    {
        return string.Format("Name: {0} {1} Age: {2} FacultyNo: {3}\nPhone: {4} Email: {5}", this.FirstName, this.LastName, this.Age, this.FacultyNumber, this.Phone, this.Email);
    }
}