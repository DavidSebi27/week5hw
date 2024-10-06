using System.Transactions;

namespace assignment6
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
            Console.Write("Enter the number of votes to process: ");
            int size = int.Parse(Console.ReadLine());

            VotingSystem votingSystem = new VotingSystem(size);

            for (int i = 0; i < size; i++)
            {
                Console.Write($"\nEnter vote {i + 1} (Yes/No): ");
                string input = Console.ReadLine();

                if (Enum.TryParse(typeof(VoteOption), input, true, out var result) && Enum.IsDefined(typeof(VoteOption), result))
                {
                    votingSystem.CastVote((VoteOption)result);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter 'Yes' or 'No'.");
                    i--;
                }
            }

            votingSystem.DisplayResults();

            Console.ReadLine();
        }
    }
}
