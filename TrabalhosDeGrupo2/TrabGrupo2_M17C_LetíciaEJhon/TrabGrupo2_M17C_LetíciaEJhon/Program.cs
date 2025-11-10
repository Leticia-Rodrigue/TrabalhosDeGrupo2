using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace TrabGrupoM17C_LetíciaEJhon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];
            Console.WriteLine("Indice {1}. ", vetor);
            int maiornumero = 0;
            Console.WriteLine("Maximo{1}. ", maiornumero);
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("introduza o " + (i + 1) + "º numero");
                vetor[i] = int.Parse(Console.ReadLine());
            }



            for (int i = 1; i < vetor.Length; i++)
            {
                if (vetor[i] > vetor[maiornumero])
                {
                    maiornumero = i;
                }
            }
            Console.WriteLine("O maior numero é ++++++++++++" + vetor[maiornumero] + " e esta na posiçao " + maiornumero + 1 + "º de 1-10");
        }
    }
}
