function obtemPartidas() {
    console.log("inicioNovo");
    console.log(url_api);
    console.log("oi");
    $.ajax({
        type: "GET",
        url: `https://localhost:44385/api/Partidas/listaPartidas`,
        headers: {
            'Content-Type': 'application/json'
        },
        //data: JSON.stringify(lista),
        success: function (resultado) {
            console.log(resultado);
        },
        error: function (jqXHR, textStatus, errorThrown) {
            console.log(errorThrown)
        }
    });
    console.log("fim");
    console.log("oi");
}

function personalizaTabela() {
    $('#tabelaDados').DataTable({
        dom: '<"table-layout-a"<"top d-flex justify-content-between"<"toolbar">l>rt<"bottom"ifp><"clear">>',
        searching: false,
        order: [
            [0, "desc"]
        ],
        columnDefs: [{
            "orderable": false,
            "targets": [5]
        }
        ],
        language: {
            url: "/vendor/datatables/Portuguese-Brasil.json"
        }
    });
}