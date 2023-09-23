using KpopZtation.Handler;
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
    public partial class Home : System.Web.UI.Page
    {
        public List<Product> products = new List<Product>();
       
        protected void Page_Load(object sender, EventArgs e)
        {
            var user = Session["user"] as Customer;
            if (user != null)
            {
                if (user.CustomerRole == "admin")
                {
                    btnInsert.Visible = true;
                }
                else
                {
                    btnInsert.Visible = false;
                }
                ProductRepo repo = new ProductRepo();
                string id = Request.QueryString["id"];
                products = repo.GetProduct();
            }
            else
            {
                btnInsert.Visible = false;
            }
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertProduct.aspx");
        }

        protected void btnProductDetail_Click(object sender, EventArgs e)
        {
            Button btnProductDetail = (Button)sender;
            string id = btnProductDetail.CommandArgument;
            Response.Redirect("ProductDetails.aspx?id=" + id);
        }

        protected Boolean UserIsAdmin()
        {
            if (Session["user"] != null)
            {
                Customer customer = Session["user"] as Customer;
                if (customer.CustomerRole == "admin")
                {
                    return true;
                }
                else if (customer.CustomerRole == "cstmr")
                {
                    return false;
                }
            }
            return false;
        }
    }
}