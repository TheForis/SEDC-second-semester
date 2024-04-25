using System.Text;

namespace DemoFileWrite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Здраво, Свету!");
            string absolutePath = @"C:\Users\Boris Visual Code\Desktop\Repositories\AbsoluteFilePath";
            string relativePath = @"FileFolder\file1.txt";

            string currentPath = Directory.GetCurrentDirectory();
            Console.WriteLine(currentPath);



            /* if(!Directory.Exists(@"C:\Users\Boris Visual Code\Desktop\Repositories\SEDC-second-semester\C#Advanced\10thClassContainer\Test"))
             {
                 Directory.CreateDirectory(@"C:\Users\Boris Visual Code\Desktop\Repositories\SEDC-second-semester\C#Advanced\10thClassContainer\Test");
             }
             if (!Directory.Exists("Files"))
             {
                 Directory.CreateDirectory("Files");
             }

             if (!File.Exists(@"Files\text.txt"))
             {
                 File.Create(@"Files\text.txt");
             }*/

            List<string> students = new List<string>() { "Risto", "Slave", "Sasho" };
            var folderPath = "Documents";
            var filePath = @$"{folderPath}\students.txt";

            //File.WriteAllText(@"Documents\testFile.txt", "Simple text");   - Raboti ama sekogash e podobro so proverka


            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            if (!File.Exists(filePath))
            {
                FileStream file = File.Create(filePath);
                file.Close();
            }

            File.WriteAllText(filePath, "Simple text");
            File.WriteAllText(filePath, "Something else");

            File.WriteAllLines(filePath, students);
            File.AppendAllText(filePath, "New text added!");
            File.AppendAllText(filePath, "\n");
            File.AppendAllLines(filePath, students);


            var text = File.ReadAllText(filePath);
            var textLines = File.ReadAllLines(filePath).ToList();

            var newTextLines = textLines.Select((x, index) => $"{index + 1}. {x}!").ToList();
            File.WriteAllLines(filePath, newTextLines);

            File.Delete(filePath);
            Directory.Delete(folderPath);
        }

    }
}
