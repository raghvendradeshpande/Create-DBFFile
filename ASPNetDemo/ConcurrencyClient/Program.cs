using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConcurrencyClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Client name");
            string str = Console.ReadLine();
            ServiceReference1.HelloWorldServiceClient obj =
                         new ServiceReference1.HelloWorldServiceClient();

            for (int i = 0; i < 3; i++)
            {
                obj.Call(str);
            }
            Console.ReadLine();
        }
    }
}
