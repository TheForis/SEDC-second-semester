﻿namespace ModelsDemo1
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public User(string firstName,string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public string GetFullName { get
            {
                return FirstName +" "+ LastName;
            } }
    }
}
