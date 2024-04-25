namespace DataWriteApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string folderPath = "Files";
            string filePath = @"Files\names.txt";

            if(!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            
            if(!File.Exists(filePath))
            {
                File.Create(filePath);
            }

            Strea

        }
    }
}
