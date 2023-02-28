using AbstratoAprender.Entidades.Enum;
using Course.Entidades;
using System;

namespace AbstratoAprender.Entidades
{
    class Circulo : Shape
    {
        public double Raio { get; set;  }

        public Circulo(double raio, Color color) : base(color)
        {
            Raio = raio;
        }

        public override double Area()
        {
            return Math.PI * Raio * Raio;
        }
    }
}
