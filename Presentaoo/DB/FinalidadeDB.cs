using Dados;
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
  public class FinalidadeDB
    {
        //Conexao: 
        private static SQLiteConnection sqliteConnection;

        public FinalidadeDB()
        {
            sqliteConnection = ConnectionSQLite.DbConnection();
        }

        public bool Salvar( FinalidadeM finalidade)
        {
            try
            {
                string sql = "INSERT INTO Tb_Finalidade (Descricao, Origem) values (@Descricao, @Origem)";

                using (var cmd = sqliteConnection.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@Descricao", finalidade.Descricao);
                    cmd.Parameters.AddWithValue("@Origem", finalidade.Origem);
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
            sb.Append("  Descricao,");
            sb.Append("  Origem");
            sb.Append("  FROM Tb_Finalidade");



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
