namespace LibrarySystem
{
    internal class LibraryUser : User
    {

        public LibraryUser(string name)
        {
            Name = name;
        }

        public LibraryCard Card { get; set; }

        public void BorrowBook(Book book, Library library)
        {
            library.BorrowBook(book);
        }
    }
}