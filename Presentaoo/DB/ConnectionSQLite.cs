using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class ConnectionSQLite
    {
        private static SQLiteConnection sqliteConnection;
        public static SQLiteConnection DbConnection()
        {
            sqliteConnection = new SQLiteConnection(@"Data Source = D:\SQL\Presentee.db");
            sqliteConnection.Open();
            return sqliteConnection;
        }
    }
}
