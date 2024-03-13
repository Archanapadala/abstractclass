namespace abstractclass
{
   

    // Abstract class
    public abstract class Shape
    {
        // Abstract method that must be implemented by derived classes
        public abstract double Area();
    }

    // Derived class
    public class Circle : Shape
    {
        private double radius;

        // Constructor
        public Circle(double radius)
        {
            this.radius = radius;
        }

        // Implementation of abstract method
        public override double Area()
        {
            return Math.PI * radius * radius;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of Circle
            Circle circle = new Circle(5);

            // Call the Area method
            double area = circle.Area();

            // Output the result
            Console.WriteLine($"Area of the circle: {area}");
        }
    }

}
