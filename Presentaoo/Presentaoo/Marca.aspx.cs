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
    public partial class Marca : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CarregarTabela();
        }

        protected void SalvarBt_Click(object sender, EventArgs e)
        {
            MarcaM marca = new MarcaM()
            {
                Descricao = DescricaoTxt.Text,
            };

            MarcaDB marcaDB = new MarcaDB();
            bool status = marcaDB.Salvar(marca);

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
            IdMarcaTxt.Text = String.Empty;
            DescricaoTxt.Text = String.Empty;
        }

        private void CarregarTabela()
        {
            MarcaDB marcaDB = new MarcaDB();
            GridView1.DataSource = marcaDB.ConsultarTudo();
            GridView1.DataBind();
        }

    }
    
}