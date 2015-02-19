using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading;

namespace ConcurrencyWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Single)]
    public class Service1 : IHelloWorldService
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public int i;
        public void Call(string ClientName)
        {
            // increment instance counts
            i++;
            // display client name, instance number , thread number and time when 
            // the method was called
            Console.WriteLine("Client name :" + ClientName + " Instance:" +
              i.ToString() + " Thread:" + Thread.CurrentThread.ManagedThreadId.ToString() +
              " Time:" + DateTime.Now.ToString() + "\n\n");
            // Wait for 5 seconds
            Thread.Sleep(5000);
        }
    }
}
