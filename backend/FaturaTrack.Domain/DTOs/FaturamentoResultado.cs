using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaturaTrack.Domain.DTOs;

public record FaturamentoResultado(
    decimal MenorFaturamento,
    decimal MaiorFaturamento,
    int DiasAcimaDaMedia
);
