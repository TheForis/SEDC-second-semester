﻿namespace Demo1Classes
{
    public class Human
    {
        public string FirstName { get; set; } = "Trololo";
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public string FullName { get 
            {
                return FirstName + " " + LastName;
            }
        }
        public Human ()
        {

        }
        public Human(string firstName, string lastName, DateTime dateOfBirth) 
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }

        public string GetPersonStats()
        {
            /*return $"{FirstName} {LastName} [{DateOfBirth}]";*/
            return $"{FullName} -> [{DateOfBirth}]";
        }

    }
}
