using System;

namespace Full_Name_Greetings
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Olá! Qual é o seu primeiro nome? ");
            var firstName = Console.ReadLine();
            Console.Write("E o seu sobrenome? ");
            var lastName = Console.ReadLine();
            
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                Console.WriteLine("Você não digitou seu nome completo!");
                Program.Main(args);
                return;
            }
            
            Console.WriteLine($"Olá, {firstName} {lastName}! Seja muito bem-vindo(a)!");
        }
    }
}