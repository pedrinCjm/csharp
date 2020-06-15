function obtemCarros() {

    console.log("inicio");
    $.ajax({
        type: "GET",
        url: `https://localhost:44381/api/Carros/lista`,
        headers: {
            'Content-Type': 'application/json'
        },
        contentType: "application/json",
        //data: JSON.stringify(lista),
        success: function (resultado) {
            console.log(resultado);
        },
        error: function (jqXHR, textStatus, errorThrown) {
            console.log(errorThrown)
        }
    });
    console.log("fim");
}