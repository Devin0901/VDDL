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
    public partial class ViewCart : System.Web.UI.Page
    {
        List<Cart> items = new List<Cart>();
        public class CartItem
        {
            public int CustomerID { get; set; }
            public int ProductID { get; set; }
            public string ProductName { get; set; }
            public int Qty { get; set; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Customer customer = Session["user"] as Customer;
            int id = Convert.ToInt32(customer.CustomerID);
            items = CartRepo.GetItemsById(id);

            List<CartItem> itemsWithProductNames = new List<CartItem>();

            foreach (Cart item in items)
            {
                int productId = item.ProductID;
                string productName = CartRepo.GetProductName(productId); // Replace with your logic to retrieve the product name from the Product table

                CartItem cartItemWithProductName = new CartItem
                {
                    CustomerID = item.CustomerID,
                    ProductID = item.ProductID,
                    ProductName = productName,
                    Qty = item.Qty
                };

                itemsWithProductNames.Add(cartItemWithProductName);
            }

            gvItems.DataSource = itemsWithProductNames;
            gvItems.DataBind();
        }



        protected void gvItems_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int user_id = Convert.ToInt32(gvItems.Rows[e.RowIndex].Cells[1].Text);
            int album_id = Convert.ToInt32(gvItems.Rows[e.RowIndex].Cells[2].Text);
            CartRepo.removeItem(CartRepo.FindById(user_id, album_id));
            gvItems.DataBind();
            Response.Redirect("ViewCart.aspx");
        }

        protected void btnCheckout_Click(object sender, EventArgs e)
        {
            if (items != null && string.IsNullOrEmpty(lbError.Text))
            {
                Customer customer = Session["user"] != null ? Session["user"] as Customer : null;
                int user_id = Convert.ToInt32(customer.CustomerID);
                string date = DateTime.Today.ToString();
                int transaction_id = TransactionHandler.createTransaction(date, user_id);
                foreach (Cart cart in items)
                {
                    TransactionRepo.buyItems(transaction_id, cart.ProductID, cart.Qty);
                    CartRepo.removeItem(cart);
                }
                gvItems.DataBind();
                Response.Redirect("Home.aspx");
            }
        }
    }
}