let alerta = document.querySelector('.alert');

() => {
    setTimeout(function () {
        alerta.style.transform = 'translateY(-10rem)';
    }, 3000)
}


$(document).ready(function () {
    getDataTable("#myTable");
    /*urlActual()*/

});

const customer = document.getElementById('Customers')
const analytics = document.getElementById('Analytics')
const home = document.getElementById('Home')

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



/*function urlActual() {
    let url = window.location.pathname
    switch (url) { 
        case '/Home/Index':
            home.style.backgroundImage = 'linear-gradient(195deg,#ec407a,#d81b60)'
            break
        case '/Customer/Index':
            customer.style.backgroundImage = 'linear-gradient(195deg,#ec407a,#d81b60)'
            break
         


    }





}*/



function getDataTable(id) {

    $(id).DataTable({
        "ordering": true,
        "paging": true,
        "searching": true,
        "oLanguage": {
            "sEmptyTable": "Nenhum registro encontrado na tabela",
            "sInfo": "Mostrar _START_ até _END_ de _TOTAL_ registros",
            "sInfoEmpty": "Mostrar 0 até 0 de 0 Registros",
            "sInfoFiltered": "(Filtrar de _MAX_ total registros)",
            "sInfoPostFix": "",
            "sInfoThousands": ".",
            "sLengthMenu": "Mostrar _MENU_ registros por pagina",
            "sLoadingRecords": "Carregando...",
            "sProcessing": "Processando...",
            "sZeroRecords": "Nenhum registro encontrado",
            "sSearch": "Pesquisar",
            "oPaginate": {
                "sNext": "Proximo",
                "sPrevious": "Anterior",
                "sFirst": "Primeiro",
                "sLast": "Ultimo"
            },
            "oAria": {
                "sSortAscending": ": Ordenar colunas de forma ascendente",
                "sSortDescending": ": Ordenar colunas de forma descendente"
            }
        }
    });
}
