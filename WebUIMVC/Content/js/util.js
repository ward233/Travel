function refresh() {
    var img = document.getElementById("ValidateCodeImage");
    if (img == null) {
        console.log("验证码图片标签不存在");
        return false;
    }
    var url = img.src.split("?")[0];
    url += "?time=";
    url += Math.random() * 1000;
    img.src = url;

    return false;
}
