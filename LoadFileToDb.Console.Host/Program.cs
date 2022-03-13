using LoadFileToDb.WcfLoadFileSrv;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace LoadFileToDb.MySrvHost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (var serviceHost = new ServiceHost(typeof(ProcessFileToDBSrv)))
                {
                    serviceHost.Open();
                    Console.WriteLine("Host Started @ " + DateTime.Now.ToString());
                    Console.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "  " +
                                  ex.StackTrace);
                Console.ReadLine();
            }
        }
    }
}
