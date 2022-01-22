using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Respostas
{
    class ValorVenda
    {
        public double ValorVeiculo { get; set; }
        public int AnoVeiculo { get; set; }
        public double ValorTotalDesconto { get; set; }

        public ValorVenda(double valorVeiculo, double valorTotalDesconto)
        {
            ValorVeiculo = valorVeiculo;
            ValorTotalDesconto = valorTotalDesconto;
        }

        public override string ToString()
        {
            return
                "Valor do desconto: "
                + ValorTotalDesconto.ToString("F2", CultureInfo.InvariantCulture)
                + "  "
                + "Valor total: "
                + ValorVeiculo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
