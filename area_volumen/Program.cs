using System;

namespace Geometria
{
    public class Cono
    {
        public double Radio { get; set; }
        public double Altura { get; set; }

        public Cono(double radio, double altura)
        {
            Radio = radio;
            Altura = altura;
        }

        // Generatriz
        public double CalcularGeneratriz()
        {
            return Math.Sqrt(Math.Pow(Radio, 2) + Math.Pow(Altura, 2));
        }

        // Área lateral
        public double CalcularAreaLateral()
        {
            double g = CalcularGeneratriz();
            return Math.PI * Radio * g;
        }

        // Área total
        public double CalcularAreaTotal()
        {
            double g = CalcularGeneratriz();
            return Math.PI * Radio * (Radio + g);
        }

        // Volumen
        public double CalcularVolumen()
        {
            return (Math.PI * Math.Pow(Radio, 2) * Altura) / 3;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el radio: ");
            double radio = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la altura: ");
            double altura = double.Parse(Console.ReadLine());

            Cono cono = new Cono(radio, altura);

            Console.WriteLine("\nResultados:");
            Console.WriteLine($"Generatriz: {cono.CalcularGeneratriz():F2}");
            Console.WriteLine($"Área lateral: {cono.CalcularAreaLateral():F2}");
            Console.WriteLine($"Área total: {cono.CalcularAreaTotal():F2}");
            Console.WriteLine($"Volumen: {cono.CalcularVolumen():F2}");
        }
    }
}