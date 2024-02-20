const colorsArray = ["#FC4646", "#8FDEE9"]


function renderDonutChart(elemID, passRate, remainder) {
    var options = {
        chart: {
            type: 'donut',
            height: "100%",
            fontFamily: "Poppins"
        },
        series: [passRate, remainder],
        labels:["pass rate", ""],
        plotOptions: {
            pie: {
                donut: {
                    
                    labels: {
                        show: false,
                        formatter: function (w) {
                            return "75"
                        },
                       
                      
                       
                        
                    },
                  
                    
                   
                    
                }
            }
        },
        colors: ["#FC4646", "#8FDEE9"],
       
        dataLabels: {
            enabled: false,
            
        },
        legend: {
            show: false
        }
    }
    
    window.chart = new ApexCharts(document.querySelector(`#${elemID}`), options);
    chart.render();
}

function updateChart(passRate, remainder) {
    if (window.chart) {
        window.chart.updateSeries([passRate, remainder]);
    }
}