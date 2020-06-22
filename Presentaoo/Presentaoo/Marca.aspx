<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Marca.aspx.cs" Inherits="Presentaoo.Marca" %>

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
            <h2>Marca</h2>
            </></a>
        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Alterna navegação">
            <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse" id="navbarNav">
            <ul class="navbar-nav">
                <li class="nav-item ">
                    <a class="nav-link" href="Default.aspx"><h2>Início</h2> </a>
                </li>
                </ul>
            </div>
        </nav>
    <form id="form1" runat="server">
        <div style="padding-top: 2%"></div>
        <div class="col-sm-2">
            <asp:Label ID="Label1" runat="server" Text="MSG" Font-Negrito="True" ForeColor="Blue"></asp:Label>

            <div class=" form-group ">
                <label for="IdMarcaTxt">Id </label>
                <asp:TextBox ID="IdMarcaTxt" runat="server" CssClass="form-control" Width="178px"></asp:TextBox>
            </div>
            <div class=" form-group ">
                <label for="DescricaoTxt">Marca </label>
                <asp:TextBox ID="DescricaoTxt" runat="server" CssClass="form-control" Width="178px"></asp:TextBox>
            </div>
        </div>
        <div class="col-sm-2">
            <div class="form-group">
                <asp:Button ID="SalvarBt" runat="server" CssClass="btn btn-primary" Text="Salvar" OnClick="SalvarBt_Click" />
               <a href="Default.aspx"> Voltar</a>
               </div>
        </div>

        <div class=" col-sm-8 ">
            <div class="container">
                <asp:GridView ID="GridView1" runat="server" CssClass="table table-hover" bgcolor="#dddddd" ForeColor="Blue">
                </asp:GridView>
            </div>
        </div>
    </form>
</body>
</html>
