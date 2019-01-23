$("document").ready(function () {
    $.ajax({
        url: "http://localhost:2889/api/ClienteApi",
        type: "GET"
    }).done(function (cli) {
        $.each(cli, function (a, b) {
            
            $("#ClienteId").append(
                "<option value="+ b["ClienteId"] + ">" + b["Nome"] + "</option>"
                );
        });
    });
    $.ajax({
        url: "http://localhost:2889/api/ProdutoApi",
        type: "GET"
    }).done(function (pro) {
        $.each(pro, function (a, b) {
            $("#ProdutoId").append(
                "<option value=" + b["ProdutoId"] + ">" + b["Nome"] + "</option>"
                );
        });
    });
});

