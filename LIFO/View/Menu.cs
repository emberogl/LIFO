namespace LIFO.View
{
    internal class Menu
    {
        // Outputs books in list
        public static void ShowBooks(List<Model.Book> books)
        {
            Console.Clear();
            for (int i = 0; i < books.Count; i++)
            {
                Console.WriteLine($"{i}. {books[i].GetTitle()} of {books[i].GetAuthor()}");
            }
        }

        // Lets user choose a book to borrow
        public static string ChooseBook()
        {
            Console.Title = "Borrowing...";
            Console.WriteLine("\nType 'q' to stop borrowing\n\n");
            Console.Write("Pick a book by entering its number: ");
            return Console.ReadLine()!;
        }

        public static void SuccessMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ReadKey();
            Console.ResetColor();
        }
        public static void ErrorMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ReadKey();
            Console.ResetColor();
        }

        public static void Clear()
        {
            Console.Clear();
        }
    }
}