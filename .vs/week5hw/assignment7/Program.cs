namespace assignment7
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
            Console.Write("Enter student name: ");
            string name = Console.ReadLine();

            Console.Write("Enter amount of grades to process: ");
            int amount = int.Parse(Console.ReadLine());

            int[] grades = new int[amount];
            for (int i = 0; i < amount; i++)
            {
                Console.Write($"Enter grade {i + 1}: ");
                grades[i] = int.Parse(Console.ReadLine());
            }

            Student student = new Student(name, grades);

            student.DisplayGrades();

            double avg = student.CalculateAverage();

            Console.WriteLine($"Average grade: {avg}");
            Console.ReadLine();
        }
    }
}
