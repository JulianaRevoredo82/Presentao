using Dados;

using Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentaoo
{
    public partial class Fornecedor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CarregarTabela();
        }

        protected void SalvarBt_Click(object sender, EventArgs e)
        {
            FornecedorM fornecedor = new FornecedorM()
            {
                Nome = NomeFornecedor.Text,
                Telefone = TelefoneTxt.Text,
                Cidade = CidadeTxt.Text,
                Estado = EstadoTxt.Text,
                Logradouro = LogradouroTxt.Text,
                Numero = NumeroTxt.Text,
                Cnpj = CnpjTxt.Text,
                Email = EmailTxt.Text,
                ContaCorrente = ContaCorrenteTxt.Text,
                Agencia = AgenciaTxt.Text,
                Banco = BancoTxt.Text,
            };

            FornecedorDB fornecedorDB = new FornecedorDB();
            bool status = fornecedorDB.Salvar(fornecedor);

            if (status)
            {
                Label1.Text = "Registro Inserido!";
                LimparComponentes();
                CarregarTabela();
            }
            else
            {
                Label1.Text = "Erro ao inserir registro";
                Label1.ForeColor = Color.Red;
            }

        }
        private void LimparComponentes()
        {
            IdText.Text = String.Empty;
            NomeFornecedor.Text = String.Empty;
            TelefoneTxt.Text = String.Empty;
            CidadeTxt.Text = String.Empty;
            EstadoTxt.Text = String.Empty;
            LogradouroTxt.Text = String.Empty;
            NumeroTxt.Text = String.Empty;
            CnpjTxt.Text = String.Empty;
            EmailTxt.Text = String.Empty;
            ContaCorrenteTxt.Text = String.Empty;
            AgenciaTxt.Text = String.Empty;
            BancoTxt.Text = String.Empty;
        }

        private void CarregarTabela()
        {
            FornecedorDB fornecedorDB = new FornecedorDB();
            GridView1.DataSource = fornecedorDB.ConsultarTudo();
            GridView1.DataBind();
        }
    }
    
}