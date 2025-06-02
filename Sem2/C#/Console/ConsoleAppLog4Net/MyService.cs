using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace ConsoleAppLog4Net
{
    internal class MyService
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(MyService));

        public void ProcessData()
        {
            try
            {
                log.Info("ProcessData method started.");
                // Your logic here...
                log.Debug("Processing data...");
            }
            catch (Exception ex)
            {
                log.Error("Error in ProcessData", ex);
            }
        }
    }
}
