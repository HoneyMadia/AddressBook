<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListBox.aspx.cs" Inherits="List_Box_ListBox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>List Box</title>
    <style type="text/css">
        .auto-style1 {
            width: 312px;
        }
    </style>
</head>
<body id="lblMessage1">
    <form id="form1" runat="server">
    <div style="background-color: lightpink">
        <h1 align="center">List Box HOney madia</h1>
    </div><hr />
        <table>
            <tr>
                <td class="auto-style1">
                    Country Name : <asp:TextBox runat="server" ID="txtCountryName" CssClass="form-control" /><br/><br/>
                    Country Code : <asp:TextBox runat="server" ID="txtCountryCode" CssClass="form-control" TextMode="Number"/><br/><br/>
                    
                    <asp:Button ID="btnAddItem" runat="server" Text="Add Item"  CssClass="btn btn-info" OnClick="btnAddItem_Click" />
                    <asp:Button ID="btnRemove" runat="server" Text="Remove Item" CssClass="btn btn-danger" OnClick="btnRemove_Click" /><br/>
                    
                </td>
            </tr>
            
            <tr>
                <td class="auto-style1">
                    <asp:ListBox ID="lbCountry1" runat="server" Rows="5" SelectionMode="Multiple" Width="115px">
                    </asp:ListBox>

                </td>
                <td><asp:Button runat="server" ID="btnAddAll" Text=">>" CssClass="btn btn-info" OnClick="btnAddAll_Click" /><br />
                    <asp:Button runat="server" ID="btnAddOne" Text=">" CssClass="btn btn-info" OnClick="btnAddOne_Click"/><br />
                    <asp:Button runat="server" ID="btnRemoveOne" Text="<" CssClass="btn btn-info" OnClick="btnRemoveOne_Click" /><br />
                    <asp:Button runat="server" ID="btnRemoveAll" Text="<<" CssClass="btn btn-info" OnClick="btnRemoveAll_Click" /><br />
                </td>
                <td><asp:ListBox ID="lbCountry2" runat="server" Rows="5" SelectionMode="Multiple" Width="115px">
                    </asp:ListBox>
                </td>
            </tr>
        </table>


    <div>
        <br />
        <asp:button ID="btnShow" Text="Show" runat="server" CssClass="btn btn-info" OnClick="btnShow_Click"/>
        <br />

    </div>
        <p>
                    <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
                    
                </p>
        <p>
                    <asp:Label ID="lblMessage1" runat="server" ></asp:Label>
                    
                </p>
    </form>
</body>
</html>
