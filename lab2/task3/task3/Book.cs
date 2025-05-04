namespace task3
{
    public class Book : IBook
    {
        private string writing;

        public Book()
        {
            writing = "Writing";
        }

        public string GetWriting()
        {
            return writing;
        }
    }
}