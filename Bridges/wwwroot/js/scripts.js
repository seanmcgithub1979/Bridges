$(function () {

    $("#btnAdd").click(function () {
        window.location.href = "bridgesdetaileditview/add/";
    });

    $("#btnSave").click(function () {
        var id = $("#inputId").val();
        var name = $("#inputName").val();
        var filename = $("#inputFilename").val();
        var desc = $("#inputDesc").val();
        var lat = $("#inputLat").val();
        var lng = $("#inputLng").val();
        var zoom = $("#inputZoom").val();
        var height = $("#inputHeight").val();

        var url = "bridgesdetailview/update/"
            + encodeURIComponent(id) + "/"
            + encodeURIComponent(name) + "/"
            + encodeURIComponent(filename) + "/"
            + encodeURIComponent(desc) + "/"
            + encodeURIComponent(lat) + "/"
            + encodeURIComponent(lng) + "/"
            + encodeURIComponent(zoom) + "/"
            + encodeURIComponent(height) + "/";

        window.location.href = url;
    });

    $("#btnDelete").click(function () {
        //var alert = alert('Are you sure you want to DELETE this bridge?');
        //if (alert === alert.ok) {
        var id = $("#inputId").val();

        var url = "bridgeslistview/delete/1/"
            + encodeURIComponent(id) + "/";

        window.location.href = url;
        //}
    });

    $("#btnExportToCsv").click(function () {
        window.location.href = "bridgeslistview/exporttocsv/1";;
    });
    $("#btnExportToTxt").click(function () {
        window.location.href = "bridgeslistview/exporttotxt/1";;
    });
    $("#btnExportToHtml").click(function () {
        window.location.href = "bridgeslistview/exporttohtml/1";;
    });
    $("#btnExportToXml").click(function () {
        window.location.href = "bridgeslistview/exporttoxml/1";;
    });
});