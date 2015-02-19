using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ServiceModel;

namespace ASPNetDemo
{
    public partial class FaultEXP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();

            //int num1 = 6;
            //int num2 = 2;
            //int num = 2;
            //try
            //{
            //    int resultMulitply = client.Multiply(num1, num2);
            //    int resultDivide = client.Divide(num1, num);
            //}
            //catch (FaultException<ServiceReference1.MyExceptionContainer> ex)
            //{
            //    Label1.Text = ex.Detail.Messsage + "\n" + ex.Detail.Description;                
            //}
            //catch (FaultException ex)
            //{
            //    Label1.Text = Convert.ToString(ex.Message);
            //}


           

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client obj = new ServiceReference1.Service1Client();
            Label1.Text = obj.Increment().ToString();
            Label1.Text = obj.Increment().ToString();
        }
    }
}