<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PrimeiroWebForms.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 126px;
        }
        .auto-style3 {
            width: 123px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Nome:</td>
                <td>
                    <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Sobrenome:</td>
                <td>
                    <asp:TextBox ID="txtSobrenome" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
                </td>
            </tr>
        </table>
    
    </div>
        <p>
            &nbsp;</p>
        <p id="lblDemonstracao">
            <asp:Label ID="lblDemonstracao" runat="server" Text="Label"></asp:Label>
        </p>
    
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <table class="auto-style1">
        <tr>
            <td class="auto-style3">Nome:</td>
            <td>
                <input id="Hidden1" type="hidden" />
                <input id="txtNome2" type="text" /></td>
        </tr>
        <tr>
            <td class="auto-style3">Sobrenome:</td>
            <td>
                <input id="Hidden2" type="hidden" />
                <input id="txtSobrenome2" type="text" /></td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td>
                <input id="btnSubmit2" type="submit" value="Submit 2" /></td>
        </tr>
    </table>
    </form>
</body>
</html>
