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

                DisplayHost(serviceHost);

                Console.WriteLine("The service is ready");
                Console.WriteLine("Press th Enter key to terminate service.");
            }

            Console.ReadLine();
        }

        static void DisplayHost(ServiceHost host)
        {
            Console.WriteLine();
            Console.WriteLine("*** Host info ***");
            foreach (var se in host.Description.Endpoints)
            {
                Console.WriteLine($"Address: {se.Address}");
                Console.WriteLine($"Binding: {se.Binding.Name}");
                Console.WriteLine($"Contract: {se.Contract.Name}");
                Console.WriteLine();
            }
            Console.WriteLine("*****************");
        }
    }
}
