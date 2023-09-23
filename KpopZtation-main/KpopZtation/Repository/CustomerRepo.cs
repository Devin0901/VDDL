using KpopZtation.Factory;
using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Repository
{
    public class CustomerRepo
    {
        static DatabaseEntities2 db = DatabaseSingleton.getInstance();

        public static void removeCustomer(Customer customer)
        {
            db.Customers.Remove(customer);
            db.SaveChanges();
        }
        public static void addCustomer(string name, string email, string password, string gender, string address, string role)
        {
            Customer customer = CustomerFactory.createCustomer(name, email, password, gender, address, role);
            db.Customers.Add(customer);
            db.SaveChanges();
        }
        public static Customer FindById(int id)
        {
            return (from c in db.Customers where c.CustomerID == id select c).FirstOrDefault();
        }
        public static Customer FindByEmail(string email)
        {
            return (from c in db.Customers where c.CustomerEmail == email select c).FirstOrDefault();
        }
        public static void updateProfile(int id, string name, string email, string gender, string address, string password)
        {
            Customer customer = CustomerRepo.FindById(id);
            if(customer != null)
            {
                CustomerFactory.editProfile(customer, name, email, password, gender, address);
                db.SaveChanges();
            }
        }
    }
}