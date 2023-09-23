using KpopZtation.Model;
using KpopZtation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Handler
{
    public class TransactionHandler
    {
        public static void deleteHeader(int id)
        {
            TransactionHeader delete = TransactionRepo.FindById(id);
            if (delete == null)
            {
                return;
            }

            List<TransactionDetail> deleteList = TransactionRepo.GetDetailsByHeaderId(delete.TransactionID);

            foreach (var deleted in deleteList)
            {
                TransactionRepo.removeDetail(deleted);
            }
            TransactionRepo.removeHeader(delete);
        }
        public static int createTransaction(string date, int user_id)
        {
            TransactionHeader th = TransactionRepo.GetHeaderByDateCustomer(date, user_id);
            if (th == null) TransactionRepo.addHeader(date, user_id);
            return TransactionRepo.GetId(date, user_id);
        }
    }
}