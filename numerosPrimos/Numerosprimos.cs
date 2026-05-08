using System;

namespace numerosPrimos
{
    public class PrimeService
    {
        // Método que determina si un número es primo
        public bool IsPrime(int number)
        {
            if (number <= 1)
                return false;

            if (number == 2)
                return true;

            if (number % 2 == 0)
                return false;

            int limit = (int)Math.Sqrt(number);

            for (int i = 3; i <= limit; i += 2)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PrimeService primeService = new PrimeService();

            Console.Write("Ingrese un número: ");
            int number = int.Parse(Console.ReadLine());

            bool result = primeService.IsPrime(number);

            if (result)
                Console.WriteLine($"{number} es un número primo.");
            else
                Console.WriteLine($"{number} no es un número primo.");
        }
    }
}