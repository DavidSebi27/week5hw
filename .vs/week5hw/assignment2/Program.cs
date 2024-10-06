namespace assignment2
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
            Console.Write("Enter a day of the week: ");
            string input = Console.ReadLine();

            if (Enum.TryParse<Day>(input, true, out Day day))
            {
                PrintMessageForDay(day);
            }
            else
            {
                Console.WriteLine("Invalid day entered. Please enter a valid day of the week.");
            }

            Console.ReadLine();
        }

        void PrintMessageForDay(Day day)
        {
            switch (day)
            {
                case Day.Monday:
                    Console.WriteLine("Start of the work week!");
                    break;
                case Day.Tuesday:
                    Console.WriteLine("It's Tuesday!");
                    break;
                case Day.Wednesday:
                    Console.WriteLine("It's midweek already!");
                    break;
                case Day.Thursday:
                    Console.WriteLine("Almost there!");
                    break;
                case Day.Friday:
                    Console.WriteLine("It's Friday, the weekend is near!");
                    break;
                case Day.Saturday:
                    Console.WriteLine("Enjoy your Saturday!");
                    break;
                case Day.Sunday:
                    Console.WriteLine("Rest and prepare for the week ahead.");
                    break;
            }
        }
    }
}
