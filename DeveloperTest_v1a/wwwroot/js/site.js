$(document).ready(function () {

	$('#myTable').dataTable({
		"lengthMenu":
					[
						[20, 40, 60, 80, -1],
						[20, 40, 60, 80, 'All']
					],
		"pageLength": 20
	});


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