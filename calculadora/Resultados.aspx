<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="resultados.aspx.cs" Inherits="calculadora.Resultados" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="justify-content-center input-group-text">
        <div class="card border-danger">
            <asp:Label ID="lblLogeado" runat="server" Font-Bold="True" Font-Size="Medium" ForeColor="Red" BorderStyle="None" Font-Names="Comic Sans MS"></asp:Label>
            <img src="css/resultados.jpg" class="card-img" alt="...">
            <div class="card-body">
                <asp:Button class="btn btn-primary" ID="btnResultados" runat="server" Text="Volver a la calculadora" Width="180px" OnClick="btnResultados_Click" />
                <br />
                <br />
                <div>
                    <div>
                        <asp:Label ID="lbl1" runat="server" Text="Total Suma" Font-Bold="True" Font-Italic="True" Font-Names="comic sans ms, medium" Font-Size="Small"></asp:Label>
                        &nbsp;
                        <asp:TextBox class="justify-content-center text-center list-group-item-dark" placeholder="Total Suma" aria-label="Total Suma"
                            aria-describedby="basic-addon1" ID="txtSuma" runat="server" Width="191px" MaxLength="7" Height="21px" ReadOnly="True"></asp:TextBox>
                        <br />
                        <br />
                    </div>
                    <asp:Label ID="lbl2" runat="server" Text="Total Resta" Font-Bold="True" Font-Italic="True" Font-Names="comic sans ms, medium" Font-Size="Small"></asp:Label>
                    &nbsp;
                    <asp:TextBox class="justify-content-center text-center list-group-item-dark" placeholder="Total Resta" aria-label="Total Resta"
                        aria-describedby="basic-addon1" ID="txtResta" runat="server" Width="196px" MaxLength="7" Height="21px" ReadOnly="True"></asp:TextBox>
                    <br />
                    <br />
                    <div>
                        <asp:Label ID="lbl3" runat="server" Text="Total Mul" Font-Bold="True" Font-Italic="True" Font-Names="comic sans ms, medium" Font-Size="Small"></asp:Label>
                        &nbsp;
                        <asp:TextBox class="justify-content-center text-center list-group-item-dark" placeholder="Total Multiplicación" aria-label="Total Multiplicación"
                            aria-describedby="basic-addon1" ID="txtMul" runat="server" Width="200px" MaxLength="7" Height="21px" ReadOnly="True"></asp:TextBox>
                        <br />
                        <br />
                        <asp:Label ID="lbl4" runat="server" Text="Total Div" Font-Bold="True" Font-Italic="True" Font-Names="comic sans ms, medium" Font-Size="Small"></asp:Label>
                        &nbsp;
                        <asp:TextBox class="justify-content-center text-center list-group-item-dark" placeholder="Total Divición" aria-label="Total Divición"
                            aria-describedby="basic-addon1" ID="txtDiv" runat="server" Width="207px" MaxLength="7" Height="21px" ReadOnly="True"></asp:TextBox>
                        <br />
                        <br />
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
