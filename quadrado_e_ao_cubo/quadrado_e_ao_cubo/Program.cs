using System;

namespace quadrado_e_ao_cubo
{
    internal class Program
    {

        /*Você terá o desafio de escrever um programa que leia um valor inteiro N (1 < N < 1000).
         * Este N é a quantidade de linhas de saída que serão apresentadas na execução do programa.
         */


        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            if (N > 1 && N < 1000)
            {
                for (int x = 1; x <= N; x++)
                {
                    Console.WriteLine("{0} {1} {2}", x, x * x, x * x * x);
                }

            }

        }
    }
}
