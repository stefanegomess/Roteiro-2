using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa que receba dois números, calcule e
            //mostre a subtração do primeiro número pelo segundo.

            float A, B, subtracao;

            Console.WriteLine("Digite 2 números: ");

            A = float.Parse(Console.ReadLine());
            B = float.Parse(Console.ReadLine());

            subtracao = A - B;

            Console.WriteLine("A subtração do primeiro número pelo segundo é: " +subtracao);
        }
    }
}
