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
    public class FornecedorDB
    {
        //Conexao: 
        private static SQLiteConnection sqliteConnection;

        public FornecedorDB()
        {
            sqliteConnection = ConnectionSQLite.DbConnection();
        }

        public bool Salvar(FornecedorM fornecedor)
        {
            try
            {
                string sql = "INSERT INTO Tb_Fornecedor (nome, telefone, cidade, estado, logradouro, numero, cnpj, email, contaCorrente, agencia, banco) values (@Nome, @Telefone, @Cidade, @Estado, @Logradouro, @Numero, @Cnpj, @Email, @ContaCorrente, @Agencia, @Banco)";

                using (var cmd = sqliteConnection.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@Nome", fornecedor.Nome);
                    cmd.Parameters.AddWithValue("@Telefone", fornecedor.Telefone);
                    cmd.Parameters.AddWithValue("@Cidade", fornecedor.Cidade);
                    cmd.Parameters.AddWithValue("@Estado", fornecedor.Estado);
                    cmd.Parameters.AddWithValue("@Logradouro", fornecedor.Logradouro);
                    cmd.Parameters.AddWithValue("@Numero", fornecedor.Numero);
                    cmd.Parameters.AddWithValue("@Cnpj", fornecedor.Cnpj);
                    cmd.Parameters.AddWithValue("@Email", fornecedor.Email);
                    cmd.Parameters.AddWithValue("@ContaCorrente", fornecedor.ContaCorrente);
                    cmd.Parameters.AddWithValue("@Agencia", fornecedor.Agencia);
                    cmd.Parameters.AddWithValue("@Banco", fornecedor.Banco);
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
            sb.Append("  Nome,");
            sb.Append("  Telefone,");
            sb.Append("  Cidade,");
            sb.Append("  Estado,");
            sb.Append("  Logradouro,");
            sb.Append("  Numero,");
            sb.Append("  Cnpj,");
            sb.Append("  Email,");
            sb.Append("  ContaCorrente,");
            sb.Append("  Agencia,");
            sb.Append("  Banco");
            sb.Append("  FROM Tb_Fornecedor");



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
