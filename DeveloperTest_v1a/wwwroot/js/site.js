$(document).ready(function () {
	// Setup - add a text input to each footer cell
	$('#myTable tfoot th').each(function () {

		var column = this;
		var title = $('#myTable thead th').eq($(this).index()).text();
		$(this).html('<input type="text" placeholder="Search ' + title + '" />');
	});

	// DataTable
	var table = $('#myTable').DataTable();

	// Apply the filter
	$("#myTable tfoot input").on('keyup change', function () {
		table
			.column($(this).parent().index() + ':visible')
			.search(this.value)
			.draw();
	});
});