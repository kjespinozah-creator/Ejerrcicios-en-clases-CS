
using System;

namespace CalculadoraGeometrica
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.Clear();

                Console.WriteLine("===== CALCULADORA GEOMÉTRICA =====");
                Console.WriteLine("1. Área de un cuadrado");
                Console.WriteLine("2. Área de un rectángulo");
                Console.WriteLine("3. Área de un triángulo");
                Console.WriteLine("4. Área de un círculo");
                Console.WriteLine("5. Volumen de un cubo");
                Console.WriteLine("6. Volumen de un cilindro");
                Console.WriteLine("7. Volumen de un cono");
                Console.WriteLine("8. Volumen de una esfera");
                Console.WriteLine("0. Salir");
                Console.Write("\nSeleccione una opción: ");

                opcion = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        AreaCuadrado();
                        break;

                    case 2:
                        AreaRectangulo();
                        break;

                    case 3:
                        AreaTriangulo();
                        break;

                    case 4:
                        AreaCirculo();
                        break;

                    case 5:
                        VolumenCubo();
                        break;

                    case 6:
                        VolumenCilindro();
                        break;

                    case 7:
                        VolumenCono();
                        break;

                    case 8:
                        VolumenEsfera();
                        break;

                    case 0:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

                if (opcion != 0)
                {
                    Console.WriteLine("\nPresione una tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opcion != 0);
        }

        // ===== ÁREAS =====

        static void AreaCuadrado()
        {
            Console.Write("Ingrese el lado del cuadrado: ");
            double lado = Convert.ToDouble(Console.ReadLine());

            double area = lado * lado;

            Console.WriteLine($"\nEl área del cuadrado es: {area}");
        }

        static void AreaRectangulo()
        {
            Console.Write("Ingrese la base: ");
            double baseRect = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double area = baseRect * altura;

            Console.WriteLine($"\nEl área del rectángulo es: {area}");
        }

        static void AreaTriangulo()
        {
            Console.Write("Ingrese la base: ");
            double baseTri = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double area = (baseTri * altura) / 2;

            Console.WriteLine($"\nEl área del triángulo es: {area}");
        }

        static void AreaCirculo()
        {
            Console.Write("Ingrese el radio: ");
            double radio = Convert.ToDouble(Console.ReadLine());

            double area = Math.PI * Math.Pow(radio, 2);

            Console.WriteLine($"\nEl área del círculo es: {area:F2}");
        }

        // ===== VOLÚMENES =====

        static void VolumenCubo()
        {
            Console.Write("Ingrese el lado del cubo: ");
            double lado = Convert.ToDouble(Console.ReadLine());

            double volumen = Math.Pow(lado, 3);

            Console.WriteLine($"\nEl volumen del cubo es: {volumen}");
        }

        static void VolumenCilindro()
        {
            Console.Write("Ingrese el radio: ");
            double radio = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double volumen = Math.PI * Math.Pow(radio, 2) * altura;

            Console.WriteLine($"\nEl volumen del cilindro es: {volumen:F2}");
        }

        static void VolumenCono()
        {
            Console.Write("Ingrese el radio: ");
            double radio = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double volumen = (Math.PI * Math.Pow(radio, 2) * altura) / 3;

            Console.WriteLine($"\nEl volumen del cono es: {volumen:F2}");
        }

        static void VolumenEsfera()
        {
            Console.Write("Ingrese el radio: ");
            double radio = Convert.ToDouble(Console.ReadLine());

            double volumen = (4.0 / 3.0) * Math.PI * Math.Pow(radio, 3);

            Console.WriteLine($"\nEl volumen de la esfera es: {volumen:F2}");
        }
    }
}