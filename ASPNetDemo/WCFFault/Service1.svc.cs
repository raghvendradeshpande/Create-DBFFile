using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFFault
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)] 
    public class Service1 : IService1
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

        public int Multiply(int num1, int num2)
        {
            if (num1 == 0 || num2 == 0)
            {
                throw new Exception("Please pass only non zero numbers");
            }

            return num1 * num2;
        }

        public int Divide(int num1, int num2)
        {

            if (num1 == 0 || num2 == 0)
            {
                MyExceptionContainer exceptionDetails = new MyExceptionContainer();
                exceptionDetails.Messsage = "Business Rule violatuion";
                exceptionDetails.Description = "The numbers should be non zero to perform this operation";
                throw new FaultException<MyExceptionContainer>(exceptionDetails);
            }

           
                return num1 / num2;           
        }

        private int intCounter;
        public int Increment()
        {
            intCounter++;
            return intCounter;
        }

    }

    public class FooService : IFooService, IBarService
    {
        public string FooMethod1()
        {
            return "FooMethod1";
        }

        public string FooMethod2()
        {
            return "FooMethod2";
        }

        public string BarMethod1()
        {
            return "BarMethod1";
        }

        public string BarMethod2()
        {
            return "BarMethod2";
        }
    }
}
