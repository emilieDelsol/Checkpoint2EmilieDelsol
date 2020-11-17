using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace DALCheckPoint2EmilieD
{
    internal class DataAbstractionLayer
    {
        private static SqlConnection _connection = new SqlConnection();
        internal static void Connect(SqlConnectionStringBuilder stringBuilder)
        {
            _connection.ConnectionString = stringBuilder.ConnectionString;
            _connection.Open();
        }

        internal static void Disconnect()
        {
            _connection.Close();
        }

    }
}
