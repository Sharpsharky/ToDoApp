function LoadContent() {
    $.ajax({
        url: loadContentUrl,
        type: 'GET',
        success: function (data) {
            $("#ContentID").html(data);
        },
        error: function (xhr, status, error) {
            console.error("Error: " + error);
        }
    });
}

function ClearContent() {
    $("#ContentID").html('');
}