using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Description;
namespace NetTcpConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {

            using (ServiceHost host = new ServiceHost(typeof(WcfServiceLibrary1.Service1)))
            {
                host.Open();
                Console.WriteLine("Press <Enter> to terminate the Host application.");
                Console.ReadLine();
            }

        }
    }
}