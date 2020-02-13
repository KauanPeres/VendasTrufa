using System;

namespace VendasTrufa
{
    class Program
    {
        static void Main(string[] args)
        {
            VendasTrufa v = new VendasTrufa();

            double userValorUnitario = 0;
            int userQuantidade = 0;
            double userValorTotal = 0;
            int userQtde = 0;

            Console.Write("Informe  o valor unitário das trufas:");
            userValorUnitario = double.Parse(Console.ReadLine());

            Console.Write("Informe a quantidade de trufas compradas:");
            userQuantidade = int.Parse(Console.ReadLine());

            v.valorUnitario = userValorUnitario;
            v.quantidade = userQuantidade;

            userValorTotal = v.calcularValorTotal();
            userQtde = v.calcularQtdAjustada();

            Console.Write("O valor total da compra foi de: ");
            Console.WriteLine(userValorTotal);

            Console.Write("A quantidade de trufas adicionada na compra é de: ");
            Console.Write(userQtde);

            Console.ReadKey();
        }

        public class VendasTrufa
        {
            public double valorUnitario = 0;
            public int quantidade = 0;

            public double calcularValorTotal()
            {
                double valorTotal = 0;

                valorTotal = valorUnitario * quantidade;

                return valorTotal;
            }

            public int calcularQtdAjustada()
            {
                int qtdeTotalAjustado = 0;

                if (quantidade > 10)
                {
                    qtdeTotalAjustado = quantidade + 1;
                }
                else
                {
                    qtdeTotalAjustado = quantidade;
                }

                return qtdeTotalAjustado;
            }
        }

    }
}
