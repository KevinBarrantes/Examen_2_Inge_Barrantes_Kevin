function FillOption() {
    $.ajax({
        type: "Post",
        url: "/Dough/FillDropDough",
        dataType: 'json',
        success: function (data) {
            for (var i = 0; i < data.length; i++) {
                $('#dough').append('<option value=' + data[i].Value + '>' + data[i].Text + '</option > ');
            }
        }
    });
}

$(document).ready(function () {
    $.ajax({
        url: "/Dough/FillDropDough",
        type: 'POST',
        data: JSON.stringify({}),
        dataType: 'html', //recicinvg type
        contentType: 'application/json; charset=utf-8',//sending type
        //contentType: 'html',
        success: function (htmlForm) {
            $(htmlForm).appendTo('#dough');
        },
        error: function (a, b, c, d) {
            //alert(JSON.stringify(a));
            //alert(JSON.stringify(b));
        }
    });

    return false;
});