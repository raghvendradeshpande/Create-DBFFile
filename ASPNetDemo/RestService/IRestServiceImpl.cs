using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;

namespace RestService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IRestServiceImpl" in both code and config file together.
    [ServiceContract]
    public interface IRestServiceImpl
    {
        [OperationContract]
        [WebInvoke(Method="GET",ResponseFormat=WebMessageFormat.Json,BodyStyle=WebMessageBodyStyle.Wrapped,UriTemplate="json/{id}")]
        string getJSON(string id);

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "employee/{id}")]
        List<Employee> getEmployeeByID(string id);

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "getAllEmployee")]
        List<Employee> getAllEmployee();

        [OperationContract]
        [WebInvoke(Method = "PUT", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "employee/updateEmployee/{id}")]
        string updateEmployee(string id, Employee[] emp);

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "employee/insertEmployee")]
        string InsertEmployee(Employee[] emp);
    }

     [DataContract]
    public class Employee
    {
        string CompanyName;
        string FirstName;
        string bonus;
        string salary;

        [DataMember]
        public string Company
        {
            get { return CompanyName; }
            set { CompanyName = value; }
        }

        [DataMember]
        public string Firstname
        {
            get { return FirstName; }
            set { FirstName = value; }
        }

        [DataMember]
        public string Bonus
        {
            get { return bonus; }
            set { bonus = value; }
        }

        [DataMember]
        public string Salary
        {
            get { return salary; }
            set { salary = value; }
        }
    }
}
