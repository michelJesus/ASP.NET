<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Detalhes.aspx.cs" Inherits="ExercicioWFCodeFirst.Detalhes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Detalhes da Pessoa</h1>
    <form id="form1" runat="server">
    <div>

        <asp:FormView runat="server"
          ID="PessoaID"
            ItemType="ExercicioWFCodeFirst.Models.Pessoa"
            DataKeyNames="PessoaID" 
            SelectMethod="pessoa_GetItem">
          <ItemTemplate>
           <label>Nome</label>
           <asp:DynamicControl runat="server" DataField="Nome" Mode="ReadOnly" />
           <asp:DynamicControl runat="server" DataField="Sobrenome" Mode="ReadOnly" />
           <asp:DynamicControl runat="server" DataField="Cpf" Mode="ReadOnly" />
           
           <asp:Button runat="server" OnClick="voltar_Click" Text="Voltar"/>
          </ItemTemplate>
         </asp:FormView>

    
    </div>
    </form>
</body>
</html>
