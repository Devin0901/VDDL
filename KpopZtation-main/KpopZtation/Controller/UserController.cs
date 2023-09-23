using KpopZtation.Model;
using KpopZtation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Controller
{
    public class UserController
    {

        public static string RegisterDetailValidate(string fullName, string email, string phoneNumber, string dateOfBirth, string gender, string password, string confirmPassword)
        {
            string errorCode = "";
            //Name Check
            if (String.IsNullOrEmpty(fullName))
            {
                errorCode += "Name field cannot be left empty <br />";
            }
            else if (fullName.Length > 100)
            {
                errorCode += "Name cannot exceed 100 characters <br />";
            }

            //Email Check
            bool emailIsValid = System.Text.RegularExpressions.Regex.IsMatch(email, @"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Z|a-z]{2,}\b");
            if (String.IsNullOrEmpty(email))
            {
                errorCode += "E-mail field cannot be left empty <br />";
            }
            else if (!emailIsValid)
            {
                errorCode += "E-mail format invalid <br />";
            }

            //Phone number Check
            if (String.IsNullOrEmpty(phoneNumber))
            {
                errorCode += "Phone number field cannot be left empty <br />";
            }
            else if (phoneNumber.Length > 12)
            {
                errorCode += "Phone Number Invalid <br />";
            }

            //DOB Check
            if (String.IsNullOrEmpty(dateOfBirth))
            {
                errorCode += "Date of Birth is not selected <br />";
            }

            //Gender Check
            if (string.IsNullOrEmpty(gender))
            {
                errorCode += "Gender is not selected <br />";
            }

            //Password Check
            if (String.IsNullOrEmpty(password))
            {
                errorCode += "Password field cannot be left empty <br />";
            }
            else if (String.IsNullOrEmpty(confirmPassword))
            {
                errorCode += "Confirm Password <br />";
            }
            else
            {
                if (password != confirmPassword)
                {
                    errorCode += "Password does not match <br />";
                }
                else if (!PasswordStrenthTest(password))
                {
                    errorCode += "Password is too easy <br />";
                }
            }

            return errorCode;
        }

        private static bool PasswordStrenthTest(string password)
        {
            if (password.Length < 8)
            {
                return false;
            }
            else
            {
                bool UpperCase = false;
                bool LowerCase = false;
                bool Digit = false;

                foreach (char c in password)
                {
                    if (char.IsUpper(c))
                    {
                        UpperCase = true;
                    }
                    else if (char.IsLower(c))
                    {
                        LowerCase = true;
                    }
                    else if (char.IsDigit(c))
                    {
                        Digit = true;
                    }
                }

                return UpperCase && LowerCase && Digit;
            }
        }

        public static string UserValidator(string name, string email, string password, string gender, string address)
        {
            if (name.Length >= 5 && name.Length <= 50)
            {
                Customer customer = CustomerRepo.FindByEmail(email);
                if (customer == null)
                {
                    if (gender != null)
                    {
                        if (address.Contains("Street"))
                        {
                            if (checkAlphanumeric(password))
                            {
                                return null;
                            }
                            return "Password must contain numbers and letters<br />";
                        }
                        return "Address must end with 'Street'<br />";
                    }
                    return "Gender must be filled<br />";
                }
                return "Email must be unique<br />";
            }
            return "Name must be between 5 and 50 characters<br />";
        }
        public static string UserUpdateValidator(string name, string email, string password, string gender, string address)
        {
            if (name.Length >= 5 && name.Length <= 50)
            {
                Customer customer = CustomerRepo.FindByEmail(email);
                if (customer != null)
                {
                    if (gender != null)
                    {
                        if (address.Contains("Street"))
                        {
                            if (checkAlphanumeric(password))
                            {
                                return null;
                            }
                            return "Password must contain numbers and letters<br />";
                        }
                        return "Address must end with 'Street'<br />";
                    }
                    return "Gender must be filled<br />";
                }
                return "Email must stayed the same<br />";
            }
            return "Name must be between 5 and 50 characters<br />";
        }
        public static Boolean checkAlphanumeric(string password)
        {
            foreach (char c in password)
            {
                if (Char.IsLetterOrDigit(c))
                {
                    return true;
                }
            }
            return false;
        }
    }
}