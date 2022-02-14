using System;

namespace Prova01.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variaveis
            Console.WriteLine("Digite o valor X :");
            int X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor Y:");
            int Y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor Z :");
            int Z = Convert.ToInt32(Console.ReadLine());
            string triangulo = Console.ReadLine();
            Console.WriteLine(triangulo);
            string opcao;


             for(int i = 0; i < triangulo.Length; i++)

            if (X + Y) > Z && (X + Z) > Y && (Y + Z) > X) {

                Console.WriteLine("Os três lados formam um triângulo:")
                    if (X == Y && X == Z)
                    Console.WriteLine("Equilatero:");

                else
                       if (X == Y || X == Z || Y == Z)
                    Console.WriteLine("Isosceles:");

                else
                    Console.WriteLine("Escaleno:");
            }

            Console.WriteLine("Triângulo Inválido");   
            Console.WriteLine("Os três lados não formam um Escaleno:");
            // não consegui arrumar os erros
        }
    }
}
