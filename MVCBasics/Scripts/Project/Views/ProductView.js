

$(document).ready(function () {
    //    var exists = $('#productsTable').length;
    //    console.log('items=' + exists);

    $('#productsTable').dataTable({
        "aaSorting": [[1, "desc"],[0,"asc"]]
    });

});
