<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tipo.aspx.cs" Inherits="Presentaoo.Tipo" %>


<!DOCTYPE html>
<html lang="pt-br">

<head>
    <link rel="stylesheet" type="text/css" href=" Content/bootstrap.min.css">
    <link rel="stylesheet" type="text/css" href=" css/css" />
    <meta charset="utf-8" />
    <title>Presentão</title>

</head>

<body>
    <nav class="navbar navbar-expand-lg  alert alert-primary">
        <a class="navbar-brand" href="">
            <h2>Tipo</h2>
            </></a>
        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Alterna navegação">
            <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse" id="navbarNav">
            <ul class="navbar-nav">
                <li class="nav-item ">
                    <a class="nav-link" href="Default.aspx">
                        <h2>Início</h2>
                    </a>
                </li>
            </ul>
        </div>
    </nav>
    <div style="padding-top: 2%"></div>
    <form id="form1" runat="server">
        &nbsp;&nbsp;


        <asp:Label ID="Label1" runat="server" Text="MSG" Font-Negrito="True" ForeColor="Blue"></asp:Label>


        <div class="col-sm-2 ">
            <div class=" form-group ">
                <label for="IdTipoTxt">Id </label>
                <asp:TextBox ID="IdTipoTxt" runat="server" CssClass="form-control" Width="165px"></asp:TextBox>
            </div>

            <div class=" form-group ">
                <label for="DescricaoTxt">Descrição </label>
                <asp:TextBox ID="DescricaoTxt" runat="server" CssClass="form-control" Width="165px"></asp:TextBox>
            </div>
        </div>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
      <div class="col-sm-2">
          <div class="form-group">
              <asp:Button ID="Button1" runat="server" CssClass="btn btn-primary" OnClick="SalvarBt_Click" Text="Salvar" />
                   <a href="Default.aspx"> Voltar</a>
          </div>
      </div>
 
        <div class=" col-sm-8 ">
            <div class="container">
                <asp:GridView ID="GridView1" CssClass="table table-hover" runat="server" bgcolor="#58FAAC" ForeColor="Blue">
                </asp:GridView>
            </div>
        </div>
    </form>

</body>
</html>
