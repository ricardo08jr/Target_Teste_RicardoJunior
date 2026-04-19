using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Target_Teste.Domain.DTOs;

namespace Target_Teste.Domain.Models
{
    public class FaturamentoAnual
    {
        public decimal[] Valores { get; }

        public FaturamentoAnual(decimal[] valores)
        {
            if (valores is null)
            {
                throw new ArgumentNullException(nameof(valores));
            }
               

            if (valores.Length == 0)
            {
                throw new ArgumentException("O vetor de faturamento não pode ser vazio.", nameof(valores));
            }
               

            this.Valores = valores;
        }
    }
}
