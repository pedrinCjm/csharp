var CoSeqCategoriaAvaliacao;
var CoSeqTpAvaliacao;
var CoSeqAvaliacao;
var dataInicioPeriodo;
var dataFinalPeriodo;

function carregaUF() {
    var token = getCookie("token");
    let CoSeqRegiaoBrasil = 0;

    if ($("#inputFormBuscarRegiao").val() != null) {
        CoSeqRegiaoBrasil = $("#inputFormBuscarRegiao").val();
    }

    $.ajax({
        type: "GET",
        url: url_api + `Ufs/regiao/${CoSeqRegiaoBrasil}`,
        headers: {
            'Content-Type': 'application/json',
            'Authorization': 'Bearer ' + token
        },
        contentType: "application/json",
        dataType: "json",
        async: false,
        success: function (data) {
            $('inputFormBuscarUf').empty();
            var foo = document.getElementById('inputFormBuscarUf');
            while (foo.firstChild) foo.removeChild(foo.firstChild);

            var opt = document.createElement("option");
            opt.text = "-- Selecione --";
            opt.value = "0";
            document.getElementById('inputFormBuscarUf').options.add(opt);

            for (var i in data) {
                var opt = document.createElement("option");
                opt.text = data[i].noUf;
                opt.value = data[i].coSeqUf;
                document.getElementById('inputFormBuscarUf').options.add(opt);
            }
        },
        error: function () {
            console.log("Não achou!");
        }
    });
}

function carregaCidade() {
    var token = getCookie("token");

    var str_UF = $("#inputFormBuscarUf").val();

    $('inputFormBuscarCidade').empty();
    var foo = document.getElementById('inputFormBuscarCidade');
    while (foo.firstChild) foo.removeChild(foo.firstChild);

    $.ajax({
        type: "GET",
        url: url_api + `Municipios/uf/${str_UF}`,
        headers: {
            'Content-Type': 'application/json',
            'Authorization': 'Bearer ' + token
        },
        contentType: "application/json",
        dataType: "json",
        async: false,
        success: function (data) {
            var opt = document.createElement("option");
            opt.text = "-- Selecione --";
            opt.value = "0";
            document.getElementById('inputFormBuscarCidade').options.add(opt);

            for (var i in data) {
                var opt = document.createElement("option");
                opt.text = data[i].noMunicipio;
                opt.value = data[i].coSeqMunicipio;
                document.getElementById('inputFormBuscarCidade').options.add(opt);
            }
        },
        error: function () {
            console.log("Não achou!");
        }
    });
}

function carregaRegiao() {
    var token = getCookie("token");

    $.ajax({
        type: "GET",
        url: url_api + `RegiaoBrasil`,
        headers: {
            'Content-Type': 'application/json',
            'Authorization': 'Bearer ' + token
        },
        contentType: "application/json",
        dataType: "json",
        async: false,
        success: function (data) {
            var opt = document.createElement("option");
            opt.text = "-- Selecione --";
            opt.value = "0";
            document.getElementById('inputFormBuscarRegiao').options.add(opt);

            for (var i in data) {
                var opt = document.createElement("option");
                opt.text = data[i].noRegiaoBrasil;
                opt.value = data[i].coSeqRegiaoBrasil;
                document.getElementById('inputFormBuscarRegiao').options.add(opt);
            }
        },
        error: function () {
            console.log("Não achou!");
        }
    });
}

function carregaInstituicoes() {
    var token = getCookie("token");

    $.ajax({
        type: "GET",
        url: url_api + `Instituicoes`,
        headers: {
            'Content-Type': 'application/json',
            'Authorization': 'Bearer ' + token
        },
        contentType: "application/json",
        dataType: "json",
        async: false,
        success: function (data) {
            var opt = document.createElement("option");
            opt.text = "-- Selecione --";
            opt.value = "0";
            document.getElementById('inputFormBuscarInstituicao').options.add(opt);

            for (var i in data) {
                var opt = document.createElement("option");
                opt.text = data[i].noInstituicao;
                opt.value = data[i].noInstituicao;
                document.getElementById('inputFormBuscarInstituicao').options.add(opt);
            }
        },
        error: function () {
            console.log("Não achou!");
        }
    });
}

function carregaCategorias() {
    var token = getCookie("token");

    $.ajax({
        type: "GET",
        url: url_api + `CategoriaAvaliacoes`,
        headers: {
            'Content-Type': 'application/json',
            'Authorization': 'Bearer ' + token
        },
        contentType: "application/json",
        dataType: "json",
        async: false,
        success: function (data) {
            var opt = document.createElement("option");
            opt.text = "-- Selecione --";
            opt.value = "0";
            document.getElementById('inputFormBuscarCategoria').options.add(opt);

            for (var i in data) {
                var opt = document.createElement("option");
                opt.text = data[i].dsCategoriaAvaliacao;
                opt.value = data[i].coSeqCategoriaAvaliacao;
                document.getElementById('inputFormBuscarCategoria').options.add(opt);
            }
        },
        error: function () {
            console.log("Não achou!");
        }
    });
}

function obtemTipoAvaliacao() {

    var token = getCookie("token");

    $.ajax({
        type: "GET",
        url: url_api + `TipoAvaliacoes`,
        headers: {
            'Content-Type': 'application/json',
            'Authorization': 'Bearer ' + token
        },
        contentType: "application/json",
        dataType: "json",
        async: false,
        success: function (TipoAvaliacoes) {


            var opt = document.createElement("option");
            opt.text = "-- Selecione --";
            opt.value = "0";
            document.getElementById('inputFormBuscarTipo').options.add(opt);

            for (var i in TipoAvaliacoes) {
                var opt = document.createElement("option");
                opt.text = TipoAvaliacoes[i].dsTpAvaliacao;
                opt.value = TipoAvaliacoes[i].coSeqTpAvaliacao;
                document.getElementById('inputFormBuscarTipo').options.add(opt);
            }
        },
        error: function (jqXHR, textStatus, errorThrown) {
            console.log("Erro ao acarregar os tipos de avaliação");
        }
    });
}

function carregaAvaliacoes() {
    var token = getCookie("token");

    CoSeqAvaliacao = 0;
    CoSeqCategoriaAvaliacao = 0;
    CoSeqTpAvaliacao = 0;

    dataInicioPeriodo = $("#inputFormBuscarDataInicial").val();
    dataFinalPeriodo = $("#inputFormBuscarDataFinal").val();

    if (dataInicioPeriodo == "") { dataInicioPeriodo = '1900-01-01' }
    if (dataFinalPeriodo == "") { dataFinalPeriodo = '9999-12-12' }
    if ($("#inputFormBuscarCategoria").val() != null) { CoSeqCategoriaAvaliacao = $("#inputFormBuscarCategoria").val(); }
    if ($("#inputFormBuscarTipo").val() != null) { CoSeqTpAvaliacao = $("#inputFormBuscarTipo").val(); }

    $('inputFormBuscarAvaliacoes').empty();
    var foo = document.getElementById('inputFormBuscarAvaliacoes');
    while (foo.firstChild) foo.removeChild(foo.firstChild);

    $.ajax({
        type: "GET",
        url: url_api + `Avaliacoes/all/${CoSeqTpAvaliacao}/${CoSeqAvaliacao}/${dataInicioPeriodo}/${dataFinalPeriodo}/${CoSeqCategoriaAvaliacao}`, //`Avaliacoes/geral/0`,
        headers: {
            'Content-Type': 'application/json',
            'Authorization': 'Bearer ' + token
        },
        contentType: "application/json",
        dataType: "json",
        async: false,
        success: function (data) {
            var opt = document.createElement("option");
            opt.text = "-- Selecione --";
            opt.value = "0";
            document.getElementById('inputFormBuscarAvaliacoes').options.add(opt);

            for (var i in data) {
                var opt = document.createElement("option");
                opt.text = data[i].dsAvaliacao;
                opt.value = data[i].coSeqAvaliacao;
                document.getElementById('inputFormBuscarAvaliacoes').options.add(opt);
            }
        },
        error: function () {
            console.log("Não achou!");
        }
    });
}

function carregaInstituicoes() {
    var token = getCookie("token");

    $.ajax({
        type: "GET",
        url: url_api + `UsuarioInstituicoes/instituicoes`,
        headers: {
            'Content-Type': 'application/json',
            'Authorization': 'Bearer ' + token
        },
        contentType: "application/json",
        dataType: "json",
        async: false,
        success: function (data) {
            var opt = document.createElement("option");

            //if (data.length > 1) {
            //    opt.text = "-- Selecione --";
            //    opt.value = "0";
            //    document.getElementById('inputFormBuscarInstituicao').options.add(opt);
            //}

            for (var i in data) {
                var opt = document.createElement("option");
                opt.text = data[i].noInstituicao;
                opt.value = data[i].coSeqInstituicao;
                document.getElementById('inputFormBuscarInstituicao').options.add(opt);
            }
        },
        error: function () {
            console.log("Erro ao carregar instituições!");
        }
    });
}


function exportTableToExcel(tableId, filename) {
    let dataType = 'application/vnd.ms-excel;charset=utf-8';
    let extension = '.xls';

    let base64 = function (s) {
        return window.btoa(unescape(encodeURIComponent(s)))
    };

    let template = '<html xmlns:o="urn:schemas-microsoft-com:office:office" xmlns:x="urn:schemas-microsoft-com:office:excel" xmlns="http://www.w3.org/TR/REC-html40"><head><!--[if gte mso 9]><xml><x:ExcelWorkbook><x:ExcelWorksheets><x:ExcelWorksheet><x:Name>{worksheet}</x:Name><x:WorksheetOptions><x:DisplayGridlines/></x:WorksheetOptions></x:ExcelWorksheet></x:ExcelWorksheets></x:ExcelWorkbook></xml><![endif]--></head><body><table>{table}</table></body></html>';
    let render = function (template, content) {
        return template.replace(/{(\w+)}/g, function (m, p) { return content[p]; });
    };

    let tableElement = document.getElementById(tableId);

    let tableExcel = render(template, {
        worksheet: filename,
        table: tableElement.innerHTML
    });

    filename = filename + extension;

    if (navigator.msSaveOrOpenBlob) {
        let blob = new Blob(
            ['\ufeff', tableExcel],
            { type: dataType }
        );

        navigator.msSaveOrOpenBlob(blob, filename);
    } else {
        let downloadLink = document.createElement("a");

        document.body.appendChild(downloadLink);

        downloadLink.href = 'data:' + dataType + ';base64,' + base64(tableExcel);

        downloadLink.download = filename;

        downloadLink.click();
    }
    var objectUrl = URL.createObjectURL(tableExcel);
    window.open(objectUrl);
}

function exportTableToExcel2(tableID, filename = '') {
    var downloadLink;
    var dataType = 'application/vnd.ms-excel';
    var tableSelect = document.getElementById(tableID);
    var tableHTML = tableSelect.outerHTML.replace(/ /g, '%20');

    // Specify file name
    filename = filename ? filename + '.xls' : 'excel_data.xls';

    // Create download link element
    downloadLink = document.createElement("a");

    document.body.appendChild(downloadLink);

    if (navigator.msSaveOrOpenBlob) {
        var blob = new Blob(['\ufeff', tableHTML], {
            type: dataType
        });
        navigator.msSaveOrOpenBlob(blob, filename);
    } else {
        // Create a link to the file
        downloadLink.href = 'data:' + dataType + ', ' + tableHTML;

        // Setting the file name
        downloadLink.download = filename;

        //triggering the function
        downloadLink.click();
    }
}