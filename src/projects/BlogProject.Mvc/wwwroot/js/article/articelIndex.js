$(document).ready(function () {
    const dataTable = $('#makaleTable').DataTable({
        "langague": {
            "url": "//cdn.datatable.net/plug-ins/1.10.20/i18n/Turkish.json"
        }
    });

    $(document).on("click", ".btn-delete", function (event) {
        event.preventDefault();
        const id = $(this).attr("data-id");
        const tableRow = $(`[name="#{id}"]`);
        const articelName = tableRow.find("td:eq(1)").text();
        Swal.fire({
            title: "Silmek istediğinize emin misiniz?",
            text: `${articelName} adli makale silinecektir!`,
            icon: "warning",
            showCancelButton: true,
            confirmButtonColor: "#3085d6",
            cancelButtonColor: "#d33",
            confirmButtonText: "Evet, silmek istiyorum.",
            canselButtonText: "Hayır, silmek istemiyorum.",
        }).then((result) => {
            if (result.isConfirmed) {
                $.ajax({
                    type: "DELETE",
                    dataType: "json",
                    data: { articelId: id },
                    url: "/Article/Delete/",
                    success: function (data) {
                        if (data.isSuccess) {
                            Swal.fire(
                                'Silindi',
                                `${data.data.title} adlı makale silindi.`,
                                'success'
                            )
                        } else {
                            Swal.fire({
                                icon: "error",
                                title: "Başarısız!",
                                text: "Makale silinemedi."
                            })
                        },
                        dataTable.row(tableRow).remove().draw();
                    },
                    error: function (err) {
                        console.log(err);
                        toastr.error(`$err.responseText`, "Hata!");
                    }
                });
            }
        });
    });
});