function incluir(clientes)
{
    alert("Salvo com sucesso!");

    $.post("/Index/Incluir",
        {
            id: CLienteID, nome: Nome, isAtivo: IsAtivo
        }).done(function (data) 
        {
            $.each(data, function (index, data) {
                $('#divContent').append(data.Nome, data.IsAtivo);
            });
       });
}

/*
function listarInsumos(insumos) {

    $('.listaDeInsumos').empty();
    $('.listaDeInsumos').append(
            '<tr><th>ID</th><th>Descrição</th><th>Comandos</th></tr>'
    );

    $('select[name="insumosDoProduto"]').empty();

    for (var i = 0; i < insumos.length; i++) {
        var insumo = insumos[i];

        //Lista de insumos cadastrados
        $('.listaDeInsumos').append(
            '<tr><td>' + insumo.InsumoID + '</td><td>'
                       + insumo.Descricao + '</td><td>'
                       + '<span><a onclick="alterarInsumo(' + insumo.InsumoID + ')" href="#">Alterar</a></span>'
                       + ' | <span><a onclick="excluirInsumo(' + insumo.InsumoID + ')" href="#">Excluir</a></span>'
                       + '</td></tr>'
        );

        //Multiseleção para o cadastro de produtos
        $('select[name="insumosDoProduto"]').append(
           '<option value="' + insumo.InsumoID + '">' + insumo.Descricao + '</tr>'
        );
    }
}
*/