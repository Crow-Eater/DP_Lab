namespace task3
{
    public class BookProxy(User user) : IBook
    {
        private Book? book;
        private User user = user;

        public string GetWriting()
        {
            if (!user.IsRegistered)
            {
                return "Is not registered";
            }

            if (!user.HasAccess)
            {
                return "Not have access";
            }

            if (book == null)
            {
                book = new Book();
            }

            return book.GetWriting();
        }
    }

}