using KpopZtation.Controller;
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
    public partial class AlbumDetails : System.Web.UI.Page
    {
        public Product product;
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];
            product = ProductRepo.FindById(Convert.ToInt32(id));
            Customer customer = Session["user"] != null ? Session["user"] as Customer : null;
            if(customer != null)
            {
                if (customer.CustomerRole == "admin")
                {
                    lbQty.Visible = false;
                    tbQty.Visible = false;
                    btnCart.Visible = false;
                }
            }
            else
            {
                lbQty.Visible = false;
                tbQty.Visible = false;
                btnCart.Visible = false;
            }
        }

        protected void btnCart_Click(object sender, EventArgs e)
        {
            int qty = Convert.ToInt32(tbQty.Text);
            int stock = product.ProductStock;
            Customer customer = Session["user"] != null ? Session["user"] as Customer : null;
            int user_id = customer.CustomerID;
            int album_id = Convert.ToInt32(Request.QueryString["id"]);
            string errorCode = CartController.ItemValidator(qty, stock);
            if(string.IsNullOrEmpty(errorCode))
            {
                CartHandler.verifyItem(user_id, album_id, qty);
                Response.Redirect("ViewCart.aspx");
            }
            else
            {
                lbError.Text = errorCode;
            }
        }
    }
}