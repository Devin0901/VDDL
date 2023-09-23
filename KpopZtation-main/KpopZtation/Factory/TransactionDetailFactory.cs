using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Factory
{
    public class TransactionDetailFactory
    {
        public static TransactionDetail createTransactionDetail(int transaction_id, int product_id, int qty)
        {
            TransactionDetail detail = new TransactionDetail();
            detail.TransactionID = transaction_id;
            detail.ProductID = product_id;
            detail.Qty = qty;
            return detail;
        }
        public static void updateDetail(TransactionDetail td, int qty)
        {
            td.Qty += qty;
        }
    }
}