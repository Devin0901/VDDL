using KpopZtation.Handler;
using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View
{
    public partial class Site : System.Web.UI.MasterPage
    {
        public Customer customer = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            Customer customer = Session["user"] as Customer;
            if (Session["user"] == null)
            {
                btnCart.Visible = false;
                btnTransaction.Visible = false;
                btnUpdate.Visible = false;
                btnLogout.Visible = false;
                btnReport.Visible = false;
                btnDelete.Visible = false;
                btnTransaction.Visible = false;
            }
            else if (customer.CustomerRole == "cstmr")
            {
                btnReport.Visible = false;
                btnLogin.Visible = false;
                btnReport.Visible = false;
                btnRegister.Visible = false;
            }
            else if(customer.CustomerRole == "admin")
            {
                btnCart.Visible = false;
                btnLogin.Visible = false;
                btnRegister.Visible = false;
                btnTransaction.Visible = false;
            }
            
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void btnCart_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewCart.aspx");
        }

        protected void btnTransaction_Click(object sender, EventArgs e)
        {
            Response.Redirect("TransactionHistory.aspx");
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateProfile.aspx");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Response.Cookies["user_cookie"].Expires = DateTime.Now.AddDays(-1);
            Session.Remove("user");
            Response.Redirect("Login.aspx");
        }

        protected void btnReport_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewReports.aspx");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            if(Session["user"] != null)
            {
                Customer c = Session["user"] as Customer;
                UserHandler.deleteUser(c.CustomerID);
            }
        }
    }
}