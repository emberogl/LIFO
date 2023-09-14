namespace LIFO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Adding some books to the available books list
            Model.Lending.AvailableBooks.Add(new Model.Book(id: 1, title: "The Great Gatsby", author: "F. Scott Fitzgerald"));
            Model.Lending.AvailableBooks.Add(new Model.Book(id: 2, title: "To Kill a Mockingbird", author: "Harper Lee"));
            Model.Lending.AvailableBooks.Add(new Model.Book(id: 3, title: "1984", author: "George Orwell"));
            Model.Lending.AvailableBooks.Add(new Model.Book(id: 4, title: "The Adventures of Huckleberry Finn", author: "Mark Twain"));


            Controller.ControllerClass controller = new();
            controller.Start();
        }
    }
}