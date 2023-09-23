using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KpopZtation.Factory;
using KpopZtation.Model;

namespace KpopZtation.Repository
{
    public class ProductRepo
    {
        static DatabaseEntities2 db = DatabaseSingleton.getInstance();

        public static void addProduct(int artist_id, string name, string image, int price, int stock, string description)
        {
            Product product = ProductFactory.createProduct(artist_id, name, image, price, stock, description);
            db.Products.Add(product);
            db.SaveChanges();
        }
        public static void updateProduct(int id, string name, string description, int price, int stock, string image)
        {
            Product product = FindById(id);
            if(product != null)
            {
                ProductFactory.editProduct(product, name, description, price, stock, image);
                db.SaveChanges();
            }
        }
        public List<Product> GetProduct()
        {
            return (from al in db.Products select al).ToList();
        }
        public static Product FindById(int id)
        {
            return (from al in db.Products where al.ProductID == id select al).FirstOrDefault();
        }
        public static void removeProduct(Product product)
        {
            db.Products.Remove(product);
            db.SaveChanges();
        }
    }
}