using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Books365.DAL;

namespace Books365.BLL
{
    class UserBLL
    {
        public DataTable GetUsers()
        {

            try
            {
               UserDAL udal = new UserDAL();
                return udal.ReadUsers();
            }
            catch
            {
                throw new Exception("Unable to get DataTable User");
            }
        }
    }
}
