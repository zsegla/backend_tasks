using System;

class Program
{
    static void Main()
    {
        Library library = new Library("My Library", "123 Main St.");

        // Adding books to the library
        Book book1 = new Book("Book 1", "Author A", "ISBN123", 2020);
        Book book2 = new Book("Book 2", "Author B", "ISBN456", 2015);
        library.AddBook(book1);
        library.AddBook(book2);

        // Adding media items to the library
        MediaItem item1 = new MediaItem("Movie 1", "DVD", 120);
        MediaItem item2 = new MediaItem("Music CD", "CD", 60);
        library.AddMediaItem(item1);
        library.AddMediaItem(item2);

        // Displaying the library catalog
        library.PrintCatalog();
    }
}
