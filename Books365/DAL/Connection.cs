using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Books365.DAL
{
    class Connection
    {
        public SqlConnection sqlConnection = new SqlConnection("Data Source=.;Initial Catalog=Books365;Integrated Security=True");
    }
}
