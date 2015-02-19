using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EnitityFramework
{
    public partial class About : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Employee eo = new Employee();
            eo.EmployeeName = TextBox1.Text;
            eo.City = TextBox2.Text;
            eo.Bonus =Convert.ToInt32(TextBox3.Text);
            eo.Salary = Convert.ToInt32(TextBox4.Text);

            UserManagementEntities ume = new UserManagementEntities();
            ume.Employees.AddObject(eo);
            ume.SaveChanges();

        }
    }
}
