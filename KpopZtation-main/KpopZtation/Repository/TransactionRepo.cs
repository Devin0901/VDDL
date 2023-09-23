using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KpopZtation.Factory;
using KpopZtation.Model;

namespace KpopZtation.Repository
{
    public class TransactionRepo
    {
        static DatabaseEntities2 db = DatabaseSingleton.getInstance();
        
        public static void removeHeader(TransactionHeader th)
        {
            db.TransactionHeaders.Remove(th);
            db.SaveChanges();
        }

        public static void removeDetail(TransactionDetail td)
        {
            db.TransactionDetails.Remove(td);
            db.SaveChanges();
        }

        public static List<TransactionHeader> GetHeaderByCustomerId(int id)
        {
            return (from th in db.TransactionHeaders where th.CustomerID == id select th).ToList();
        }
        public static TransactionHeader GetHeaderByDateCustomer(string date, int user_id)
        {
            DateTime datetime = DateTime.Parse(date);
            return (from th in db.TransactionHeaders where th.TransactionDate == datetime && th.CustomerID == user_id select th).FirstOrDefault();
        }

        public static List<TransactionDetail> GetDetailsByHeaderId(int id)
        {
            return (from td in db.TransactionDetails where td.TransactionID == id select td).ToList();
        }
        public static TransactionHeader FindById(int id)
        {
            return (from th in db.TransactionHeaders where th.TransactionID == id select th).FirstOrDefault();
        }
        public static TransactionDetail FindDetailByTransactionProduct(int transaction_id, int product_id)
        {
            return (from td in db.TransactionDetails where td.TransactionID == transaction_id && td.ProductID == product_id select td).FirstOrDefault();
        }
        public static void buyItems(int transaction_id, int product_id, int qty)
        {
            TransactionDetail td = FindDetailByTransactionProduct(transaction_id, product_id);
            if (td == null)
            {
                TransactionDetail detail = TransactionDetailFactory.createTransactionDetail(transaction_id, product_id, qty);
                db.TransactionDetails.Add(detail);
                db.SaveChanges();
            }
            else
            {
                TransactionDetailFactory.updateDetail(td, qty);
            }
        }
        
        public static void addHeader(string date, int id)
        {
            TransactionHeader header = TransactionHeaderFactory.createTransactionHeader(date, id);
            db.TransactionHeaders.Add(header);
            db.SaveChanges();
        }
        public static int GetId(string date, int id)
        {
            DateTime datetime = DateTime.Parse(date);
            return (from th in db.TransactionHeaders where th.CustomerID == id && th.TransactionDate == datetime select th.TransactionID).FirstOrDefault();
        }
        public static void removeItems(TransactionDetail td)
        {
            db.TransactionDetails.Remove(td);
            db.SaveChanges();
        }
        public static List<TransactionHeader> GetHeaders()
        {
            return (from th in db.TransactionHeaders select th).ToList();
        }
        public static List<TransactionDetail> GetDetailsByProductId(int id)
        {
            return (from td in db.TransactionDetails where td.ProductID == id select td).ToList();
        }
        public static List<TransactionHeader> GetHistory(int id)
        {
            return (from th in db.TransactionHeaders where th.CustomerID == id select th).ToList();
        }
    }
}