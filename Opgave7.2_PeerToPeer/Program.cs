
using Opgave7._2_PeerToPeer;
using Opgave7._2_PeerToPeer.Shapes;
using Opgave7._2_PeerToPeer.Shapes.Adapters;

internal class Program
{
    private static void Main(string[] args)
    {
        List<IShape> shapes = new()
        {
            new Circle(2),
            new Rectangle(5, 5),
            new RhombusAdapter(10, 10),
            new TriangleAdapter(15, 15, 15)
        };

        shapes.ForEach(x => x.PrintMe());

        double totalAreaOfShapes = shapes.Sum(x => x.Area());
        Console.WriteLine($"Area of all shapes is: {totalAreaOfShapes}");
    }
}