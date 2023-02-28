using AbstratoAprender.Entidades.Enum;
using Course.Entidades;

namespace AbstratoAprender.Entidades
{
    class Retangulo : Shape
    {
       
        public double Largura { get; set; }
        public double Altura { get; set; }

        public Retangulo(double largura, double altura, Color color) : base(color)
        {
            Largura = largura;
            Altura = altura;
        }

        public override double Area()
        {
            return Largura * Altura;
        }
    }
}
