namespace LibrarySystem
{
    internal class Librarian : User
    {
        public Librarian(string name)
        {
            Name = name;
        }

        public int EmpolyeeNumber { get; set; }

        public void AddBook(Book NewBook, Library library)
        {
            //association relation
            library.Add(NewBook);
        }
    }
}