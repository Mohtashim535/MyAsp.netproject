﻿var dataTable;

$(document).ready(function () {
    dataTable = loadDataTable();
});

function loadDataTable() {
    return $('#tblData').DataTable({
        "ajax": {
            "url": "/admin/product/getall",
            "type": "GET",
            "datatype": "json",
        },
        "columns": [
            { "data": "title", "width": "25%" },
            { "data": "isbn", "width": "15%" },
            { "data": "listPrice", "width": "10%" },
            { "data": "author", "width": "20%" },
            { "data": "category.name", "width": "15%" },
            {
                "data": "id",
                "render": function (data) {
                    return `
                        <div class="w-100 btn-group" role="group">
                            <a href="/admin/product/upsert?id=${data}" class="btn btn-primary mx-2">
                                Edit
                            </a>
                            <a href="javascript:void(0);" onclick="Delete('/admin/product/delete?id=${data}')" class="btn btn-danger mx-2">
                                Delete
                            </a>
                        </div>`;
                },
                "width": "25%"
            }
        ]
    });
}


function Delete(url) {
    Swal.fire({
        title: "Are you sure?",
        text: "You won't be able to revert this!",
        icon: "warning",
        showCancelButton: true,
        confirmButtonColor: "#3085d6",
        cancelButtonColor: "#d33",
        confirmButtonText: "Yes, delete it!"
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: url,
                type: 'DELETE',
                success: function (data) {
                    // Reload the DataTable
                    dataTable.ajax.reload(null, false);  // false to keep the current pagination
                    toastr.success(data.message);
                },
                error: function (xhr, status, error) {
                    toastr.error("Something went wrong.");
                }
            });
        }
    });
}