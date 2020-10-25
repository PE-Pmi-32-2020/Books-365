using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Books365.DAL
{
    class BookDAL
    {
        DataTable dt = new DataTable();
        public DataTable ReadBooks()
        {
            Connection connection = new Connection();

            if (connection.sqlConnection.State==ConnectionState.Closed)
            {
                connection.sqlConnection.Open();
            }
            SqlCommand sqlCommand = new SqlCommand("Select * from Book",connection.sqlConnection);
        
        
        try
        {
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                dt.Load(sqlDataReader);
                return dt;
        }
        catch
        {
                throw new Exception("Error in SQL command Book");
        }
        }
    }
}
