<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Fornecedor.aspx.cs" Inherits="Presentaoo.Fornecedor" %>

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
            <h2>Fornecedor</h2>
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
        <div class="col-sm-8 ">
            <asp:Label ID="Label1" runat="server" Text="MSG" Font-Negrito="True" ForeColor="Blue"></asp:Label>     
             <div class="row">
       <div class=" form-group col-md-4">
                <label for="IdTxt">Id </label>
                <asp:TextBox ID="IdText" runat="server" CssClass="form-control" Width="291px"></asp:TextBox>
            </div>

            <div class=" form-group col-md-4">
                <label for="NomeFornecedor">Fornecedor </label>
                <asp:TextBox ID="NomeFornecedor" runat="server" CssClass="form-control" Width="289px"></asp:TextBox>
            </div>
           
            <div class=" form-group col-md-4">
                <label for="TelefoneTxt">Telefone </label>
                <asp:TextBox ID="TelefoneTxt" runat="server" CssClass="form-control" Width="287px"></asp:TextBox>
            </div>
    
            <div class=" form-group col-md-4">
                <label for="CidadeTxt">Cidade </label>
                <asp:TextBox ID="CidadeTxt" runat="server" CssClass="form-control" Width="281px"></asp:TextBox>
            </div>
           
            <div class=" form-group col-md-4">
                <label for="EstadoTxt">Estado </label>
                <asp:TextBox ID="EstadoTxt" runat="server" CssClass="form-control" Width="282px"></asp:TextBox>
            </div>
      
            <div class=" form-group col-md-4">
                <label for="LogradouroTxt">Logradouro </label>
                <asp:TextBox ID="LogradouroTxt" runat="server" CssClass="form-control" Width="279px"></asp:TextBox>
            </div>
        
            <div class=" form-group col-md-4">
                <label for="NumeroTxt">Número </label>
                <asp:TextBox ID="NumeroTxt" runat="server" CssClass="form-control" Width="272px"></asp:TextBox>
            </div>
          
            <div class=" form-group col-md-4">
                <label for="CnpjTxt">Cnpj </label>
                <asp:TextBox ID="CnpjTxt" runat="server" CssClass="form-control" Width="274px"></asp:TextBox>
            </div>
          
            <div class=" form-group col-md-4">
                <label for="EmailTxt">Email </label>
                <asp:TextBox ID="EmailTxt" runat="server" CssClass="form-control" Width="272px"></asp:TextBox>
            </div>
            
            <div class=" form-group col-md-4">
                <label for="ContaCorrenteTxt">Conta Corrente </label>
                <asp:TextBox ID="ContaCorrenteTxt" runat="server" CssClass="form-control" Width="266px"></asp:TextBox>
            </div>
            
            <div class=" form-group col-md-4">
                <label for="AgenciaTxt">Agência </label>
                <asp:TextBox ID="AgenciaTxt" runat="server" CssClass="form-control" Width="262px"></asp:TextBox>
            </div>
          
            <div class=" form-group col-md-4">
                <label for="BancoTxt">Banco </label>
                <asp:TextBox ID="BancoTxt" runat="server" CssClass="form-control" Width="265px"></asp:TextBox>
            </div>
                 </div>

            <div class=" form-group ">
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
