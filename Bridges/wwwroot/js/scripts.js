﻿function AddBridge() {
    window.location.href = "bridgesdetaileditview/add/";
};

function UpdateBridge() {
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
};

function DeleteBridge() {
    if (confirm("Delete this bridge ?")) {
        var id = $("#inputId").val();

        var url = "bridgeslistview/delete/1/"
            + encodeURIComponent(id) + "/";

        window.location.href = url;
    }
};

function ExportToCsv() {
    window.location.href = "bridgeslistview/exporttocsv/1";;
};

function ExportToTxt() {
    window.location.href = "bridgeslistview/exporttotxt/1";;
};

function ExportToHtml() {
    window.location.href = "bridgeslistview/exporttohtml/1";;
};

function ExportToXml() {
    window.location.href = "bridgeslistview/exporttoxml/1";;
};
