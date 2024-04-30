using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMeses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] meses = {"JAN","FEV","MAR","ABRIL","MAIO","JUNHO","JULHO","AGOSTO","SET","OUT","NOV","DEZ",};

            Console.WriteLine("Digite um número de 1 a 12: ");

            int i = int.Parse(Console.ReadLine());

            Console.WriteLine("O mês selecionado foi: " + meses[i-1]);

            Console.ReadKey();

        }
    }
}
