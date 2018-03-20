function refresh() {
    var url = "ValidateImg.ashx?id=";
    var r = Math.random() * 1000;
    url = url + r; document.getElementById("ValidateCodeImage").src = url;

    return false;
}