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
    public partial class Register : System.Web.UI.Page
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
            string role = ddlRole.SelectedValue;
            errorCode = UserController.UserValidator(fullName, email, password, gender, address);

            if (string.IsNullOrEmpty(errorCode))
            {
                CustomerRepo.addCustomer(fullName, email, password, gender, address, role);
                Response.Redirect("Login.aspx");
            }
            else
            {
                errorLbl.Text = errorCode;
            }
        }
    }
}