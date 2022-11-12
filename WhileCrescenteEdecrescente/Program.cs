using System;

namespace curso
{
    class Progam
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 2 numeros, quando os números forem iguais o programa será fechado ");

            int x, y;

            string[] vet = Console.ReadLine().Split(' ');
            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);

            while (x != y)
            {
                if(x < y)
                {
                    Console.WriteLine("Crescente");
                }
                else
                {
                    Console.WriteLine("Decrescente");
                }
                vet = Console.ReadLine().Split(' ');
                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);

            }

        }
    }
}