function CarregarGastosTotais() {
    $.ajax({
        url: 'Despesas/GastosTotais',
        method: 'POST',
        success: function (dados) {
            new Chart(document.getElementById("GraticoGastosTotais"),{
                type: 'line',
                data: {
                    labels: PegarMeses(dados),
                    datasets: [{
                        label: "Totais gastos",
                        data: PegarValores(dados),
                        backgroundColor: "#ecf0f1",
                        borderColor: "#2980b9",
                        fill: false,
                        spanGaps: false
                    }]
                },
                options: {
                    title: {
                        display: true,
                        Text: "Total Gasto"
                    }
                }
            });
        }
    });
}