namespace LIFO.Model
{
    public class Book
    {
        private int _id;
        private string _title;
        private string _author;

        public Book(int id, string title, string author) 
        {
            _id = id;
            _title = title;
            _author = author;
        }

        public string GetTitle()
        {
            return _title;
        }

        public string GetAuthor()
        {
            return _author;
        }
    }
}
