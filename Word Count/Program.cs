using System;
using System.Linq;

namespace Word_Count
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite uma frase: ");
            var phrase = Console.ReadLine();
            
            if (string.IsNullOrEmpty(phrase))
            {
                Console.WriteLine("Frase inválida");
                return;
            }
            
            var lettersCount = phrase.Split(' ').Sum(word => word.Length);
            
            Console.WriteLine($"Número de letras: {lettersCount}");
        }
    }
}