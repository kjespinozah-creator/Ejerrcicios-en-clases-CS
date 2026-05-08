```csharp
using System;

namespace FigurasGeometricas
{
    // Clase base
    class Figura
    {
        public virtual double CalcularArea()
        {
            return 0;
        }

        public virtual double CalcularVolumen()
        {
            return 0;
        }
    }

    // ================= FIGURAS 2D =================

    class Cuadrado : Figura
    {
        public double Lado { get; set; }

        public Cuadrado(double lado)
        {
            Lado = lado;
        }

        public override double CalcularArea()
        {
            return Lado * Lado;
        }
    }

    class Rectangulo : Figura
    {
        public double BaseR { get; set; }
        public double Altura { get; set; }

        public Rectangulo(double baseR, double altura)
        {
            BaseR = baseR;
            Altura = altura;
        }

        public override double CalcularArea()
        {
            return BaseR * Altura;
        }
    }

    class Triangulo : Figura
    {
        public double BaseT { get; set; }
        public double Altura { get; set; }

        public Triangulo(double baseT, double altura)
        {
            BaseT = baseT;
            Altura = altura;
        }

        public override double CalcularArea()
        {
            return (BaseT * Altura) / 2;
        }
    }

    class Circulo : Figura
    {
        public double Radio { get; set; }

        public Circulo(double radio)
        {
            Radio = radio;
        }

        public override double CalcularArea()
        {
            return Math.PI * Radio * Radio;
        }
    }

    // ================= FIGURAS 3D =================

    class Cubo : Figura
    {
        public double Lado { get; set; }

        public Cubo(double lado)
        {
            Lado = lado;
        }

        public override double CalcularArea()
        {
            return 6 * (Lado * Lado);
        }

        public override double CalcularVolumen()
        {
            return Math.Pow(Lado, 3);
        }
    }

    class PrismaRectangular : Figura
    {
        public double Largo { get; set; }
        public double Ancho { get; set; }
        public double Altura { get; set; }

        public PrismaRectangular(double largo, double ancho, double altura)
        {
            Largo = largo;
            Ancho = ancho;
            Altura = altura;
        }

        public override double CalcularArea()
        {
            return 2 * ((Largo * Ancho) + (Largo * Altura) + (Ancho * Altura));
        }

        public override double CalcularVolumen()
        {
            return Largo * Ancho * Altura;
        }
    }

    class Esfera : Figura
    {
        public double Radio { get; set; }

        public Esfera(double radio)
        {
            Radio = radio;
        }

        public override double CalcularArea()
        {
            return 4 * Math.PI * Math.Pow(Radio, 2);
        }

        public override double CalcularVolumen()
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(Radio, 3);
        }
    }

    class Cilindro : Figura
    {
        public double Radio { get; set; }
        public double Altura { get; set; }

        public Cilindro(double radio, double altura)
        {
            Radio = radio;
            Altura = altura;
        }

        public override double CalcularArea()
        {
            return 2 * Math.PI * Radio * (Radio + Altura);
        }

        public override double CalcularVolumen()
        {
            return Math.PI * Math.Pow(Radio, 2) * Altura;
        }
    }

    class Cono : Figura
    {
        public double Radio { get; set; }
        public double Altura { get; set; }

        public Cono(double radio, double altura)
        {
            Radio = radio;
            Altura = altura;
        }

        public override double CalcularArea()
        {
            double generatriz = Math.Sqrt((Radio * Radio) + (Altura * Altura));
            return Math.PI * Radio * (Radio + generatriz);
        }

        public override double CalcularVolumen()
        {
            return (Math.PI * Math.Pow(Radio, 2) * Altura) / 3;
        }
    }

    // ================= PROGRAMA PRINCIPAL =================

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== FIGURAS GEOMÉTRICAS ===\n");

            // Cuadrado
            Cuadrado cuadrado = new Cuadrado(5);
            Console.WriteLine("Área del cuadrado: " + cuadrado.CalcularArea());

            // Rectángulo
            Rectangulo rectangulo = new Rectangulo(6, 4);
            Console.WriteLine("Área del rectángulo: " + rectangulo.CalcularArea());

            // Triángulo
            Triangulo triangulo = new Triangulo(10, 8);
            Console.WriteLine("Área del triángulo: " + triangulo.CalcularArea());

            // Círculo
            Circulo circulo = new Circulo(7);
            Console.WriteLine("Área del círculo: " + circulo.CalcularArea());

            // Cubo
            Cubo cubo = new Cubo(3);
            Console.WriteLine("Área del cubo: " + cubo.CalcularArea());
            Console.WriteLine("Volumen del cubo: " + cubo.CalcularVolumen());

            // Prisma rectangular
            PrismaRectangular prisma = new PrismaRectangular(5, 4, 3);
            Console.WriteLine("Área del prisma rectangular: " + prisma.CalcularArea());
            Console.WriteLine("Volumen del prisma rectangular: " + prisma.CalcularVolumen());

            // Esfera
            Esfera esfera = new Esfera(4);
            Console.WriteLine("Área de la esfera: " + esfera.CalcularArea());
            Console.WriteLine("Volumen de la esfera: " + esfera.CalcularVolumen());

            // Cilindro
            Cilindro cilindro = new Cilindro(3, 7);
            Console.WriteLine("Área del cilindro: " + cilindro.CalcularArea());
            Console.WriteLine("Volumen del cilindro: " + cilindro.CalcularVolumen());

            // Cono
            Cono cono = new Cono(3, 5);
            Console.WriteLine("Área del cono: " + cono.CalcularArea());
            Console.WriteLine("Volumen del cono: " + cono.CalcularVolumen());

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
```
