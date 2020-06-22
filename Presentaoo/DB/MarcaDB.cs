using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
  public  class MarcaDB
    {

        //Conexao: 
        private static SQLiteConnection sqliteConnection;

        public MarcaDB()
        {
            sqliteConnection = ConnectionSQLite.DbConnection();
        }

        public bool Salvar(MarcaM marca)
        {
            try
            {
                string sql = "INSERT INTO Tb_Marca (Descricao) values (@Descricao)";

                using (var cmd = sqliteConnection.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@Descricao", marca.Descricao);
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public DataTable ConsultarTudo()
        {
            DataTable dt = new DataTable();
            SQLiteDataAdapter da = null;

            StringBuilder sb = new StringBuilder();

            sb.Append(" SELECT  Id,");
            sb.Append("  Descricao");

            sb.Append("  FROM Tb_Marca   ");



            using (var cmd = sqliteConnection.CreateCommand())
            {
                cmd.CommandText = sb.ToString();
                da = new SQLiteDataAdapter(cmd.CommandText, sqliteConnection);
                da.Fill(dt);
            }
            return dt;
        }

    }
}
