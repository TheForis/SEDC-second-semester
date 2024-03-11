using System.Numerics;

namespace firstExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Demo 1");

            int numberOfUsers;
            numberOfUsers = 20;

            int numberOfClassrooms = 3;

            numberOfClassrooms = 4;
            Console.WriteLine($"Total number of users:{numberOfUsers}");
            Console.WriteLine(numberOfClassrooms);

            Console.WriteLine($"Number of classrooms: {numberOfClassrooms}");


            float averageRate = 4.3f;

            double avergeRate2 = 4.3;

            decimal averageRate3 = 4.3m;

            Console.WriteLine(averageRate);

            char sign = 'a';
            string firstName = "Risto";
            string lastName = "Panchevski";
            Console.WriteLine($"{firstName} {lastName}");

            long bigNumber = 12113214;

            BigInteger bigNUmber2 = 3213123223123123112;

            // Comment here

            int a = 5;
            int b = 7;
            int sum;
            sum = a + b;

            Console.WriteLine(sum);
            b++;
            a += b;

            sum = a + b;
            Console.WriteLine(sum);

            int x = 3;
            int y = 8;

            int sum1 = y + x++;
            int sum2 = y + ++x;

            Console.WriteLine(sum1);
            Console.WriteLine(sum2);

            int n1 = 10;
            int n2 = 3;

            float result = n1 / (float) n2;

            Console.WriteLine(result);

           

            int n3 = 10;
            float n4 = 3f;

            float result2 = n3 / n4;
            Console.WriteLine(result2);


        }
    }
}
