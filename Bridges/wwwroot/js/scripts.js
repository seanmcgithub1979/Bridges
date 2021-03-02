function AddBridge() {
    window.location.href = "bridgesdetaileditview/add/0/";
};

function UpdateBridge(id, name, filename, desc, lat, lng, zoom, height) {
    //var fReader = new FileReader();

    //fReader.readAsDataURL(file);
    //fReader.onloadend = function (event) {
    //}

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

function UploadFile(file) {
    var fReader = new FileReader();

    fReader.readAsDataURL(file);
    fReader.onloadend = function(event) {
        var img = document.getElementById("imgBridge");
        img.src = event.target.result;
    }
};

function DeleteBridge(id) {
    if (confirm("Delete bridge " + id + " ?")) {
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

function AddComment() {
    window.location.href = "commentsdetaileditview";
};

function SaveComment(comment, from, emailAddress) {
    window.location.href = "/savecomment/" + comment + "/" + from +  "/" + emailAddress;
};
