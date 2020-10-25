using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Books365.DAL
{
    class ReadingStatusesDAL
    {
        DataTable dt = new DataTable();
        public DataTable ReadReadingStatuses()
        {
            Connection connection = new Connection();

            if (connection.sqlConnection.State == ConnectionState.Closed)
            {
                connection.sqlConnection.Open();
            }
            SqlCommand sqlCommand = new SqlCommand("Select * from ReadingStatuses", connection.sqlConnection);


            try
            {
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                dt.Load(sqlDataReader);
                return dt;
            }
            catch
            {
                throw new Exception("Error in SQL command Notification");
            }
        }
    }
}
