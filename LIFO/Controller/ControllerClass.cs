namespace LIFO.Controller
{
    public class ControllerClass
    {
        public void Start()
        {
            while (true)
            {

                View.Menu.ShowBooks(Model.Lending.AvailableBooks);

                string choice = View.Menu.ChooseBook();

                if (choice == "q")
                {
                    if (Model.Lending.BorrowedBooks.Count == 0) // Cannot show borrowed books when user has not borrowed books

                    {
                        View.Menu.ErrorMessage("\nYou haven't borrowed any books");
                        Start();
                    }
                    break;
                }
                else if (int.TryParse(choice, out int intChoice) && intChoice >= 0 && intChoice < Model.Lending.AvailableBooks.Count) // If book user wants to borrow is the size of available books

                {
                    Model.Lending.BorrowedBooks.Push(Model.Lending.AvailableBooks[intChoice]); // Push to stack
                    Model.Lending.AvailableBooks.RemoveAt(intChoice); // Book longer available

                }
                else
                {
                    View.Menu.ErrorMessage("\nInvalid choice"); // User input did not meet requirements
                }
            }
            View.Menu.Clear();
            while (Model.Lending.BorrowedBooks.Count > 0)
            {
                // Getting book at top of stack
                Model.Book book = Model.Lending.BorrowedBooks.Peek();
                Console.WriteLine($"Borrowed: {book.GetTitle()} by {book.GetAuthor()}");
                // Removing book at top of stack "scanning books at library"
                Model.Lending.BorrowedBooks.Pop();
            }
            View.Menu.SuccessMessage("\nBorrowed books successfully");
        }
    }
}
