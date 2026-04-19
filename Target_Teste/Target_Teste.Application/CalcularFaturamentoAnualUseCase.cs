using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Target_Teste.Domain.DTOs;
using Target_Teste.Domain.Models;

namespace Target_Teste.Application
{
    public class CalcularFaturamentoAnualUseCase
    {
        public FaturamentoResultado Execute(decimal[] valores)
        {
            var faturamento = new FaturamentoAnual(valores);
            return faturamento.CalcularResultado();
        }
    }
}
