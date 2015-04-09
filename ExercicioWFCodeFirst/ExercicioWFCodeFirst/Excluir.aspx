<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Excluir.aspx.cs" Inherits="ExercicioWFCodeFirst.Excluir" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Confirma exlusão?</h1>
    <form id="form1" runat="server">
    <div>

        <asp:FormView runat="server" 
            ID="pessoa"
            ItemType="ExercicioWFCodeFirst.Models.Pessoa"
            DataKeyNames="PessoaID" 
            SelectMethod="pessoa_GetItem"
            DeleteMethod="pessoa_DeleteItem" 
            OnItemDeleted="pessoa_ItemDeleted">
          <ItemTemplate>
           <label>Nome</label>
           <asp:DynamicControl runat="server" DataField="Nome" Mode="ReadOnly"/>
           <asp:DynamicControl runat="server" DataField="Sobrenome" Mode="ReadOnly"/>
           <asp:DynamicControl runat="server" DataField="Cpf" Mode="ReadOnly"/>

           <asp:Button runat="server" CommandName="Delete" Text="Confirmar"/>
           <asp:Button runat="server" OnClick="cancelar_Click" Text="Cancelar"/>
          </ItemTemplate>        
         </asp:FormView>
    
    </div>
    </form>
</body>
</html>
