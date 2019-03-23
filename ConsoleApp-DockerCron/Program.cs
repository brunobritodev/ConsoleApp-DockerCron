using System;
using System.IO;
using System.Threading;

namespace ConsoleApp_DockerCron
{
    class Program
    {
        public static void Main(params string[] args)
        {
            Thread.Sleep(TimeSpan.FromSeconds(10));
            try
            {
                File.AppendAllText("log", $"I'm alive: {DateTime.Now}{Environment.NewLine}");

                File.WriteAllText("healtcheck", "1");
            }
            catch (Exception)
            {
                File.WriteAllText("healtcheck", "0");
                Environment.ExitCode = 1;
            }
            
        }
    }
}
