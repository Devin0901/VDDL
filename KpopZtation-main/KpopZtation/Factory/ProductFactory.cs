using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Factory
{
    public class ProductFactory
    {
        public static Product createProduct(int product_id, string name, string image, int price, int stock, string description)
        {
            Product product= new Product();
            product.ProductID = product_id;
            product.ProductName = name;
            product.ProductImage = image;
            product.ProductPrice = price;
            product.ProductStock = stock;
            product.ProductDescription = description;
            return product;
        }
        public static void editProduct(Product product, string name, string description, int price, int stock, string image)
        {
            product.ProductName = name;
            product.ProductDescription = description;
            product.ProductPrice = price;
            product.ProductStock = stock;
            product.ProductImage = image;
        }
    }
}