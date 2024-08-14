using System;

namespace Clock
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1 - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos).");
            Console.WriteLine("2 - Apenas a data no formato \"01/03/2024\".");
            Console.WriteLine("3 - Apenas a hora no formato 24 horas.");
            Console.WriteLine("4 - A data com o mês por extenso.");
            Console.Write("Sua escolha: ");
            
            var choice = int.Parse(Console.ReadLine() ?? "0");
            
            switch (choice)
            {
                case 1:
                    Console.WriteLine(DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy HH:mm:ss"));
                    break;
                case 2:
                    Console.WriteLine(DateTime.Now.ToString("dd/MM/yyyy"));
                    break;
                case 3:
                    Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
                    break;
                case 4:
                    Console.WriteLine(DateTime.Now.ToString("dd 'de' MMMM 'de' yyyy"));
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}