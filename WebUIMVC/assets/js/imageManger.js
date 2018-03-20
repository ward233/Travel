var imgInsideWarp = $(".img-inside-warp");
imgInsideWarp.click(function () {
    var $checkbox = $(this).find("[type='checkbox']");
    $checkbox.each(function () {
        console.log($(this).prop('checked'));

        $(this).prop("checked", !$(this).prop('checked'));
    })

})

lazyload();