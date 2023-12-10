﻿let alerta = document.querySelector('.alert');

() => {
    setTimeout(function () {
        alerta.style.transform = 'translateY(-10rem)';
    }, 3000)
}

let _alert = document.getElementById('alert');

setTimeout(function () {
    _alert.style.opacity = '0'
}, 3000)


$(document).ready(function () {
    const myTable = "#myTable"
    getTable(myTable)

    function getTable(id) {
        new DataTable(id, {
            lengthMenu: [
                [5, 10, 15, -1],
                [5, 10, 15, 'Todos']
            ],
            
            language: {
                lengthMenu: "Listar _MENU_ clientes",
                search: "Procurar ",
                processing: "Processando...",
                emptyTable: "Nenhum registro encontrado",
                paginate: {
                    first: "Primeira página",
                    previous: "Anterior",
                    next: "Próximo",
                    last: "Última página"
                }
            }
            

        });
    }


});

const customer = document.getElementById('Customers')
const analytics = document.getElementById('Analytics')
const home = document.getElementById('Home')
const keyBtn = document.getElementById('keyBtn')

const url = window.location.pathname

if (url.includes('Home')) {
    home.classList.add('bgImageLink')
}
if (url.includes('Analytics')) {
    analytics.classList.add('bgImageLink')
}
if (url.includes('Customer')) {
    customer.classList.add('bgImageLink')
}
if (url.includes('ChangePassword')) {
    keyBtn.classList.add('keyBtnColor')
}


const insertDataBtn = document.getElementById('insertDataBtn')
const insert = document.getElementById('insert')

insertDataBtn.addEventListener('click', function () {
    insert.style.display = "block";
})

