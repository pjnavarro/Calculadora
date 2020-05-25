<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="calculadora.login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="justify-content-center input-group-text">
        <div class="card border-danger">
            <img src="css/login.jpg" class="card-img" alt="...">
            <div class="card-body">
                <asp:TextBox class="justify-content-center  text-center" placeholder="Escriba el usuario" aria-label="Escriba el usuario"
                    aria-describedby="basic-addon1" ID="txtUser" runat="server" Width="220px" MaxLength="7" Height="21px"></asp:TextBox>
                <br />
                <br />
                <asp:TextBox class="justify-content-center  text-center" placeholder="Escriba la clave" aria-label="Escriba la clave"
                    aria-describedby="basic-addon1" ID="txtPass" runat="server" Width="220px" MaxLength="7" Height="21px" TextMode="Password"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="lbl1" runat="server" Text=""></asp:Label>
                <br />
                <br />
                <asp:Button class="btn btn-dark" ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Ingresar" />
                <br />
                <br />
            </div>
        </div>
    </div>
</asp:Content>
