(function () {
    'use strict'
    const inputs = document.querySelectorAll('.editable')
    const btnEdit = document.querySelector('#card_cta-edit')
    const btnSubmitEdit = document.querySelector('#btnSubmitEdit')
    const btnSubmitDelete = document.querySelector('#btnSubmitDelete')
    const btnSave = document.getElementById('card_cta-saveChanges')
    const btndelete = document.getElementById('card_cta-delet')
    const btnconfirmDelete = document.getElementById('confirmDelete')
    const btncancelDelete = document.getElementById('cancelDelete')
    const deleteAlert = document.getElementById('deleteAlert')


    btncancelDelete.addEventListener('click', cancelDelete)
    btndelete.addEventListener('click', confirmDelete);
    btnEdit.addEventListener('click', disable)

    btnSave.addEventListener('click', SubmitEdit)
    btnconfirmDelete.addEventListener('click', SubmitDelete)


    function SubmitEdit () {
        btnSubmitEdit.click();
    }
    function SubmitDelete() {
        btnSubmitDelete.click();
    }

    function disable() {

        document.getElementById('select_disabled').disabled = false
        document.getElementById('select_disabled').focus()
        inputs.forEach(function (item) {
            item.removeAttribute('readonly')
            item.style.color = '#f74d50'
        })
        btnSave.style.display = 'flex'
        btndelete.style.display = 'none'



    }
    function confirmDelete() {
        deleteAlert.style.display = 'block'
        btndelete.style.display = 'none'
        btnEdit.style.display = 'none'
        btnconfirmDelete.style.display = 'flex'
        btncancelDelete.style.display = 'flex'
    }
    function cancelDelete() {
        deleteAlert.style.display = 'none'
        btndelete.style.display = 'flex'
        btnEdit.style.display = 'flex'
        btnconfirmDelete.style.display = 'none'
        btncancelDelete.style.display = 'none'
    }
})()