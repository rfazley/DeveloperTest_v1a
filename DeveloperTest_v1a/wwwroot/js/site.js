$(document).ready(function () {
    $('#myTable').DataTable({
        "scrollY": "450px",
        "scrollCollapse": true,
        "paging": true, 
        "lengthMenu": [20,40,60,80,100]
    });
});