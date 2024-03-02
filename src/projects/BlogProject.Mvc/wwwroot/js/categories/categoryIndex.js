$(document).ready(function () {
    ///DataTable'ın dilini ayarlıyoruz.
    const dataTable = $('#categoryTable').DataTable({   // dataTable ın dil özelliğini değiştirme
        "language": {
            "url": "//cdn.datatables.net/plug-ins/1.10.22/i18n/Turkish.json"
        }
    });

    //Ajax ile GET işlemi yapıcaz ve modalı doldurcaz
    $(function () {
        const url = "/Categories/Categories/Update/" //tetiklenecek action yolu atanıyor.
        const placeHolderDiv = $('#modalPlaceHolder');   //etkilenecek olan div'in id'si atanıyor.
        $(document).on('click',
            '.btn-update',
            function (event) { //'btn-update' özelliğine sahip butona tıklandığında..
                event.preventDefault(); //mevcut bütün özellikleri sıfırla.
                const id = $(this).attr('data-id'); //ilgili div in id değerini alma.
                console.log(id);
                //Ajax da jquery istek atma şekli
                $.get(url, { categoryId: id })
                    .done(function (data) { // istek başarılı olduğunda yapılacak işlemler.
                        placeHolderDiv.html(data); //belirttiğim divin içerisine elimdeki veriyi bastım.
                        placeHolderDiv.find('.modal').modal('show'); //basıldıktan sonra div'i görünür yapıyoruz.

                    }).fail(function () { //istekte hata olursa çalışacak kısım.Done'a alternatif durumdur.
                        toastr.error("Bir hata meydana geldi!");
                    });
            });

    });


    //Ajax ile PUT işlemi yapacağız modal içerisinde doldurduklarımızı veri tabanına göndereceğiz.

    const placeHolderDiv = $('#modalPlaceHolder');

    placeHolderDiv.on('click',
        '#btnUpdate',
        function (event) {
            event.preventDefault(); //buton özelliklerini default a çekiyoruz.
            const form = $('#form-category-update');    //form'u alıyoruz.
            const actionUrl = form.attr('action');  //İstek atacağımız yerin yolunu alıyoruz.   --- ?? burada yoldan dolayı hata olabilir!!
            const dataToSend = form.serialize();    //gönderilecek data alınıyor. Serialize işlemi yapılıyor.

            //Çalıştırılacak action url.
            $.post(actionUrl, dataToSend).done(function (data) {
                const categoryUpdateAjaxModel = jQuery.parseJSON(data); //gelen veriyi json'a parse ettik.
                console.log(categoryUpdateAjaxModel);
                const newFormBody = $('.modal-body', categoryUpdateAjaxModel.CategoryUpdatePartial);    //Modal'ın body-si  'categoryUpdateAjaxModel.CategoryUpdatePartial' den string olarak gelen hali olacak.
                placeHolderDiv.find('.modal-body').replaceWith(newFormBody);
                const isValid = newFormBody.find('[name="IsValif"]').val() === 'True';
                if (isValid) {
                    const id = categoryUpdateAjaxModel.CategoryGetDto.Id;
                    const tableRow = $('[name= "${id}"]');
                    placeHolderDiv.find('.modal').modal('hide');
                    dataTable.row(dataTable).data([
                        categoryUpdateAjaxModel.CategoryGetDto.Id,
                        categoryUpdateAjaxModel.CategoryGetDto.Name,
                        '<button tooltip="Güncelleme" data-id="${Id}" class="btn btn-warning btn-sm btn-update"><i  class="fas fa-edit"></i></button>'
                    ]);
                    tableRow.attr("name", `${id}`);
                    dataTable.row(tableRow).invalid();
                    toastr.success("Kategori Güncellendi", "Başarılı İşlem!");
                } else {
                    let summaryText = "";
                    $("#validation-summary > ul > li").each(function() {
                        let text = $(this).text();
                        summaryText = `*${text}\n`;
                    });
                    toastr.warning(summaryText);
                }
            }).fail(function (response) {
                console.log(response.data);
                console.log(response);
                toastr.error("Bir hata meydana geldi! -- "+ response);
            });
        });
});