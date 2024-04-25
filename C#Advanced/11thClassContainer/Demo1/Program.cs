using Demo1.Models;

namespace Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int mil = 1;
            //int bil = 1;
            //for (int i = 0; true; i++)
            //{
            //    var s = new Dictionary<int, User>();
            //    s.Add(1, new User("Boris", "Krstovski"));
            //    s.Add(2, new User("Boris", "Krstovski"));
            //    s.Add(3, new User("Boris", "Krstovski"));
            //    s.Add(4, new User("Boris", "Krstovski"));
            //    s.Add(5, new User("Boris", "Krstovski"));
            //    s.Add(6, new User("Boris", "Krstovski"));
            //    s.Add(7, new User("Boris", "Krstovski"));
            //    s.Add(8, new User("Boris", "Krstovski"));
            //    s.Add(9, new User("Boris", "Krstovski"));

            //    if (i % 1000000 == 0 && i < 1000000000)
            //    {

            //        Console.Write($"~ {mil} mil. ~");
            //        mil++;
            //    }
            //    if (i % 100000000 == 0 && mil > 10)
            //    {
            //        if (bil == 1) { Console.Clear(); }
            //        Console.Write($"~ {bil} bil ~");
            //        bil++;
            //    }
            //}
            string folderPath = "Data";
            string filePath = @$"{folderPath}\CustomText.txt";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }



            for (int i = 0; i < 2; i++)
            {
                CustomWriter write = new CustomWriter(filePath);
                write.WriteLine("Hello again", 5);
                write.WriteLine("Hello again and again", 4);
                write.Dispose();
                Thread.Sleep(5000);
            }

            

            using (var sr = new StreamReader(filePath))
            {
                var content = sr.ReadToEnd();
            }






        }
    }
}
