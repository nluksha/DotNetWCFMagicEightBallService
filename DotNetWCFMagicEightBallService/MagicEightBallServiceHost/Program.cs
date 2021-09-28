using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using DotNetWCFMagicEightBallService;

namespace MagicEightBallServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" *** Host *** ");

            using (var serviceHost = new ServiceHost(typeof(MagicEightBallService)))
            {
                serviceHost.Open();
                Console.WriteLine("The service is ready");
                Console.WriteLine("Press th Enter key to terminate service.");
            }

            Console.ReadLine();
        }
    }
}
