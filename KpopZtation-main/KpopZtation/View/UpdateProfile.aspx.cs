using KpopZtation.Controller;
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
    public partial class UpdateProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void registerBtn_Click(object sender, EventArgs e)
        {
            string errorCode = "error";
            string fullName = tbName.Text;
            string email = tbEmail.Text;
            string gender = genderRbl.SelectedValue;
            string address = tbAddress.Text;
            string password = tbPassword.Text;
            errorCode = UserController.UserUpdateValidator(fullName, email, password, gender, address);
            Customer customer = CustomerRepo.FindByEmail(email);

            if (string.IsNullOrEmpty(errorCode))
            {
                CustomerRepo.updateProfile(customer.CustomerID, fullName, email, gender, address, password);
                Response.Redirect("Home.aspx");
            }
            else
            {
                errorLbl.Text = errorCode;
            }
        }
    }
}