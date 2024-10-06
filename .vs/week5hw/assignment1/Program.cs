namespace assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            Rectangle rectangle = new Rectangle();

            Console.Write("Enter a width: ");
            rectangle.Width = int.Parse(Console.ReadLine());
            
            Console.Write("Enter a height: ");
            rectangle.Height = int.Parse(Console.ReadLine());

            double area = rectangle.CalculateArea();
            double perimeter = rectangle.CalculatePerimeter();

            Console.WriteLine($"Area: {area}");
            Console.WriteLine($"Perimeter: {perimeter}");
        }

    }
}
