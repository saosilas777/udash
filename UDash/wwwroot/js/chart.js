const ctx = document.getElementById('myChart');
let backgroundColor = ""

const _data = [];
const _data2 = [];

for (let i = 0; i < 6; i++) {
    _data2[i] = parseInt(Math.random() * 30)
    _data[i] = parseInt(Math.random() * 30)
}

new Chart(ctx, {

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
                    if (_data[i] < 10) {
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
                    if (_data[i] < 10) {
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

// const ctx3 = document.getElementById('myChart3').getContext('2d');
// new Chart(ctx3, {
//   type: "bar",
//   data: {
//     labels: ["M", "T", "W"],
//     datasets: [{
//       label: "Sales",
//       tension: 0.4,
//       borderWidth: 0,
//       borderRadius: 4,
//       borderSkipped: false,
//       backgroundColor: "rgba(255, 255, 255, .8)",
//       data: [50, 20, 10],
//       maxBarThickness: 6
//     }, ],
//   },
//   options: {
//     responsive: true,
//     maintainAspectRatio: true,
//     plugins: {
//       legend: {
//         display: false,
//       }
//     },
//     interaction: {
//       intersect: false,
//       mode: 'index',
//     },
//     scales: {
//       y: {
//         grid: {
//           drawBorder: false,
//           display: true,
//           drawOnChartArea: true,
//           drawTicks: false,
//           borderDash: [5, 5],
//           color: 'rgba(255, 255, 255)'
//         },
//         ticks: {
//           suggestedMin: 0,
//           suggestedMax: 500,
//           beginAtZero: true,
//           padding: 10,
//           font: {
//             size: 14,
//             weight: 300,
//             family: "Roboto",
//             style: 'normal',
//             lineHeight: 2
//           },
//           color: "#fff"
//         },
//       },
//       x: {
//         grid: {
//           drawBorder: false,
//           display: true,
//           drawOnChartArea: true,
//           drawTicks: false,
//           borderDash: [5, 5],
//           color: 'rgba(255, 255, 255, .8)'
//         },
//         ticks: {
//           display: true,
//           color: '#000',
//           padding: 10,
//           font: {
//             size: 14,
//             weight: 300,
//             family: "Roboto",
//             style: 'normal',
//             lineHeight: 2
//           },
//         }
//       },
//     },
//   },
// });

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
                for (let i = 0; i < _data.length; i++) {
                    if (_data[i] < 10) {
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
                    if (_data[i] < 10) {
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

// const ctx3 = document.getElementById('myChart3');

// new Chart(ctx3, {
//   type: 'bar',
//   data: {
//     labels: ['Segunda', 'Terça', 'Quarta', 'Quinta', 'Sexta'],
//     datasets: [{
//         label: 'MRR Mês',
//       data: [10, 9, 23, 55, 43],
//       borderWidth: 0
//     }]
//   },
//   options: {
//     scales: {
//       y: {
//         beginAtZero: true
//       }
//     }
//   }
// });
