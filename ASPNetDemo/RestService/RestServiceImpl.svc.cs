using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using DAL;

namespace RestService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RestServiceImpl" in code, svc and config file together.
    public class RestServiceImpl : IRestServiceImpl
    {
        static string sqlconn = System.Configuration.ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
        SqlConnection conn = new SqlConnection(sqlconn);

        public string getJSON(string id)
        {
            //string cs = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
            return "you have request json id" + id;
        }

        public List<Employee> getAllEmployee()
        {

            try
           {
                DBConnect db = new DBConnect();
                DataTable dt = new DataTable();
                dt = db.getAllEmployee();
                var objEmps = dt.AsEnumerable();

                var result2 = objEmps.Select(e => new Employee
                                  { Company = e.Field<string>("City"),
                                    Firstname = e.Field<string>("Employeename")
                                     }).ToList();              
                              
                return result2;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public List<Employee> getEmployeeByID(string id)
        {
            try
            {              
                conn.Open();
                string sqlQuery = String.Format("SELECT EmployeeName,City FROM [UserManagement].[dbo].[Employee]  where Id =" + id);
                SqlCommand sqlcmd = new SqlCommand(sqlQuery, conn);
                sqlcmd.CommandType = CommandType.Text;
                SqlDataAdapter sdaforalbum = new SqlDataAdapter(sqlcmd);
                DataTable Ds = new DataTable();
                sdaforalbum.Fill(Ds);

                var objEmps = Ds.AsEnumerable();

                var result2 = objEmps.Select(e => new Employee
                {
                    Company = e.Field<string>("City"),
                    Firstname = e.Field<string>("Employeename")
                }).ToList();

                conn.Close();
                return result2;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public string updateEmployee(string id, Employee[] emp)
        {
            try
            {
                DBConnect db = new DBConnect();
                string status = db.updateEmployee(id, emp[0].Firstname, emp[0].Company);
                return status;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public string InsertEmployee(Employee[] emp)
        {
            try
            {
                DBConnect db = new DBConnect();
                string status = db.InsertEmployee(emp[0].Firstname, emp[0].Company,  emp[0].Bonus,  emp[0].Salary);
                return status;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }
        
    }
}
