namespace LIFO.Model
{
    internal class Lending
    {
        // Stack to push and pop books
        public static Stack<Book> BorrowedBooks { get; set; } = new Stack<Book>();
        // The available books list
        public static List<Book> AvailableBooks { get; set; } = new List<Book>();
    }
}
