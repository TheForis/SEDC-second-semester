﻿using Serilog;

namespace Demo3Logger
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Student (string firstName,string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Log.Information($"New student created {FirstName} {LastName}");
        }
    }
}
