using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: log4net.Config.XmlConfigurator(Watch=true)]

namespace ConsoleUI
{
    class Program
    {
        private static readonly log4net.ILog log = LogHelper.GetLogger(); // log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // log.Error("This is my error msg");
            log.Debug("Developer: Tutorial was run");
            log.Info("Maintanance: Water pump turned on");
            log.Warn("Maintanace: The water pump is getting hot");

            var i = 0;

            try
            {
                var x = 10 / i;
            }
            catch (DivideByZeroException ex)
            {
                log.Error("Developer: we tried to divide by zero again", ex);
            }

            log.Fatal("Maintanace: water pump exploded");

            Console.ReadLine();
        }
    }
}
