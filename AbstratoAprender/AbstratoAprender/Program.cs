using AbstratoAprender.Entidades;
using AbstratoAprender.Entidades.Enum;
using Course.Entidades;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace AbstratoAprender
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shape = new List<Shape>();



            Console.Write("Entre com o número de figuras: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Figura #{i} data: ");
                Console.Write("Retângulo ou Círculo(r ou c): ");
                string r = Console.ReadLine();
                Console.Write("Cor (Preto, Azul ou Vermelho): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if(r == "r")
                {
                    Console.Write("Largura: ");
                    double largura = double.Parse(Console.ReadLine(),
                        CultureInfo.InvariantCulture);
                    Console.Write("Altura: ");
                    double altura = double.Parse(Console.ReadLine(),
                        CultureInfo.InvariantCulture);
                    shape.Add(new Retangulo(largura, altura, color));
                }
                else
                {
                    Console.Write("Raio: ");
                    double raio = double.Parse(Console.ReadLine(),
                        CultureInfo.InvariantCulture);
                    shape.Add(new Circulo(raio, color));
                }

            }

            Console.WriteLine();
            Console.WriteLine("Forma: ");
            foreach (Shape List in shape)
            {
                Console.WriteLine(List.Area().ToString("F2",
                    CultureInfo.InvariantCulture));
            }
        }
    }
}
