namespace Demo2StreamReaderStreamWriter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string folderPath = "Documents";
            string filePath = @$"{folderPath}\products.txt";

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            //StreamWriter streamW = new StreamWriter(filePath);
            //streamW.WriteLine("New text");
            //streamW.Close();

            //StreamWriter streamW2 = new StreamWriter(filePath,true);
            //streamW2.WriteLine("Another TExt!!!!");
            //streamW2.Close();

            using (var sWriter = new StreamWriter(filePath,true))
            {
                sWriter.WriteLine("First text!");
                sWriter.WriteLine("Second text!");
                sWriter.WriteLine("Third text!");
                
               
            }

            using(var streamRead = new StreamReader(filePath))
            {
                //var line1 = streamRead.ReadLine();
                //var line2 = streamRead.ReadLine();
                //var line3 = streamRead.ReadLine();
                //var line4 = streamRead.ReadLine();
                //var line101 = streamRead.ReadLine();
                List<string> textFileList = new List<string>();
                while (true)
                {
                    string s = streamRead.ReadLine();
                    textFileList.Add(s);

                    if(s== null)
                    {
                        break;
                    }
                }
            }
        }
    }
}
