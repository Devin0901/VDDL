using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Controller
{
    public class CartController
    {
        public static string ItemValidator(int qty, int stock)
        {
            if(qty <= stock)
            {
                return null;
            }
            return "Quantity cannot be more than stock<br />";
        }
    }
}