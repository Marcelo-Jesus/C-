using AbstratoAprender.Entidades.Enum;


namespace Course.Entidades
{
    abstract class Shape
    {
        public Color Color { get; set; }
        public Shape(Color color ) 
        {
            Color = color;
        }

        public abstract double Area();


    }
}
