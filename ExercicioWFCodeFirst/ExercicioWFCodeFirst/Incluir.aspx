<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Incluir.aspx.cs" Inherits="ExercicioWFCodeFirst.Incluir" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Inclusão de Pessoa</h1>
    <form id="form1" runat="server">
    <div>

        <asp:FormView runat="server"
          ID="pessoa"
          ItemType="ExercicioWFCodeFirst.Models.Pessoa"
          InsertMethod="pessoa_InsertItem"
          OnItemInserted="pessoa_ItemInserted"
          DefaultMode="Insert">
          <InsertItemTemplate>
           
           <label>Nome</label>
           <asp:DynamicControl runat="server" DataField="Nome" Mode="Insert"/>
           
           <label>Sobrenome</label>
           <asp:DynamicControl runat="server" DataField="Sobrenome" Mode="Insert"/>
           
           <label>CPF</label>
           <asp:DynamicControl runat="server" DataField="Cpf" Mode="Insert"/>

           <asp:Button runat="server" CommandName="Insert" Text="Incluir"/>
           <asp:Button runat="server" Text="Cancelar" OnClick="cancel_Click"/>
          </InsertItemTemplate>
        </asp:FormView>
    
    </div>
    </form>
</body>
</html>
