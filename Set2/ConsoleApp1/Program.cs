using ConsoleApp1;
using System.Drawing;

internal class Program
{
    private static void Main(string[] args)
    {
        //Question1
       
        Dimension.Rectangle rectangle = new Dimension.Rectangle(5, 10);
        Dimension.Square square = new Dimension.Square(4);
        Dimension.Circle circle = new Dimension.Circle(7);
        Console.WriteLine("Rectangle:");
        Console.WriteLine($"Sides: {rectangle.Sides()}");
        Console.WriteLine($"Area: {rectangle.Area()}");
        Console.WriteLine("\nSquare:");
        Console.WriteLine($"Sides: {square.Sides()}");
        Console.WriteLine($"Area: {square.Area()}");
        Console.WriteLine("\nCircle:");
        Console.WriteLine($"Sides: {circle.Sides()}");
        Console.WriteLine($"Area: {circle.Area()}");
        Console.ReadLine();
        //Question2
         List<String> list = new List<String> { "A", "B", "C" };
               foreach (var i in list){
              Console.WriteLine(i);
                  }
              Console.ReadLine();
          //Question3
          ListOperation.Disp();
    }
}