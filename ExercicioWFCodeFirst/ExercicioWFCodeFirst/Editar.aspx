<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Editar.aspx.cs" Inherits="ExercicioWFCodeFirst.Editar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Editar Pessoa</h1>
    <form id="form1" runat="server">
    <div>

        <asp:FormView runat="server" 
            ID="PessoaID"
            ItemType="ExercicioWFCodeFirst.Models.Pessoa"
            DataKeyNames="PessoaID" 
            SelectMethod="PessoaID_GetItem"
            UpdateMethod="PessoaID_UpdateItem" 
            OnItemUpdated="PessoaID_ItemUpdated"
            DefaultMode="Edit">
          <EditItemTemplate>
           
           <label>Nome</label>
           <asp:DynamicControl runat="server" DataField="Nome" Mode="Edit"/>
              <asp:DynamicControl runat="server" DataField="Sobrenome" Mode="Edit" />
              <asp:DynamicControl runat="server" DataField="Cpf" Mode="Edit" />

           
           <asp:Button runat="server" CommandName="Update" Text="Atualizar"/>
           <asp:Button runat="server" Text="Cancelar" OnClick="cancelar_Click"/>
          </EditItemTemplate>
         </asp:FormView>
    
    </div>
    </form>
</body>
</html>
