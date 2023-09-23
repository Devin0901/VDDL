using KpopZtation.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KpopZtation.Dataset;
using KpopZtation.Model;
using KpopZtation.Repository;

namespace KpopZtation.View
{
    public partial class ViewReports : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CrystalReport report = new CrystalReport();
            CrystalReportViewer1.ReportSource = report;

            report.SetDataSource(GetData(TransactionRepo.GetHeaders()));
        }
        private static DataSet GetData(List<TransactionHeader> transactions)
        {
            DataSet data = new DataSet();

            var headertable = data.Transaction;
            var detailtable = data.Transaction_Detail;

            foreach(TransactionHeader th in transactions)
            {
                var hrow = headertable.NewRow();
                hrow["transaction_id"] = th.TransactionID;
                hrow["customer_id"] = th.CustomerID;
                hrow["transaction_date"] = th.TransactionDate;

                headertable.Rows.Add(hrow);

                foreach(TransactionDetail td in th.TransactionDetails)
                {
                    var drow = detailtable.NewRow();
                    drow["transaction_id"] = td.TransactionID;
                    drow["product_id"] = td.ProductID;
                    drow["qty"] = td.Qty;

                    detailtable.Rows.Add(drow);
                }
            }
            return data;
        }
    }
}