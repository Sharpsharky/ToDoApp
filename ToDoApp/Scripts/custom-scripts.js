function LoadContent() {
    $.ajax({
        url: '/Home/ContentPartialView',
        type: 'GET',
        success: function (data) {
            $('#ContentID').html(data);
        },
        error: function () {
            alert('Error loading content.');
        }
    });
}

$(document).ready(function () {
    $('#loadContentButton').click(function () {
        LoadContent();
    });
});

function ClearContent() {
    $("#ContentID").html('');
}