namespace assignment8
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
            Console.Write("How many books should there be in the library: ");
            int capacity = int.Parse(Console.ReadLine());

            Library library = new Library(capacity);

            for (int i = 0; i < capacity; i++)
            {
                Console.Write("\nEnter book title: ");
                string title = Console.ReadLine();

                Console.Write("Enter book author: ");
                string author = Console.ReadLine();

                Book book = new Book(title, author);

                library.AddBook(book);
            }

            library.DisplayBooks();

            Console.ReadLine();


        }
    }
}
