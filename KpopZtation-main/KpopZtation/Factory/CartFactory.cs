using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Factory
{
    public class CartFactory
    {
        public static Cart createCart(int customer_id, int product_id, int qty)
        {
            Cart cart = new Cart();
            cart.CustomerID = customer_id;
            cart.ProductID = product_id;
            cart.Qty = qty;
            return cart;
        }
    }
}