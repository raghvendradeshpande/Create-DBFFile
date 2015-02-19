using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace ConcurrencyHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri httpUrl = new Uri("http://localhost:57882/HelloWorldService.svc");
            //Create ServiceHost
            ServiceHost host = new ServiceHost(typeof(ConcurrencyWcfService.Service1), httpUrl);
            //Add a service endpoint
            host.AddServiceEndpoint(typeof(ConcurrencyWcfService.IHelloWorldService), new WSHttpBinding(), "");
            //Enable metadata exchange
            ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
            smb.HttpGetEnabled = true;
            host.Description.Behaviors.Add(smb);
            //Start the Service
            host.Open();
            Console.WriteLine("Service is host at " + DateTime.Now.ToString());
            Console.WriteLine("Host is running... Press <Enter> key to stop");
            Console.ReadLine();
        }
    }
}
