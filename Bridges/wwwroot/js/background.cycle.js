var currentImageIndex = 0;
var imageIds = new Array();
var imageUrls = new Array();
var fadeSpeed;

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

  imageUrls = ["Images/bkgrd.jpg", "Images/bkgrd2.jpg"];
    imageUrls = [
        "Images/Thumbs/Image1.jpg",
        "Images/Thumbs/Image2.jpg",
        "Images/Thumbs/Image3.jpg",
        "Images/Thumbs/Image4.jpg",
        "Images/Thumbs/Image5.jpg",
        "Images/Thumbs/Image6.jpg",
        "Images/Thumbs/Image7.jpg",
        "Images/Thumbs/Image8.jpg",
        "Images/Thumbs/Image9.jpg",
        "Images/Thumbs/Image10.jpg"
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

      $(".cycle-bg-image").hide();
      $("#" + imageIds[0]).fadeIn();
  }

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

    if (currentImageIndex > 0) {
        $("#" + imageIds[currentImageIndex - 1]).fadeOut(1000);
    }

    $("#" + imageIds[currentImageIndex]).fadeIn(1000);
   
    currentImageIndex++;
}
