namespace Demo1.Models
{
    public class CustomWriter
    {
        private string _path;
        private StreamWriter _sw;
        private bool _disposed = false;

        public CustomWriter(string path)
        {
            _path = path;
            _sw = new StreamWriter(path,true);
        }
        public void WriteLine (string line,int number)
        {
            _sw.WriteLine($"{DateTime.Now} - {number}: {line}");
            _sw.Flush();
            
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed == true)
                return;
            if(disposing )
            {

            }
            
            _sw.Dispose();
            _path = null;

        }
        public void Dispose()
        {
            Dispose(true);


        }
        ~CustomWriter()
        {
            Dispose(false);
        }



    }
}
