namespace LibrarySystem
{
    internal class Library
    {
        private Book[] Books = new Book[100];

        private Book[] BorrowedBooks = new Book[50];

        private int CurrentBookCount = 0;

        private int CurrentBorrowedBookCount = 0;

        public void Display()
        {
            for (int i = 0; i < CurrentBookCount; i++)
            {
                Console.WriteLine($"{i + 1}. Book title: {Books[i].Title}");
            }
        }

        public void Add(Book book)
        {
            if (CurrentBookCount < Books.Length)
            {
                Books[CurrentBookCount] = book;
                CurrentBookCount++;
                Console.WriteLine("Book added successfully");
            }
            else
            {
                Console.WriteLine("Library is full, can not add a new book.");
            }
        }

        public void BorrowBook(Book book)
        {
            if (CurrentBorrowedBookCount < BorrowedBooks.Length)
            {
                BorrowedBooks[CurrentBorrowedBookCount] = book;
                CurrentBorrowedBookCount++;
                Console.WriteLine("Book borrowed successfully");
            }
            else
            {
                Console.WriteLine("Sorry, can not borrow books, please try again later.");
            }
        }
    }
}