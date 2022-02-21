using System;

namespace Exercicio_soma_pares_consecutivos
{
    internal class Program
    {

        /*Você terá o desafio de escrever um programa que leia um valor inteiro N (1 < N < 1000). 
         * Este N é a quantidade de linhas de saída que serão apresentadas na execução do programa.
         */


        static void Main(string[] args)
        {

            int D = int.Parse(Console.ReadLine());

            while (D != 0)
            {
                // se for impar, some +1
                if (D % 2 != 0)
                {
                    D = D + 1;
                }
                int soma = D + D + 2 + D + 4 + D + 6 + D + 8;
                Console.WriteLine(soma);

                D = int.Parse(Console.ReadLine());
            }




        }
    }
}
