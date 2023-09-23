using KpopZtation.Model;
using KpopZtation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Handler
{
    public class ProductHandler
    {
        public static void deleteProduct(int id)
        {
            Product delete = ProductRepo.FindById(id);
            if (delete == null)
            {
                return;
            }
            List<Cart> deleteList = CartRepo.GetItemsByProductId(id);
            List<TransactionDetail> deleteList2 = TransactionRepo.GetDetailsByProductId(id);

            foreach (Cart deleted in deleteList)
            {
                CartRepo.removeItem(deleted);
            }
            foreach (var deleted in deleteList2)
            {
                TransactionRepo.removeItems(deleted);
            }
            ProductRepo.removeProduct(delete);
        }
    }
}