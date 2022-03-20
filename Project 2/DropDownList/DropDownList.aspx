<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DropDownList.aspx.cs" Inherits="DropDownList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="background-color: lightpink">
        <h1 align="center">Drop Down List</h1>
    </div><hr />
    <div>
        Country Name: <asp:TextBox runat="server" ID="txtCountryName" CssClass="form-control" ></asp:TextBox><br /><br />
        Country Code: <asp:TextBox runat="server" ID="txtCountryCode" TextMode="Number" CssClass="form-control"></asp:TextBox><br /><br />
        <asp:Button runat="server" ID="btnAddItem" Text="Add Item" CssClass="btn btn-info" OnClick="btnAddItem_Click" />
        <asp:Button runat="server" ID="btnRemoveItem" Text="RemoveItem" CssClass="btn btn-danger" OnClick="btnRemoveItem_Click" />
        <hr />

        <asp:DropDownList ID="ddlCountry" runat="server" CssClass="btn btn-secondary dropdown-toggle">
           <%-- <asp:ListItem Value="91">India</asp:ListItem>
            <asp:ListItem Value="92">China</asp:ListItem>
            <asp:ListItem Value="93">Srilanka</asp:ListItem>
            <asp:ListItem Value="94">Bangladesh</asp:ListItem>
            <asp:ListItem Value="95">Nepal</asp:ListItem>
            <asp:ListItem Value="96">USA</asp:ListItem>--%>
        </asp:DropDownList><br />
        <br />
        <asp:button ID="btnShow" Text="Show" runat="server" CssClass="btn btn-info" OnClick="btnShow_Click"/>
        <br /><br />
         <div class="col-md-4 row">
            <asp:Label runat="server" ID="lblMes"></asp:Label>
        </div>
        
        <p>
            <asp:Label ID="lblMessage" runat="server"></asp:Label>
        </p> 
    </div>
    </form>
</body>
</html>
