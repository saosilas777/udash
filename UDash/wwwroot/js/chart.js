const ctx1 = document.getElementById('myChart');
let backgroundColor = ""

const _data = document.getElementById('meetings').value.split(',')
const _data2 = document.getElementById('noShows').value.split(',')

/*for (let i = 0; i < 6; i++) {
    _data2[i] = _data[i]*30
        
}*/

new Chart(ctx1,{

    type: 'bar',
    data: {
        labels: ['Segunda', 'Terça', 'Quarta', 'Quinta', 'Sexta'],
        datasets: [{
            label: 'Reuniões mês',
            data: _data,
            borderWidth: 0,

            backgroundColor: color => {
                // console.log(color)
                let colors = []
                for (let i = 0; i < _data.length; i++) {
                    if (_data[i] < 5) {
                        colors[i] = "rgba(201, 73, 73)"
                    }
                    else {
                        colors[i] = "rgba(88, 196, 105,0.8)"
                    }
                }
                return colors
            },
            borderColor: color => {
                // console.log(color)
                let colors = []
                for (let i = 0; i < _data.length; i++) {
                    if (_data[i] < 5) {
                        colors[i] = "rgba(120, 222, 195)"
                    }
                    else {
                        colors[i] = "rgba(120, 222, 145,0.8)"
                    }
                }
                return colors
            },
        }]
    },

    options: {
        maintainAspectRatio: false,
        aspectRatio: 1,
        responsive: true,
        barPercentage: 0.5,
        categoryPercentage: 0.5,
        scales: {
            x: {
                grid: {
                    display: false,
                },
                ticks: {
                    display: true,
                    color: 'rgb(0,0,0)',
                    padding: 10,
                    font: {
                        size: 14,
                        weight: 300,
                        family: "Open-Sans",
                        style: 'normal',
                        lineHeight: 0,


                    },
                },

            },

        },
        plugins: {

            tooltip: {
                display: true,
                borderWidth: 0,
                backgroundColor: 'rgba(0, 0, 255, 0.6)',
                intersect: false
            },
            legend: {
                display: false
            }
        },
    },

});

const ctx2 = document.getElementById('myChart2');


new Chart(ctx2, {
    type: 'bar',
    data: {
        labels: ['Segunda', 'Terça', 'Quarta', 'Quinta', 'Sexta'],
        datasets: [{
            label: 'Reuniões mês',
            data: _data2,
            borderWidth: 0,

            backgroundColor: color => {
                // console.log(color)
                let colors = []
                for (let i = 0; i < _data2.length; i++) {
                    if (_data2[i] < 5) {
                        colors[i] = "rgba(201, 73, 73)"
                    }
                    else {
                        colors[i] = "rgba(88, 196, 105,0.8)"
                    }
                }
                return colors
            },
            borderColor: color => {
                // console.log(color)
                let colors = []
                for (let i = 0; i < _data2.length; i++) {
                    if (_data2[i] < 5) {
                        colors[i] = "rgba(120, 222, 195)"
                    }
                    else {
                        colors[i] = "rgba(120, 222, 145,0.8)"
                    }
                }
                return colors
            },
        }]
    },

    options: {
        maintainAspectRatio: false,
        aspectRatio: 1,
        responsive: true,
        barPercentage: 0.5,
        categoryPercentage: 0.5,
        scales: {
            x: {
                beginAtZero: true,
                grid: {
                    display: false,
                },
                ticks: {
                    display: true,
                    color: 'rgb(0,0,0)',
                    padding: 10,
                    font: {
                        size: 14,
                        weight: 300,
                        family: "Open-Sans",
                        style: 'normal',
                        lineHeight: 0,


                    },
                },

            },

        },
        plugins: {

            tooltip: {
                display: true,
                borderWidth: 0,
                backgroundColor: 'rgba(0, 0, 255, 0.6)',
                intersect: false
            },
            legend: {
                display: false
            }
        },
    },

});

