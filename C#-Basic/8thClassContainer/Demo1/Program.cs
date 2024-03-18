﻿namespace Demo1

{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            List<string> names = new List<string>();/*
            List<User> users = new List<User>();*/

            //List<int> numbers2;

            //Console.WriteLine(numbers.Count);
            //Console.WriteLine(numbers2.Count);

            numbers.Add(2);
            numbers.Add(5);
            numbers.Add(250);
            numbers.Add(300);

            names.Add("Slave");
            names.Add("Risto");

            /*users.Add(new User()
            {
                FirstName = "Risto",
                LastName = "Panchevski"
            });*/

            List<int> largeNumbers = new List<int>() { 1000,1001,1200};
            largeNumbers.Add(1500);

            numbers.AddRange(largeNumbers);
/*
            User user2 = users[1];*/
    
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            numbers.ForEach(Console.Write);

            bool canIRemove = numbers.Remove(1000);
            numbers.RemoveAt(2);
            Console.WriteLine(canIRemove);
            numbers.RemoveAll(x => x > 1000);

            for(int i=0; i<numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            numbers.ForEach(number =>
            {
                Console.WriteLine(number);
            });

        }
    }
}
