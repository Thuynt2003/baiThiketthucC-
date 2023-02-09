using GeometryExample;

class Program
{
    static void Main1(string[] args)
    {
        Cylinder cl = new Cylinder();
        Console.WriteLine("Enter the dimenstions of the cylinder");
        Console.WriteLine("Radius: ");
        cl.Radius = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Height: ");
        cl.Height = Convert.ToInt32(Console.ReadLine());
        cl.Process();
        cl.Result();

    }
    static void Main(string[] args)
    {
        Lion l = new Lion();
        l.SetMe(50, "lion");
        Tiger t = new Tiger();
        t.SetMe(70, "Tiger");
        l.Show();
        t.Show();
        
    }
}
