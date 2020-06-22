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
    public partial class Tipo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CarregarTabela();
        }

        protected void SalvarBt_Click(object sender, EventArgs e)
        {
            TipoM tipo = new TipoM()
            {
               Descricao = DescricaoTxt.Text,
            };

            TipoDB tipoDB = new TipoDB();
            bool status = tipoDB.Salvar(tipo);

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
            IdTipoTxt.Text = String.Empty;
            DescricaoTxt.Text = String.Empty;
        }

        private void CarregarTabela()
        {
            TipoDB tipoDB = new TipoDB();
            GridView1.DataSource = tipoDB.ConsultarTudo();
            GridView1.DataBind();
        }

      
    }
}