using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KpopZtation.Model;

namespace KpopZtation.Repository
{
    public class DatabaseSingleton
    {
        private static DatabaseEntities2 db = null;

        public static DatabaseEntities2 getInstance()
        {
            if(db == null)
            {
                db = new DatabaseEntities2();
            }
            return db;
        }
    }
}