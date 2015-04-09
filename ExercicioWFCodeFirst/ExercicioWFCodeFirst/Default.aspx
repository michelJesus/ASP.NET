<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ExercicioWFCodeFirst.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Cadastro de Pessoa</h1>
    <a href="Incluir.aspx">Nova Pessoa</a>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView runat="server"
            ID="pessoa"
            ItemType="ExercicioWFCodeFirst.Models.Pessoa"
          DataKeyNames="PessoaID" SelectMethod="pessoa_GetData"
          AutoGenerateColumns="False">
          <Columns>
           <asp:DynamicField HeaderText="ID" DataField="PessoaID"/>
           <asp:DynamicField HeaderText="Nome" DataField="Nome"/>
           <asp:DynamicField HeaderText="Sobrenome" DataField="Sobrenome" />
           <asp:DynamicField HeaderText="Cpf" DataField="Cpf" />
           <asp:TemplateField HeaderText="Comandos">

            <ItemTemplate>
             <asp:HyperLink runat="server" Text="Visualizar" NavigateUrl='<%# "~/Detalhes.aspx?PessoaID=" + Item.PessoaID %>'/>
             <asp:HyperLink runat="server" Text="Editar" NavigateUrl='<%# "~/Editar.aspx?PessoaID=" + Item.PessoaID %>'/>
             <asp:HyperLink runat="server" Text="Excluir" NavigateUrl='<%# "~/Excluir.aspx?PessoaID=" + Item.PessoaID %>'/>
                  
            </ItemTemplate>
           </asp:TemplateField>
          </Columns>
         </asp:GridView>

    </div>
    </form>
</body>
</html>
