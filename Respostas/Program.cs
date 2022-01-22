using System;
using System.Collections.Generic;
using System.Globalization;

namespace Respostas
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice;
            double valorTotalDesconto;
            double sumTotal = 0.00;
            double sumAno = 0.00;
            List<ValorVenda> listDesconto = new List<ValorVenda>();
            List<double> listTotalAno = new List<double>();

            do
            {
                Console.WriteLine("informe o valor do veiculo");
                double valorVeiculo = double.Parse(Console.ReadLine());
                Console.WriteLine("informe o ano do veiculo");
                int anoVeiculo = int.Parse(Console.ReadLine());

                if (anoVeiculo <= 2000)
                { 
                    valorTotalDesconto = valorVeiculo * 0.12;
                    listTotalAno.Add(anoVeiculo);
                }
                else
                    valorTotalDesconto = valorVeiculo * 0.07;

                valorVeiculo -= valorTotalDesconto;

                listDesconto.Add(new ValorVenda(valorVeiculo, valorTotalDesconto));

                foreach (var item in listDesconto)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine("Deseja continuar calculando os Descontos? S/N");
                choice = Console.ReadLine().ToUpper();

            } while (choice != "N");

            sumTotal = listDesconto.Count;
            sumAno = listTotalAno.Count;

            Console.WriteLine("Soma total de Veiculos até 2000: " + sumAno.ToString());
            Console.WriteLine("Soma total de Veiculos: " + sumTotal.ToString());
        }



    }

}

    class Veiculo
    {

}
