<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="calculator.aspx.cs" Inherits="calculadora.calculator" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="justify-content-center input-group-text">
        <div class="card border-danger">
            <asp:Label ID="lblLogeado" runat="server" Font-Bold="True" Font-Size="Medium" ForeColor="Red" BorderStyle="None" Font-Names="Comic Sans MS"></asp:Label>
            <img src="css/Captura.jpg" class="card-img" alt="...">
            <div class="card-body">
                <asp:TextBox class="justify-content-center  text-center" placeholder="Escriba el número 1" aria-label="Escriba el número 1"
                    aria-describedby="basic-addon1" ID="txt1" runat="server" Width="220px" MaxLength="7" TextMode="Number" Height="21px" Font-Bold="True"></asp:TextBox>
                <br />
                <asp:TextBox class="justify-content-center  text-center" placeholder="Escriba el número 2" aria-label="Escriba el número 2"
                    aria-describedby="basic-addon1" ID="txt2" runat="server" Width="220px" MaxLength="7" TextMode="Number" Height="23px" Font-Bold="True"></asp:TextBox>
                <br />
                <asp:Label ID="lbl" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="Red" BorderStyle="None" Font-Names="Comic Sans MS"></asp:Label>
                <br />
                <asp:TextBox class="justify-content-center text-center list-group-item-dark" placeholder="Total" aria-label="Total"
                    aria-describedby="basic-addon1" ID="txt3" runat="server" ReadOnly="True" Width="271px" Font-Bold="True" ForeColor="Blue" Height="33px"></asp:TextBox>
                <br />
                <br />
                <div>
                    <div class="justify-content-center btn-toolbar " role="toolbar" aria-label="Toolbar with button groups">
                        <asp:Button class="btn btn-outline-danger" ID="btnBorrar" runat="server" Text=" Borrar " Width="180px" OnClick="btnBorrar_Click" />
                    </div>
                    <br />
                    <div class="justify-content-center btn-toolbar " role="toolbar" aria-label="Toolbar with button groups">
                        <br />
                        <asp:Button class="btn btn-outline-primary" ID="btnResta" runat="server" Text=" Resta " Width="180px" OnClick="btnResta_Click" />
                        <asp:Button class="btn btn-outline-dark" ID="btnSuma" runat="server" Text=" Suma " Width="180px" OnClick="btnSuma_Click" />
                        <asp:Button class="btn btn-outline-success" ID="btnMul" runat="server" Text=" Multplicación " Width="180px" OnClick="btnMul_Click" />
                        <asp:Button class="btn btn-outline-warning" ID="btnDiv" runat="server" Text=" División " Width="180px" OnClick="btnDiv_Click" />
                        <br />
                        <br />
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
