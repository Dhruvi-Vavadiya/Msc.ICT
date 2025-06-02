using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using log4net.Config;
using log4net;

namespace ConsoleAppLog4Net
{
    internal class Program : AssemblyOne
    {
        //private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod()?.DeclaringType);
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("hello");
        //    var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
        //    XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));

        //    log.Info("Application Started");
        //    log.Debug("This is a debug message.");
        //    log.Error("This is an error message.");

        //    Console.WriteLine("Check the log file in 'Logs/logfile.log'");
        //}
        static void Main(string[] args)

        {

            System.Guid guid = System.Guid.NewGuid();

            Console.WriteLine(guid.ToString());

            //Console.ReadLine();


            AssemblyOne obj = new AssemblyOne(); // ✅ Allowed (same assembly)
            obj.Display(); // ✅ Allowed
            obj.ShowMessage();


        }
    }
}
