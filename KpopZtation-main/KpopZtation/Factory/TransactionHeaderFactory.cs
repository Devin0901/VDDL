using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Factory
{
    public class TransactionHeaderFactory
    {
        public static TransactionHeader createTransactionHeader(string date, int customer_id)
        {
            TransactionHeader header = new TransactionHeader();
            header.TransactionDate = DateTime.Parse(date);
            header.CustomerID = customer_id;
            return header;
        }
    }
}