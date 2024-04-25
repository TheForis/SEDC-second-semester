using Microsoft.VisualBasic;
using Serilog;
namespace Demo3Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.File(@"Logs\logs-.txt", rollingInterval:RollingInterval.Hour)
                .MinimumLevel.Information()
                .CreateLogger();
            for (int i = 0; i < 200; i++) 
            {
                var s3 = new Student("Sasho", "Popovski");
                Thread.Sleep(1000);
            }
            var s1 = new Student("Risto", "Panchevski");
            var s2 = new Student("Boris", "Krstovski");
        }
    }
}
