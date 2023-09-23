using KpopZtation.Model;
using KpopZtation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Handler
{
    public class UserHandler
    {
        public static void deleteUser(int id)
        {
            Customer delete = CustomerRepo.FindById(id);
            if (delete == null)
            {
                return;
            }
            List<TransactionHeader> deleteList = TransactionRepo.GetHeaderByCustomerId(id);

            foreach (var deleted in deleteList)
            {
                TransactionHandler.deleteHeader(deleted.CustomerID);
            }
            CustomerRepo.removeCustomer(delete);
        }
    }
}