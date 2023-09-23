using KpopZtation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Handler
{
    public class CartHandler
    {
        public static void verifyItem(int user_id, int album_id, int qty)
        {
            if(CartRepo.FindById(user_id, album_id) == null)
            {
                CartRepo.addItem(user_id, album_id, qty);
            }
            else
            {
                CartRepo.addQty(user_id, album_id, qty);
            }
        }
    }
}