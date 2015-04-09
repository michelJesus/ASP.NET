
function limparCampos() {
    $('input[name="produtoID"]').val('0');
    $('input[name="produtoNome"]').val('');
    $("option:selected").removeAttr("selected");
    $('input[name="insumoID"]').val('0');
    $('input[name="insumoDesc"]').val('');
}

function gravarProduto() {
    var produtoID = $('input[name="produtoID"]').val();
    var produtoNome = $('input[name="produtoNome"]').val();
    var insumosDoProduto = $('select[name="insumosDoProduto"]').val();

    if (produtoNome == "" || insumosDoProduto == null) {
        alert("Preencha o nome do produto e selecione insumos!");
        return;
    }

    $.post(
       '/Home/GravarProduto',
       { id: produtoID, nome: produtoNome, insumos: JSON.stringify(insumosDoProduto) }
    ).done(function (produtos) {
        limparCampos();
        listarProdutos(produtos);
    });
}

function alterarProduto(produtoID) {
    $.getJSON('/Home/CarregarProduto', { id: produtoID }).done(function (dados) {
        $('input[name="produtoID"]').val(dados.produto.ProdutoID);
        $('input[name="produtoNome"]').val(dados.produto.Nome);
        $('select[name="insumosDoProduto"]').html(listarInsumosDoProduto(dados.insumos, dados.produto.Insumos));
    });
}

function excluirProduto(produtoID) {
    var confirmado = confirm("Confirma a exclusão do Produto?");
    if (confirmado == true) {
        $.post(
           '/Home/ExcluirProduto',
           { id: produtoID }
        ).done(function (produtos) {
            limparCampos();
            listarProdutos(produtos);
        });
    }
}

function listarProdutos(produtos) {

    $('.listaDeProdutos').empty();
    $('.listaDeProdutos').append(
      '<tr><th>ID</th><th>Nome</th><th>Insumos</th><th>Comandos</th></tr>'
    );

    for (var i = 0; i < produtos.length; i++) {
        var produto = produtos[i];

        //Lista de produtos cadastrados
        $('.listaDeProdutos').append(
            '<tr><td>' + produto.ProdutoID + '</td>' +
                '<td>' + produto.Nome + '</td>' +
                '<td>' + listarInsumosDoProduto(produto.Insumos) + '</td>' +
                '<td><span><a onclick="alterarProduto(' + produto.ProdutoID + ')" href="#">Alterar</a></span>' +
                ' | <span><a onclick="excluirProduto(' + produto.ProdutoID + ')" href="#">Excluir</a></span></td>' +
            '</tr>'
        );
    }
}

function listarInsumosDoProduto(insumos, insumosSelecionados) {
    var lista = '';
    for (var i = 0; i < insumos.length; i++) {
        var insumo = insumos[i];
        if (insumosSelecionados != null && isSelecionado(insumo, insumosSelecionados)) {
            lista += "<option selected='selected' value=" + insumo.InsumoID + ">" + insumo.Descricao + "</option>"
        }
        else {
            lista += "<option value=" + insumo.InsumoID + ">" + insumo.Descricao + "</option>"
        }
    }
    return lista;
}

function isSelecionado(insumo, insumosSelecionados) {
    for (var i = 0; i < insumosSelecionados.length; i++) {
        var insumoSelecionado = insumosSelecionados[i];
        if (insumo.InsumoID == insumoSelecionado.InsumoID) {
            return true;
        }
    }
    return false;
}

function gravarInsumo() {
    var insumoID = $('input[name="insumoID"]').val();
    var insumoDesc = $('input[name="insumoDesc"]').val();

    if (insumoDesc == "") {
        alert("Preencha a descrição do insumo!");
        return;
    }

    $.post(
       '/Home/GravarInsumo',
       { id: insumoID, descricao: insumoDesc }
    ).done(function (insumos) {
        limparCampos();
        listarInsumos(insumos);
    });
}

function alterarInsumo(insumoID) {
    $.getJSON('/Home/CarregarInsumo', { id: insumoID }).done(function (insumo) {
        $('input[name="insumoID"]').val(insumo.InsumoID);
        $('input[name="insumoDesc"]').val(insumo.Descricao);
    });
}

function excluirInsumo(insumoID) {
    var confirmado = confirm("Confirma a exclusão do Insumo?");
    if (confirmado == true) {
        $.post(
           '/Home/ExcluirInsumo',
           { id: insumoID }
        ).done(function (insumos) {
            limparCampos();
            listarInsumos(insumos);
        });
    }
}

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

function mostrarHome() {
    $('.titulo').html("Cadastro de Produtos");
    $('.painelInsumo').hide();
    $('.painelHome').show();
    $.getJSON('/Home/CarregarProdutos').done(function (produtos) {
        listarProdutos(produtos);
    });
}

function mostrarInsumo() {
    $('.titulo').html("Cadastro de Insumos");
    $('.painelHome').hide();
    $('.painelInsumo').show();
}

$(document).ready(function () {

    $.getJSON('/Home/CarregarProdutos').done(function (produtos) {
        listarProdutos(produtos);
    });

    $.getJSON('/Home/CarregarInsumos').done(function (insumos) {
        listarInsumos(insumos);
    });
});