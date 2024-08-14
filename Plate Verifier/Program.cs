using System;
using System.Text.RegularExpressions;

namespace Plate_Verifier
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite a placa do veículo: ");
            var plate = Console.ReadLine();

            if (string.IsNullOrEmpty(plate))
            {
                Console.WriteLine("Placa inválida");
                return;
            }
            
            var platePattern = new Regex(@"^[a-zA-Z]{3}-\d{4}$");
            var isPlateValid = platePattern.IsMatch(plate);
            
            Console.WriteLine(isPlateValid ? "Placa válida" : "Placa inválida");
        }
    }
}