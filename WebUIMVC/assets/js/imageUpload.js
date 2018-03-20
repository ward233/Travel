$(function () {
    var fileUpload = $("#body_FileUpload1");
    var btn = $("#chose-button");
    btn.click(function () {
        fileUpload.trigger("click");
    })
    //        var filesBinArr = [];
    fileUpload.change(function (e) {

        $(".show-img-warp").empty();
        var files = e.target.files;

        var fileCount = files.length;



        for (var i = 0; i < fileCount; i++) {
            var showImgReader = new FileReader();


            showImgReader.readAsDataURL(files[i]);
            (function (file) {
                showImgReader.onload = function () {

                    var name = file.name;


                    if (name.length > 10) {
                        name = name.slice(0, 17);
                        name = name + "...";
                    }
                    var body = $(".show-img-warp");
                    body.append("<div class='img-inner-warp'><img class='img-inner-warp-img' src='" + this.result + "' /><span title='" + file.name + "'>" + name + "</span></div>");

                };
            })(files[i]);




        }
    })
})