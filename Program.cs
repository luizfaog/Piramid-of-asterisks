using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace piramideAsterisco
{
    class Program
    {
        static void Main(string[] args)
        {
            int linhas;

            Console.WriteLine("Informe a qntd de linhas presentes na sua piramide: ");
            linhas = int.Parse(Console.ReadLine());
            for (int linhaAtual = 1; linhaAtual <= linhas; linhaAtual++)
            {
                for (int j = 0; j < linhas - linhaAtual; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < (linhaAtual * 2) - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
