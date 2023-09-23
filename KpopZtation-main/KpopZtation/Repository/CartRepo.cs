using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KpopZtation.Factory;
using KpopZtation.Model;

namespace KpopZtation.Repository
{
    public class CartRepo
    {
        static DatabaseEntities2 db = DatabaseSingleton.getInstance();

        public static void addQty(int user_id, int product_id, int qty)
        {
            Cart cart = FindById(user_id, product_id);
            cart.Qty += qty;
            db.SaveChanges();
        }
        public static void addItem(int user_id, int product_id, int qty)
        {
            Cart cart = CartFactory.createCart(user_id, product_id, qty);
            db.Carts.Add(cart);
            db.SaveChanges();
        }
        public static Cart FindById(int user_id, int product_id)
        {
            return (from c in db.Carts where c.CustomerID == user_id && c.ProductID == product_id select c).FirstOrDefault();
        }
        public static List<Cart> GetItemsById(int id)
        {
            return (from c in db.Carts where c.CustomerID == id select c).ToList();
        }
        public static List<Cart> GetItemsByProductId(int id)
        {
            return (from c in db.Carts where c.ProductID == id select c).ToList();
        }
        public static void removeItem(Cart cart)
        {
            db.Carts.Remove(cart);
            db.SaveChanges();
        }
        public static string GetProductName(int productId)
        {
            var productName = (from p in db.Products where p.ProductID == productId select p.ProductName).FirstOrDefault();

            return productName ?? string.Empty;
        }
    }
}