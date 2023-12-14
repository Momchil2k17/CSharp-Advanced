namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(3, 4);
            Circle c = new Circle(5);
            Console.WriteLine(r.Draw());
            Console.WriteLine(c.Draw());
        }
    }
}