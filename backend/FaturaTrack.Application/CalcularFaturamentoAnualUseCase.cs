using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FaturaTrack.Domain.DTOs;
using FaturaTrack.Domain.Models;

namespace FaturaTrack.Application
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
