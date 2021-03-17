var currentImageIndex = 1;  // Skip 1st image initially as it's faded in on load
var imageIds = new Array();
var imageUrls = new Array();

$.fn.backgroundCycle = function () {

    var marginTop = this.css("margin-top");
    var marginRight = this.css("margin-right");
    var marginBottom = this.css("margin-bottom");
    var marginLeft = this.css("margin-left");

    if (!this.is("body")) {
        this.css({
            position: "relative"
        });
    }

    var contents = $(document.createElement("div"));
    var children = this.children().detach();
    contents.append(children);

    var dir = 'Images/Thumbs/';
    imageUrls = [
        dir + 'Image1.jpg',
        dir + 'Image2.jpg',
        dir + 'Image3.jpg',
        dir + 'Image4.jpg',
        dir + 'Image5.jpg',
        dir + 'Image6.jpg',
        dir + 'Image7.jpg',
        dir + 'Image8.jpg',
        dir + 'Image9.jpg',
        dir + 'Image10.jpg'
    ];
    
    for (var i = 0; i < imageUrls.length; i++) {
        var id = "bgImage" + i;
        var src = imageUrls[i];
        var cssClass = "cycle-bg-image";

        var image = $(document.createElement("div"));
        image.attr("id", id);
        image.attr("class", cssClass);

        image.css({
            "background-image": "url('" + src + "')",
            "background-repeat": "no-repeat",
            "background-position": "bottom",
            "background-size": "cover",
            "-moz-background-size": "cover",
            "-webkit-background-size": "cover",
            position: "fixed",
            left: marginLeft,
            top: marginTop,
            right: marginRight,
            bottom: marginBottom
        });

        this.append(image);

        imageIds.push(id);
    }

    $(".cycle-bg-image").hide();
    $("#" + imageIds[0]).fadeIn();

    contents.css({
        position: "absolute",
        left: marginLeft,
        top: marginTop,
        right: marginRight,
        bottom: marginBottom
    });

    this.append(contents);
};

function cycleToNextImage() {
    
    if (currentImageIndex === imageIds.length) {
        currentImageIndex = 0;
        $("#" + imageIds[imageIds.length - 1]).fadeOut(1000);
    }

    // We must fade out the last image, else it's opacity will remain at 1
    if (currentImageIndex > 0) {
        $("#" + imageIds[currentImageIndex - 1]).fadeOut(1000);
    }

    $("#" + imageIds[currentImageIndex]).fadeIn(1000);
   
    currentImageIndex++;
}
