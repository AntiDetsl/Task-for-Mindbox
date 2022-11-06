using Shapes;

List<Figure> figures = new List<Figure> { new Circle(5), new Triangle(3,4,5), 
new Circle(10), new Triangle(7,4,8)};

foreach (var figure in figures)
{
    Console.WriteLine(figure.GetType().Name + " area: " + figure.Area());
}