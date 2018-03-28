/// <reference path="../Js/jquery-3.2.1.min.js" />
var index = 0;//初始化一个下标

function Tu() {
    index++;
    if (index > 4) {
        $(".body_background2 li").siblings(".active").removeClass("active");
        $(".body_background2 li:first").addClass("active");
        index = 0;
        $(".pic li").eq(index).fadeIn().siblings().fadeOut();//淡入淡出
        return;
    }

    $(".body_background2 li").siblings(".active").removeClass("active").next().addClass("active");

    $(".pic li").eq(index).fadeIn().siblings().fadeOut();//淡入淡出
}
setInterval(Tu, 5000)
$(".body_background2 li").click(function () {
    index = $(this).index();//获取下标
    $(this).addClass("active").siblings().removeClass("active");
    $(".pic li").eq(index).fadeIn().siblings().fadeOut();//淡入淡出
});