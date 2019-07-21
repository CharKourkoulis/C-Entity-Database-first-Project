using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PrivateSchoolPartB
{
    public sealed class SqlServerConnection : ISqlConnection
    {
        public string ConnectionString { get; }
        public SqlConnection Connection { get; }


        private static SqlServerConnection sql = null;

        private SqlServerConnection()
        {
            ConnectionString = @"Data Source = DESKTOP-KSJ94E1\SQLEXPRESS;Initial Catalog=privateschool;Integrated Security=True;";
            Connection = new SqlConnection(ConnectionString);

        }

        public static SqlServerConnection ConnectionEstablisher
        {
            get
            {
                if (sql == null)
                {
                    sql = new SqlServerConnection();
                }
                return sql;
            }
        }
    }
}
