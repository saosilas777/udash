﻿const ctx1 = document.getElementById('myChart');
let backgroundColor = ""

const _data = document.getElementById('meetings').value.split(',')
const _data2 = document.getElementById('noShows').value.split(',')

/*for (let i = 0; i < 6; i++) {
    _data2[i] = _data[i]*30
        
}*/

new Chart(ctx1, {

    type: 'bar',
    data: {
        labels: ['Segunda', 'Terça', 'Quarta', 'Quinta', 'Sexta', 'Total'],
        datasets: [{
            label: 'Reuniões mês',
            data: _data,
            borderWidth: 0,

            backgroundColor: color => {
                // console.log(color)
                let colors = []
                for (let i = 0; i < _data.length; i++) {
                    if (_data[i] > 10) {

                        colors[i] = "rgba(227, 52, 102,1)"
                    }
                    else {
                        colors[i] = "rgba(181, 181, 181)"
                    }
                }
                return colors
            },
            borderColor: color => {
                // console.log(color)
                let colors = []
                for (let i = 0; i < _data.length; i++) {
                    if (_data[i] > 10) {

                        colors[i] = "rgba(227, 52, 102,1)"
                    }
                    else {
                        colors[i] = "rgba(232, 116, 155)"
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
                    color: 'rgb(0, 0, 0)',
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
        labels: ['Segunda', 'Terça', 'Quarta', 'Quinta', 'Sexta', 'Total'],
        datasets: [{
            label: 'Reuniões mês',
            data: _data2,
            borderWidth: 0,

            backgroundColor: color => {
                // console.log(color)
                let colors = []
                for (let i = 0; i < _data.length; i++) {
                    if (_data[i] > 10) {

                        colors[i] = "rgba(227, 52, 102,1)"
                    }
                    else {
                        colors[i] = "rgba(181, 181, 181)"
                    }
                }
                return colors
            },
            borderColor: color => {
                // console.log(color)
                let colors = []
                for (let i = 0; i < _data.length; i++) {
                    if (_data[i] > 10) {

                        colors[i] = "rgba(227, 52, 102,1)"
                    }
                    else {
                        colors[i] = "rgba(232, 116, 155)"
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
                    color: 'rgb(0, 0, 0)',
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

const ctx3 = document.getElementById('myChart3');
new Chart(ctx3, {
    type: "bar",
    data: {
        labels: ['jan', 'fev', 'mar', 'abr', 'maio', 'jun', 'jul', 'ago', 'set', 'out', 'nov', 'dez'],
        datasets: [{
            label: "Sales",
            borderWidth: 0,
            data: [5, 7, 15, 8, 9, 10, 16, 15, 18, 5, 8, 19],
            backgroundColor: color => {
                // console.log(color)
                let colors = []
                for (let i = 0; i < _data.length; i++) {
                    if (_data[i] > 10) {

                        colors[i] = "rgba(227, 52, 102,1)"
                    }
                    else {
                        colors[i] = "rgba(181, 181, 181)"
                    }
                }
                return colors
            },
            borderColor: color => {
                // console.log(color)
                let colors = []
                for (let i = 0; i < _data.length; i++) {
                    if (_data[i] > 10) {

                        colors[i] = "rgba(227, 52, 102,1)"
                    }
                    else {
                        colors[i] = "rgba(232, 116, 155)"
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
                    color: 'rgb(0, 0, 0)',
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

const ctx4 = document.getElementById('myChart4');
new Chart(ctx4, {
    type: "bar",
    data: {
        labels: ['jan', 'fev', 'mar', 'abr', 'maio', 'jun', 'jul', 'ago', 'set', 'out', 'nov', 'dez'],
        datasets: [{
            label: "Sales",
            borderWidth: 0,
            data: [5, 7, 15, 8, 9, 10, 16, 15, 18, 5, 8, 19],
            backgroundColor: color => {
                // console.log(color)
                let colors = []
                for (let i = 0; i < _data.length; i++) {
                    if (_data[i] > 10) {

                        colors[i] = "rgba(227, 52, 102,1)"
                    }
                    else {
                        colors[i] = "rgba(181, 181, 181)"
                    }
                }
                return colors
            },
            borderColor: color => {
                // console.log(color)
                let colors = []
                for (let i = 0; i < _data.length; i++) {
                    if (_data[i] > 10) {

                        colors[i] = "rgba(227, 52, 102,1)"
                    }
                    else {
                        colors[i] = "rgba(232, 116, 155)"
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
                    color: 'rgb(0, 0, 0)',
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