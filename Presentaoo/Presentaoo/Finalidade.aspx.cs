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
    public partial class Finalidade : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CarregarTabela();
        }

        protected void SalvarBt_Click(object sender, EventArgs e)
        {
            FinalidadeM finalidade = new FinalidadeM()
            {
                Descricao = DescricaoTxt.Text,
                Origem = OrigemTxt.Text,
            };

            FinalidadeDB finalidadeDB = new FinalidadeDB();
            bool status = finalidadeDB.Salvar(finalidade);

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
            IdFinalidadeTxt.Text = String.Empty;
            DescricaoTxt.Text = String.Empty;
            OrigemTxt.Text = String.Empty;
        }

        private void CarregarTabela()
        {
            FinalidadeDB finalidadeDB = new FinalidadeDB();
            GridView1.DataSource = finalidadeDB.ConsultarTudo();
            GridView1.DataBind();
        }
    }
    
}