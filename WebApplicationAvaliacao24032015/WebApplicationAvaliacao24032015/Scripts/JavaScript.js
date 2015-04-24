function Incluir() {
    $.post("/Home/Incluir", {
        Nome: $("#Nome").val()            
    }).done(function (data) {
        
        alert("Salvo com sucesso");
        //alert("Json retona: " + data);

        

        $.each(data, function (index, data) {
            $('#div').append('<p>' + data + '</p>');
        });

        
        /*

        $.each(data, function (index, data) {
            $('#table').append('<tr><td>' + data + '</td><td><input type="button" value="Editar" onclick="Editar()"/></td><td><input type="button" value="Excluir" onclick="Excluir()"/></td></tr>');
        });

        */


    });
}


