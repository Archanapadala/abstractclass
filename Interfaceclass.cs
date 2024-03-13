
namespace abstractclass
{
    using System;

    // Define the interface
    public interface IShape
    {
        // Method declaration for calculating the area
        double Area();
    }

    // Define a class that implements the interface
    public class Rectangle : IShape
    {
        private double length;
        private double width;

        // Constructor
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        // Implementation of the Area method
        public double Area()
        {
            return length * width;
        }
    }

    class Interfaceclass
    {
        static void Main(string[] args)
        {
            // Create an instance of Rectangle
            Rectangle rectangle = new Rectangle(5, 4);

            // Call the Area method
            double area = rectangle.Area();

            // Output the result
            Console.WriteLine($"Area of the rectangle: {area}");
        }
    }


}
