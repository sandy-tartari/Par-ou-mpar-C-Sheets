using System;

namespace exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            // Faça um algoritmo que diga se o número é par digtado é par ou impar
            int n;
            Console.WriteLine ("Escreva um número qualquer: (e tecle ENTER)");
            n = int.Parse(Console.ReadLine());

            if ((n % 2) == 0){
                Console.WriteLine("É par");
            }
            else {
                Console.WriteLine("É impar");
            }
 
        }
    }
}
