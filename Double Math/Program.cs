using System;

namespace Double_Math
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite um número de ponto flutuante: ");
            var num1 = double.Parse(Console.ReadLine() ?? "0");
            Console.Write("Digite outro número de ponto flutuante: ");
            var num2 = double.Parse(Console.ReadLine() ?? "0");
            Console.Write('\n');
            
            Console.WriteLine($"Soma: {num1 + num2}");
            Console.WriteLine($"Subtração: {num1 - num2}");
            Console.WriteLine($"Multiplicação: {num1 * num2}");
            
            if (num2 == 0)
            {
                Console.WriteLine("Divisão: Não é possível dividir por zero");
            }
            else
            {
                Console.WriteLine($"Divisão: {num1 / num2}");
            }
            
            Console.WriteLine($"Média: {(num1 + num2) / 2}");
        }
    }
}