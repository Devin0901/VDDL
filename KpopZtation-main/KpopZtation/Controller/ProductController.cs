using KpopZtation.Model;
using KpopZtation.Repository;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Controller
{
    public class ProductController
    {
        public static string ProductValidator(string name, string description, int price, int stock, string image, int size)
        {
            if(name.Length < 50)
            {
                if(description.Length < 255)
                {
                    //if(price >= 100000 && price <= 1000000)
                    //{
                        if(stock > 0)
                        {
                            int mbsize = (size / (1024 * 1024));
                            if (mbsize < 2)
                            {
                                if (checkExtension(image))
                                {
                                    return null;
                                }
                                return "File extension must be .png, .jpg, .jpeg, or .jfif<br />";
                            }
                            return "File size must be lower than 2MB<br />";
                        }
                        return "Stock must be more than 0<br />";
                    //}
                    //return "Price must be between 100000 and 1000000<br />";
                }
                return "Description must be smaller than 255 characters<br />";
            }
            return "Album name must be smaller than 50 characters<br />";
        }

        public static Boolean checkExtension(string image)
        {
            string extension = Path.GetExtension(image);
            if (extension == ".png" || extension == ".jpg" || extension == ".jpeg" || extension == ".jfif")
            {
                return true;
            }
            return false;
        }
    }
}