using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Books365.DAL;
namespace Books365.BLL
{
    class BookBLL
    {
        public DataTable GetBooks()
        {
            
            try
            {
                BookDAL bdal = new BookDAL();
                return bdal.ReadBooks();
            }
            catch
            {
               throw; 
            }
        }
    }
}
