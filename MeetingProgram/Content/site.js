$('a').on('click', function () {
    $('.wrap, a').toggleClass('active');

    return false;
});


$(function () {
    $("#addClass").click(function () {
        $('#qnimate').addClass('popup-box-on');
    });

    $("#removeClass").click(function () {
        $('#qnimate').removeClass('popup-box-on');
    });
})