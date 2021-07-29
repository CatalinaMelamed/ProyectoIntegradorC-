$('#Articulos').multiSelect();
//$('#ICalculadora').ready(); {
//    var n1 = $("#n1").val();
//    var n2 = $("#n2").val();
//    $.ajax({
//        $.ajax({
//            type: "POST",
//            url: "@Url.Action("Add")",
//    })
//}

$(function () {
    $("#Calcular").click(function () {
        let articulos = $("#Articulos").val();       
        debugger
        $.ajax({            
            url: "../../Home/AjaxCalcular",
            type: "GET",
            traditional: true,
            data: { articulos: articulos },
            dataType: "json",
            contentType: "application/json; charset=utf-8",
            success: articulos.forEach(function (articulos) {

                console.log(msg);
            },
            //error: function (req, status, error) {
            //    console.log(msg);
            //}
        });
    });
});
    
    

  

