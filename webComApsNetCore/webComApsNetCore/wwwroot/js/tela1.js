function obterDados() {

    console.log("entrou aqui");

    $.ajax({
        type: "GET",
        url: "../api/Empresas",
        enumerable: true,
        success: function (Empresa) {
            console.log(Empresa);
            for (var i in Empresa) {
                console.log(Empresa[i].nome);
            }
        }
    });

    var div = document.getElementById("divEmpresa");

    //div.innerHTML = "<h1>Dados: " + retorno[1].nome + "</h1>";
    //
    //$(divEmpresa).html("<h1>Novo texto</h1>");
}