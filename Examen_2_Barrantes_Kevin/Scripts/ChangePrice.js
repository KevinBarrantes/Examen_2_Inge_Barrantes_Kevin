$(document).ready(function () {
    $(".size").change(function () {
        //var $this = $(this);
        //var url = $this.parent().data("submit-url") + "?userId=" + $this.val();
        //window.location.href = url;
        selection = document.getElementById("Precio").value;
        selection = parseInt(selection);
        $('#Precio').hide();
        switch (selection) {
            case "0":
                $('#precio').html(4000);

            case "1":
                $("#precio").val(4500);

            case "2":
                $("#precio").val(6000);
        }        
    });

});