using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Factory
{
    public class CustomerFactory
    {
        public static Customer createCustomer(string name, string email, string password, string gender, string address, string role)
        {
            Customer cust = new Customer();
            cust.CustomerName = name;
            cust.CustomerEmail = email;
            cust.CustomerPassword = password;
            cust.CustomerGender = gender;
            cust.CustomerAddress = address;
            cust.CustomerRole = role;
            return cust;
        }
        public static void editProfile(Customer customer, string name, string email, string password, string gender, string address)
        {
            customer.CustomerName = name;
            customer.CustomerEmail = email;
            customer.CustomerPassword = password;
            customer.CustomerGender = gender;
            customer.CustomerAddress = address;
        }
    }
}