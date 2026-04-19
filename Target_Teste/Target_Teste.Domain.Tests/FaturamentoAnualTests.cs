using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Target_Teste.Domain.Models;

namespace Target_Teste.Domain.Tests
{
    public class FaturamentoAnualTests
    {
        [Fact]
        public void DeveCalcularCorretamenteCasoNormal()
        {
            decimal[] dados = { 0m, 100m, 200m, 300m, 0m };

            var faturamento = new FaturamentoAnual(dados);
            var resultado = faturamento.CalcularResultado();

            Assert.Equal(100m, resultado.MenorFaturamento);
            Assert.Equal(300m, resultado.MaiorFaturamento);
            Assert.Equal(1, resultado.DiasAcimaDaMedia);
        }
        [Fact]
        public void NaoDeveContarValoresAbaixoDaMedia()
        {
            decimal[] dados = { 0m, 100m, 200m, 300m, 0m };

            var faturamento = new FaturamentoAnual(dados);
            var resultado = faturamento.CalcularResultado();

            Assert.NotEqual(3, resultado.DiasAcimaDaMedia);
        }


    }
}
