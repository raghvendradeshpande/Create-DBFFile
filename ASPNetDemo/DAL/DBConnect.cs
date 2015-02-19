using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace DAL
{
    public class DBConnect
    {
        string sqlconn = System.Configuration.ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
        

        public DataTable getAllEmployee()
        {
            SqlConnection sqlDashboardcon = new SqlConnection(sqlconn);
                try
                {
                    
                    sqlDashboardcon.Open();
                    string sqlQuery = String.Format("SELECT EmployeeName,City FROM [UserManagement].[dbo].[Employee]");
                    SqlCommand sqlcmd = new SqlCommand(sqlQuery, sqlDashboardcon);
                    sqlcmd.CommandType = CommandType.Text;
                    SqlDataAdapter sdaforalbum = new SqlDataAdapter(sqlcmd);
                    DataTable Dt = new DataTable();
                    sdaforalbum.Fill(Dt);
                    return Dt;
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                finally
                {
                    sqlDashboardcon.Close();
                }
        }


        public string updateEmployee(string id, string firstName, string city)
        {
            SqlConnection sqlDashboardcon = new SqlConnection(sqlconn);
            try
            {            
                int a = 0;
                sqlDashboardcon.Open();
                string sql2 = "update Employee set EmployeeName = " + "'" + firstName + "'"
                    + "," + "City=" + "'" + city + "'"
                    + " WHERE Id=" + id;
                SqlCommand myCommand2 = new SqlCommand(sql2, sqlDashboardcon);
                a = myCommand2.ExecuteNonQuery();
                sqlDashboardcon.Close();
                return a.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                sqlDashboardcon.Close();
                sqlDashboardcon.Dispose();
            }
        }


        public string InsertEmployee(string firstName, string city, string Bonus, string salary)
        {
            SqlConnection sqlDashboardcon = new SqlConnection(sqlconn);
            try
            {
                int a = 0;
                sqlDashboardcon.Open();
                string sql2 = "insert into Employee(EmployeeName,City,ManagerID,Bonus,Salary) values(" +
                  "'" + firstName + "'" + "," +
                  "'" + city + "'" + "," 
                  + "NULL" + ","
                  + "'" + Bonus + "'" + "," 
                  + "'" + Convert.ToInt16(salary) + "'"
                  + ")";
                   
                SqlCommand myCommand2 = new SqlCommand(sql2, sqlDashboardcon);
                a = myCommand2.ExecuteNonQuery();
                sqlDashboardcon.Close();
                return a.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                sqlDashboardcon.Close();
                sqlDashboardcon.Dispose();
            }
        }
    }
}
