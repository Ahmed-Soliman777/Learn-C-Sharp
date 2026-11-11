namespace LibrarySystem
{
    internal abstract class User
    {
        public string Name { get; set; }

        public void DisplayBooks(Library library)
        {
            //association relation
            library.Display();
        }
    }
}