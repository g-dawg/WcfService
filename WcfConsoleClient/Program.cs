using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfConsoleClient
{
    class Program
    {
        private static  WcfServiceHost.Service1Client client = null;

        static void Main(string[] args)
        {
            client = new WcfServiceHost.Service1Client();
            CallService();    
        }

        private static void CallService()
        {
            ConsoleKeyInfo cki;
            while (true)
            {
                Console.WriteLine("Press any key to call service, Press ESC to end.");
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.Escape)
                    break;

                Console.WriteLine(Environment.NewLine);
                Console.WriteLine(client.GetData(cki.KeyChar.ToString()).ToString());
            }
        }
    }
}
