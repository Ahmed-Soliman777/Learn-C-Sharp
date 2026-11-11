using System;

namespace LibrarySystem
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Library library = new Library();

            Console.WriteLine("--------------------------");

            Console.WriteLine("Welcome to library system!");

            Console.WriteLine("--------------------------");

            Console.WriteLine("Are you librarian or a regular user? (L / R)");

            char UserType = Console.ReadLine()!.ToUpper()[0];

            if (UserType == 'L')
            {
                Console.WriteLine("Please enter your name:");

                string LibrarianName = Console.ReadLine()!;

                Librarian librarian = new Librarian(LibrarianName);

                Console.WriteLine($"Welcome {LibrarianName}");

                Console.WriteLine("--------------------------");
                while (true)
                {

                    Console.WriteLine("Please choose to Add book (A) / Display Books (D)");

                    char choice = Console.ReadLine()!.ToUpper()[0];

                    switch (choice)
                    {
                        case 'A':
                            // add book
                            Console.WriteLine("Enter book name: ");
                            string BookTitle = Console.ReadLine()!;

                            Console.WriteLine("Enter book author: ");
                            string BookAuthor = Console.ReadLine()!;

                            Console.WriteLine("Enter book year: ");
                            string BookYear = Console.ReadLine()!;

                            int BookYearNumber = Convert.ToInt32(BookYear);

                            Book book = new Book()
                            {
                                Title = BookTitle,
                                Author = BookAuthor,
                                Year = BookYearNumber,
                            };

                            librarian.AddBook(book, library);
                            break;
                        case 'D':
                            // display books
                            Console.WriteLine("Book list:");
                            librarian.DisplayBooks(library);
                            break;
                        default:
                            Environment.Exit(0);
                            break;
                    }
                }
            }
            else if (UserType == 'R')
            {
                Console.WriteLine("Please enter your name:");

                string UserName = Console.ReadLine()!;

                LibraryUser RegualarUser = new LibraryUser(UserName);

                Console.WriteLine($"Welcome {UserName}");

                Console.WriteLine("--------------------------");


                while (true)
                {

                    Console.WriteLine("Please choose to Borrow book (B) / Display Books (D)");

                    char choice = Console.ReadLine()!.ToUpper()[0];

                    switch (choice)
                    {
                        case 'B':
                            // borrow book
                            Console.WriteLine("Enter book name: ");
                            string BookTitle = Console.ReadLine()!;

                            Console.WriteLine("Enter book author: ");
                            string BookAuthor = Console.ReadLine()!;

                            Console.WriteLine("Enter book name: ");
                            string BookYear = Console.ReadLine()!;

                            int BookYearNumber = Convert.ToInt32(BookYear);

                            Book book = new Book()
                            {
                                Title = BookTitle,
                                Author = BookAuthor,
                                Year = BookYearNumber,
                            };

                            RegualarUser.BorrowBook(book, library);
                            break;
                        case 'D':
                            // display books
                            Console.WriteLine("Book list:");
                            RegualarUser.DisplayBooks(library);
                            break;
                        default:
                            Environment.Exit(0);
                            break;
                    }
                }

            }
            else
            {
                Console.WriteLine("Please enter correct value (L / R)");
            }
        }
    }
}