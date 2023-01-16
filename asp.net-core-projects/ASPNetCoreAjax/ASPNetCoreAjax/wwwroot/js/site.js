// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function showModalDialog(url,title) {
    $.ajax(
        {
            type: "GET",
            url: url,
            success: function (res) {
                $("#form-modal .modal-title").html(title);
                $("#form-modal .modal-body").html(res.html);
                $("#form-modal").modal("show");
            }
        });
    return false;
}

function submitForm(form) {
    try {
        var options = {
            type: "POST",
            url: form.action,
            data: new FormData(form),
            processData: false,
            contentType: false,
            success: function (res) {
                if (res.isValid) {
                    $("#form-modal").modal("hide");
                    $(".page-content").html(res.html);
                    $.notify("Information is updated", "success");
                }
                else {
                    $("#form-modal .modal-body").html(res.html);
                    $.notify("There is a problem in saving the data", "warn");
                }
            },
            error: function (xhr, status, error) {
                $.notify("There is an error. " + error, "error");
            }
        };
        $.ajax(options);

    } catch (ex) {
        $.notify("There is an error. " + ex.message, "error");
    }
    return false;
}
