using KpopZtation.Model;
using KpopZtation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["user_cookie"];
            string email = cookie != null ? cookie.Value : null;
            if(email != null)
            {
                tbEmail.Text = email;
            }
        }

        protected void tbEmail_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            DatabaseEntities2 db = DatabaseSingleton.getInstance();
            Customer customer = (from c in db.Customers where c.CustomerEmail == tbEmail.Text && c.CustomerPassword == tbPassword.Text select c).FirstOrDefault();

            if (customer != null)
            {
                Session["user"] = customer;
                if (cbRemember.Checked)
                {
                    HttpCookie cookie = new HttpCookie("user_cookie");
                    cookie.Value = tbEmail.Text;
                    cookie.Expires = DateTime.Now.AddHours(2);
                    Response.Cookies.Add(cookie);
                }
                Response.Redirect("Home.aspx");
            }
            else
            {
                lbError.Text = "Incorrect combination of email and password";
            }
        }
    }
}