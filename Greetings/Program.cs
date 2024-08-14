using System;

namespace Greetings
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Olá! Qual é o seu nome? ");
            var name = Console.ReadLine();
            
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Você não digitou seu nome!");
                Program.Main(args);
                return;
            }
            
            Console.WriteLine($"Olá, {name}! Seja muito bem-vindo(a)!");
        }
    }
}