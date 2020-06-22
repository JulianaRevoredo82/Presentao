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
    public partial class Presentes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CarregarTipo();
                CarregarMarca();
                CarregarFinalidade();
                CarregarFornecedor();
            }
            CarregarTabela();
        }

        protected void SalvarBt_Click(object sender, EventArgs e)
        {
            PresentesM presente = new PresentesM()
            {
               
                Descricao = DescricaoTxt.Text,
                Tipo = new TipoM() { Id = int.Parse(TipoDropDownList1.SelectedItem.Value.ToString()) },
                Marca = new MarcaM() { Id = int.Parse(MarcaDropDownList2.SelectedItem.Value.ToString()) },
                Finalidade = new FinalidadeM() { Id = int.Parse(FinalidadeDropDownList3.SelectedItem.Value.ToString()) },
                Cor = CorTxt.Text,
                Tamanho = double.Parse(TamanhoTxt.Text),
                Preco = decimal.Parse(PrecoTxt.Text),
                Fornecedor = new FornecedorM() { Id = int.Parse(FornecedorDropDownList4.SelectedItem.Value.ToString()) }
            };

            PresenteDB presenteDB = new PresenteDB();
            bool status = presenteDB.Salvar(presente);

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
            IdTxt.Text = String.Empty;
            DescricaoTxt.Text = String.Empty;
            CorTxt.Text = String.Empty;
            TamanhoTxt.Text = String.Empty;
            PrecoTxt.Focus();
        }

        private void CarregarTabela()
        {
            PresenteDB presenteDB = new PresenteDB();
            GridView1.DataSource = presenteDB.ConsultarTudo();
            GridView1.DataBind();
        }

        private void CarregarTipo()
        {
            TipoDB tipoDB = new TipoDB();
            TipoDropDownList1.DataSource = tipoDB.ConsultarTudo();
            TipoDropDownList1.DataValueField = "Id";
            TipoDropDownList1.DataTextField = "Descricao";
            TipoDropDownList1.DataBind();
        }

        private void CarregarMarca()
        {
            MarcaDB marcaDB = new MarcaDB();
            MarcaDropDownList2.DataSource = marcaDB.ConsultarTudo();
            MarcaDropDownList2.DataValueField = "Id";
            MarcaDropDownList2.DataTextField = "Descricao";
            MarcaDropDownList2.DataBind();
        }

        private void CarregarFinalidade()
        {
            FinalidadeDB finalidadeDB = new FinalidadeDB();
            FinalidadeDropDownList3.DataSource = finalidadeDB.ConsultarTudo();
            FinalidadeDropDownList3.DataValueField = "Id";
            FinalidadeDropDownList3.DataTextField = "Descricao";
            FinalidadeDropDownList3.DataBind();
        }

        private void CarregarFornecedor()
        {
            FornecedorDB fornecedorDB = new FornecedorDB();
            FornecedorDropDownList4.DataSource = fornecedorDB.ConsultarTudo();
            FornecedorDropDownList4.DataValueField = "Id";
            FornecedorDropDownList4.DataTextField = "Nome";
            FornecedorDropDownList4.DataBind();
        }


    }

}