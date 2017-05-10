using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EmployeeDAL;

namespace KUDWebAPI
{
    public class EmployeeSecurity
    {
        public static bool Login(string username, string password)
        {
            using (EmployeeDBEntities entities = new EmployeeDBEntities())
            {
                return entities.AngUsers.Any(user => user.Username.Equals(username, 
                    StringComparison.OrdinalIgnoreCase) && user.Password == password);
            }
        }
    }
}