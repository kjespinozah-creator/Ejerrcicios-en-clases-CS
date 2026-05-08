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
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int number))
            {
                Console.WriteLine("Entrada inválida. Por favor ingrese un número entero.");
                return;
            }

            bool result = primeService.IsPrime(number);

            if (result)
                Console.WriteLine($"{number} es un número primo.");
            else
                Console.WriteLine($"{number} no es un número primo.");
        }
    }
