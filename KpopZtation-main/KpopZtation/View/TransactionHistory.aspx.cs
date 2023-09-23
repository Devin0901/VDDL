using KpopZtation.Model;
using KpopZtation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View
{
    public partial class TransactionHistory : System.Web.UI.Page
    {
        List<TransactionHeader> transactions = new List<TransactionHeader>();
        protected void Page_Load(object sender, EventArgs e)
        {
            Customer customer = Session["user"] != null ? Session["user"] as Customer : null;
            int id = customer.CustomerID;
            transactions = TransactionRepo.GetHistory(id);
            gvTransactions.DataSource = transactions;
            gvTransactions.DataBind();
        }
    }
}