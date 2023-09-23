using KpopZtation.Controller;
using KpopZtation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View
{
    public partial class InsertAlbum : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string description = tbDescription.Text;
            int price = Convert.ToInt32(tbPrice.Text);
            int stock = Convert.ToInt32(tbStock.Text);
            string image = fuImage.FileName;
            int size = fuImage.PostedFile.ContentLength;
            int id = Convert.ToInt32(Request.QueryString["id"]);
            string errorCode = ProductController.ProductValidator(name, description, price, stock, image, size);
            if (string.IsNullOrEmpty(errorCode))
            {
                ProductRepo.addProduct(id, name, image, price, stock, description);
                Response.Redirect("Home.aspx");
            }
            else
            {
                lbError.Text = errorCode;
            }
        }
    }
}