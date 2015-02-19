using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFFault
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);


        [OperationContract]
        int Multiply(int num1, int num2);

        [OperationContract]
        [FaultContract(typeof(MyExceptionContainer))]
        int Divide(int num1, int num2);

        [OperationContract]
        int Increment();
        // TODO: Add your service operations here
    }

    [DataContract]
    public class MyExceptionContainer
    {
        [DataMember]
        public string Messsage { get; set; }
        [DataMember]
        public string Description { get; set; }
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }


    [ServiceContract]
    public interface IFooService
    {
        [OperationContract]
        string FooMethod1();

        [OperationContract]
        string FooMethod2();
    }

    [ServiceContract]
    public interface IBarService
    {
        [OperationContract]
        string BarMethod1();

        [OperationContract]
        string BarMethod2();
    }
}
