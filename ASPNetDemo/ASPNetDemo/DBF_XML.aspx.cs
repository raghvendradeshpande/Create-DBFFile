using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.IO;
using System.Xml;
using System.Data.SqlClient;
using System.Data;

namespace ASPNetDemo
{
    public partial class DBF_XML : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnXMLUpload_Click(object sender, EventArgs e)
        {
             uploadstatus.InnerText = "Starting program execution...";

            string path = @"C:\DBFFiles\";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\DBFFiles\;Extended Properties=dBase IV";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                using (OleDbCommand command = connection.CreateCommand())
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }                   
                        command.CommandText = "CREATE TABLE EmployeeTable (EmployeeID Integer, Name VarChar(50), Age Double)";
                        command.ExecuteNonQuery();                   
                }
            }


            XmlDataDocument xmldoc = new XmlDataDocument();
            XmlNodeList xmlnode; int i = 0;

            string filename = Path.GetFileName(btnFileUpload.FileName);
            btnFileUpload.SaveAs(Server.MapPath("~/XMLFiles/") + filename);

            FileStream fs = new FileStream(Server.MapPath("~/XMLFiles/" + filename), FileMode.Open, FileAccess.Read);
            xmldoc.Load(fs); xmlnode = xmldoc.GetElementsByTagName("Employee");
            for (i = 0; i <= xmlnode.Count - 1; i++)
            {

                using (OleDbConnection connection2 = new OleDbConnection(connectionString))
                using (OleDbCommand command2 = connection2.CreateCommand())
                {
                    connection2.Open();
                    command2.CommandText = @"Insert into EmployeeTable (EmployeeID, Name, Age) VALUES ("
                        + xmlnode[i].ChildNodes.Item(0).InnerText.Trim() + ","
                        + "'" + xmlnode[i].ChildNodes.Item(1).InnerText.Trim() + "'" + "," + xmlnode[i].ChildNodes.Item(2).InnerText.Trim() + ")";
                    command2.ExecuteNonQuery();
                }

            }                        
            uploadstatus.InnerText = "Processed File Successfully";
        }
    }
}