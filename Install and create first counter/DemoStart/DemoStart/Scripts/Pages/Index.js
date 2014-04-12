
(function () {
    var onButtonClick = function () {
        var nbrClicks = $('#counter').val();
        nbrClicks++;
        $('#counter').val(nbrClicks);
    }

    $(function () {
        $('#aButton').click(onButtonClick);
    })
})()


