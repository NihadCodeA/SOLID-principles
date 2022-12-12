namespace OCP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AreaCalculator area = new AreaCalculator();
            Console.WriteLine("Circle area : " + area.Area(new Circle { Radius = 10 }));
            Console.WriteLine("Circle perimetr : " + area.Perimetr(new Circle { Radius = 5 })) ;
            Console.WriteLine("Triangle area : " + area.Area(new Triangle { Height = 5,Side=10 })) ;
            Console.WriteLine("Triangle perimetr : " + area.Perimetr(new Triangle { Side = 5,Hypotenuse=12 })) ;
        }
    }
}