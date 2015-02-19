using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace ASPNetDemo
{
    public partial class About : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Read XML into the DataSet
            System.Data.DataSet ds = new System.Data.DataSet();
            ds.ReadXml(Server.MapPath("XMLFiles/XMLFile.xml"));

            // Execute LINQ
            var query = from a in ds.Tables[0].AsEnumerable()
                        where a.Field<string>("Name") == "Miller"
                        select a;

            // Display records from the query
            foreach (var EmpID in query)
            {
                Response.Write(EmpID["Name"] + "'s Employee ID - " + EmpID["EmployeeID"].ToString());
            }
        }
    }
}
