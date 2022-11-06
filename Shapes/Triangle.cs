namespace Shapes
{
    public class Triangle : Figure
    {
        private double[] _sides = new double[3];

        public Triangle(double a, double b, double c)
        {
            A = a; 
            B = b; 
            C = c;

            if (!IsExist(A, B, C))
            {
                throw new ArgumentException("Length of a side has to be less than the sum of the lengths of other two sides");
            }
        }

        public double A
        {
            get => _sides[0];
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Value should be greater than 0");
                }
                else
                {
                    _sides[0] = value;
                }
            }
        }

        public double B
        {
            get => _sides[1];
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Value should be greater than 0");
                }
                else
                {
                    _sides[1] = value;
                }
            }
        }

        public double C
        {
            get => _sides[2];
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Value should be greater than 0");
                }
                else
                {
                    _sides[2] = value;
                }
            }
        }

        public override double Area()
        {
            return B * C * Sin(A, B, C) / 2;
        }

        public bool IsRectangled()
        {
            double temp = _sides.Sum(i => i * i);
            return 2 * _sides.Max(i => i * i) - temp < 1e-7;
        }

        private bool IsExist(double a, double b, double c)
        {
            if(a + b > c && a + c > b && c + b > a)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private double Sin(double a, double b, double c)
        {
            double cos = (b * b + c * c - a * a) / (2 * b * c);
            return Math.Sqrt(1 - cos * cos);
        }
    }
}
