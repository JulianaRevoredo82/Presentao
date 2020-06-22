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
    public class PresenteDB
    {
        //Conexao: 
        private static SQLiteConnection sqliteConnection;

        public PresenteDB()
        {
            sqliteConnection = ConnectionSQLite.DbConnection();
        }

        public bool Salvar(PresentesM presente)
        {
            try
            {


                string sql = "INSERT INTO Pres (descricao, tipo, marca, finalidade, cor, tamanho, preco, fornecedor) values (@Descricao, @Tipo, @Marca, @Finalidade, @Cor, @Tamanho, @Preco, @Fornecedor)";

                using (var cmd = sqliteConnection.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@Id", presente.Id);
                    cmd.Parameters.AddWithValue("@Descricao", presente.Descricao);
                    cmd.Parameters.AddWithValue("@Tipo", presente.Tipo.Id);
                    cmd.Parameters.AddWithValue("@Marca", presente.Marca.Id);
                    cmd.Parameters.AddWithValue("@Finalidade", presente.Finalidade.Id);
                    cmd.Parameters.AddWithValue("@Cor", presente.Cor);
                    cmd.Parameters.AddWithValue("@Tamanho", presente.Tamanho);
                    cmd.Parameters.AddWithValue("@Preco", presente.Preco);
                    cmd.Parameters.AddWithValue("@Fornecedor", presente.Fornecedor.Id);
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
            sb.Append(" SELECT p.id Id,");
            sb.Append("   p.descricao Descricao,");
            sb.Append("   t.descricao Tipo,");
            sb.Append("   m.descricao Marca,");
            sb.Append("   f.descricao Finalidade,");
            sb.Append("   p.cor Cor,");
            sb.Append("   p.tamanho Tamanho,");
            sb.Append("   p.preco Preco,");
            sb.Append("   o.nome Fornecedor");
            sb.Append("  FROM Pres p,   ");
            sb.Append("      Tb_Tipo t,");
            sb.Append("      Tb_Marca m,");
            sb.Append("      Tb_Finalidade f,");
            sb.Append("      Tb_Fornecedor o");
            sb.Append("  where p.tipo = t.id");
            sb.Append("    and p.marca = m.Id");
            sb.Append("    and p.finalidade = f.id");
            sb.Append("    and p.fornecedor = o.id");

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
