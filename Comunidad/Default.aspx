<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Comunidad._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <asp:Label ID="Label1" runat="server" Text="Los Celages"></asp:Label>
        <asp:GridView ID="GridView2" runat="server" OnSelectedIndexChanged="GridView2_SelectedIndexChanged">
        </asp:GridView>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>
            <asp:Button ID="bttAbrir" runat="server" OnClick="bttAbrir_Click" Text="Gastos" />
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Comunidad" />
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Propiedad" />
                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Pagos" />
                <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Propietarios" />
            </h2>
            <p>
                &nbsp;</p>
        </div>
    </div>

</asp:Content>
