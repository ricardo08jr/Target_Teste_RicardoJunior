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
        public FaturamentoResult CalcularResultado()
        {
            decimal menor = decimal.MaxValue;
            decimal maior = decimal.MinValue;
            decimal soma = 0m;
            int diasComFaturamento = 0;

            foreach (var valor in Valores)
            {
                if (valor > 0)
                {
                    if (valor < menor) menor = valor;
                    if (valor > maior) maior = valor;

                    soma += valor;
                    diasComFaturamento++;
                }
            }

            if (diasComFaturamento == 0)
                return new FaturamentoResult(0m, 0m, 0);

            var media = soma / diasComFaturamento;
            int diasAcimaDaMedia = 0;

            foreach (var valor in Valores)
            {
                if (valor > 0 && valor > media)
                    diasAcimaDaMedia++;
            }

            return new FaturamentoResult(menor, maior, diasAcimaDaMedia);
        }
    }
}
