namespace Shapes
{
    public class Circle : Figure
    {
        private double _radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius
        {
            get => _radius;
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("Radius value should be greater than 0");
                }
                else
                {
                    _radius = value;
                }
            }
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
